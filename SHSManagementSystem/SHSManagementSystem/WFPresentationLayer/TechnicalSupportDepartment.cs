using BusinessLayer.io.customerManagement.customer;
using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiry;
using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiryEnquiry;
using BusinessLayer.io.search.criteria;
using BusinessLayer.io.technicalSupport.technicalTask;
using BusinessLogicLayer.io.customerManagement.customer;
using BusinessLogicLayer.io.customerManagement.enquiries.technicalSupportEnquiry;
using BusinessLogicLayer.io.fileHandler;
using BusinessLogicLayer.io.technicalSupport.technicalTask;
using DataAccessLayer.io;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TechnicalSupportDepartment : Form
    {
        private ICustomerRecordKeeper customerRecordKeeper = new CustomerRecordKeeper(new UnitOfWork(new SHSDatabaseContext()), new FileHandler());
        private ITechnicalSupportEnquiryRecordKeeper technicalSupportEnquiryRecordKeeper = new TechnicalSupportEnquiryRecordKeeper(new UnitOfWork(new SHSDatabaseContext()), new FileHandler());
        private ITechnicalTaskRecordKeeper technicalTaskRecordKeeper = new TechnicalTaskRecordKeeper(new UnitOfWork(new SHSDatabaseContext()), new FileHandler());

        private List<TechnicalTask> tasks = new List<TechnicalTask>();
        private List<Customer> customers = new List<Customer>();
        private DateTime callTime;
        Stopwatch timer;
        public TechnicalSupportDepartment()
        {
            InitializeComponent();
            BindData();
        }

        public void BindData()
        {
            if (dgvSchedule.DataSource == null && tasks.Count == 0)
            {
                tasks = technicalTaskRecordKeeper.FindTechnicalTask(new FindTechnicalTaskRequest().setSearchCriteria(new AllSearch())).getTechnicalTasks();

                dgvSchedule.AutoGenerateColumns = false;
                dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvSchedule.ColumnCount = 3;

                dgvSchedule.Columns[0].HeaderText = "Tracking Number";
                dgvSchedule.Columns[0].Name = "TrackingNumber";
                dgvSchedule.Columns[0].DataPropertyName = "trackingNumber";

                dgvSchedule.Columns[1].HeaderText = "Task Description";
                dgvSchedule.Columns[1].Name = "TaskDescription";
                dgvSchedule.Columns[1].DataPropertyName = "taskDescription";

                dgvSchedule.Columns[2].HeaderText = "Completed";
                dgvSchedule.Columns[2].Name = "Completed";
                dgvSchedule.Columns[2].DataPropertyName = "completed";

                dgvSchedule.DataSource = tasks;

                txtTrackingNumber.DataBindings.Add("Text", tasks, "TrackingNumber");
                txtTaskDescription.DataBindings.Add("Text", tasks, "TaskDescription");
            }
            else if (tasks.Count > 0)
            {
                dgvSchedule.DataSource = null;
                dgvSchedule.DataSource = tasks;
                dgvSchedule.Update();
                dgvSchedule.Refresh();
            }

            if (dgvEnquiries.DataSource == null && customers.Count == 0)
            {
                List<Expression<Func<Customer, object>>> customerIncluders = new List<Expression<Func<Customer, object>>>();
                customerIncluders.Add(x => x.Address);
                customerIncluders.Add(x => x.ContactInformation);
                customerIncluders.Add(x => x.CustomerEnquiries);

                customers = customerRecordKeeper.FindCustomer(new FindCustomerRequest().setSearchCriteria(new AllSearch())).getCustomers();

                txtName.DataBindings.Add("Text", customers, "Name");
                txtEmailAddress.DataBindings.Add("Text", customers, "ContactInformation.Email");
                txtPhoneNumber.DataBindings.Add("Text", customers, "ContactInformation.MobileNumber");
                cmbCustomerIDSearch.DataSource = customers;

                cmbCustomerIDSearch.DisplayMember = "ID";
                cmbCustomerIDSearch.ValueMember = "ID";

                dgvEnquiries.AutoGenerateColumns = false;
                dgvEnquiries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvEnquiries.ColumnCount = 1;

                dgvEnquiries.Columns[0].HeaderText = "Tracking Number";
                dgvEnquiries.Columns[0].Name = "TrackingNumber";
                dgvEnquiries.Columns[0].DataPropertyName = "trackingNumber";
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }


        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            new TechnicalSupportDepartment().Show();
            this.Hide();
            this.Dispose();
        }

        private void btnConfirmTEnquiry_Click(object sender, EventArgs e)
        {
            Customer customer = customerRecordKeeper.RetrieveCustomer(new RetrieveCustomerRequest().setCustomerId(cmbCustomerIDSearch.Text)).getCustomer();

            if (!customer.Contract.ContractType.FreeTechnicalSupport)
            {
                DialogResult dialogResult = MessageBox.Show("Customer Contract Doesn't Include Free Technical Support, Billing On Visit Applies.", "Technical Support Costs Apply", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    submitTechnicalEnquiry(customer);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                submitTechnicalEnquiry(customer);
            }

            new FileHandler("logs/" + callTime.DayOfYear.ToString() + "Call_Log.txt").AppendToTxt(new List<string> { "Call Time: " + timer.ElapsedMilliseconds.ToString() + "ms  Call Ended: " + DateTime.UtcNow });

            new TechnicalSupportDepartment().Show();
            this.Hide();
            this.Dispose();
        }

        private void submitTechnicalEnquiry(Customer customer)
        {
            CustomerEnquiry customerEnquiry = dgvEnquiries.CurrentRow.DataBoundItem as CustomerEnquiry;

            TechnicalSupportEnquiry technicalSupportEnquiry = new TechnicalSupportEnquiry(customerEnquiry.TrackingNumber, customerEnquiry.EnquiryDateTime, customerEnquiry.EnquiryNote);

            technicalSupportEnquiry.TechnicalTask = new TechnicalTask(false, rTechnicalTaskDesc.Text, DateTime.UtcNow);

            var index = customer.CustomerEnquiries.FindIndex(c => c.TrackingNumber == customerEnquiry.TrackingNumber);

            customer.CustomerEnquiries[index] = technicalSupportEnquiry;

            technicalSupportEnquiryRecordKeeper.CreateTechnicalSupportEnquiry(new CreateTechnicalSupportEnquiryRequest().setTechnicalSupportEnquiry(technicalSupportEnquiry));

            customerRecordKeeper.UpdateCustomer(new UpdateCustomerRequest().setCustomer(customer));
        }

        private void btnFindCustomerEnquiry_Click(object sender, EventArgs e)
        {
            List<CustomerEnquiry> customerEnquiries = customers.Single(c => c.ID == cmbCustomerIDSearch.Text).CustomerEnquiries;
            dgvEnquiries.DataSource = customerEnquiries;
            rtxtEnquiryNote.DataBindings.Clear();
            rtxtEnquiryNote.DataBindings.Add("Text", customerEnquiries, "EnquiryNote");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SupportControl.SelectedTab = tabTAdd;
            dgvEnquiries.Update();
            dgvEnquiries.Refresh();
        }

        private void dgvSchedule_SelectionChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = (dgvSchedule.CurrentRow.DataBoundItem as TechnicalTask).CustomerEnquiry.Customer.ID;
            rtxtAddress.Text = (dgvSchedule.CurrentRow.DataBoundItem as TechnicalTask).CustomerEnquiry.Customer.Address.ToString();
        }

        private void btnAnswerCall_Click(object sender, EventArgs e)
        {
            btnHoldCall.Enabled = true;
            btnEndCall.Enabled = true;
            btnAnswerCall.Enabled = false;

            callTime = DateTime.UtcNow;
            new FileHandler("logs/" + callTime.DayOfYear.ToString() + "Call_Log.txt").WriteToTxt(new List<string> { "Call Started ..." });
            timer = Stopwatch.StartNew();
        }
        private void btnHoldCall_Click(object sender, EventArgs e)
        {
            btnAnswerCall.Enabled = true;
            btnHoldCall.Enabled = false;
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            btnHoldCall.Enabled = false;
            btnEndCall.Enabled = false;
            btnAnswerCall.Enabled = true;
            new FileHandler("logs/" + callTime.DayOfYear.ToString() + "Call_Log.txt").AppendToTxt(new List<string> { "Call Time: " +timer.ElapsedMilliseconds.ToString()+ "ms  Call Ended: " + DateTime.UtcNow });
            timer.Stop();
        }
    }
}