using BusinessLayer.io.customerManagement.customer;
using BusinessLayer.io.customerManagement.customer.billing;
using BusinessLayer.io.customerManagement.customer.contract;
using BusinessLayer.io.customerManagement.customer.productConfiguration;
using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.productManagement.product;
using BusinessLayer.io.search.criteria;
using BusinessLayer.io.users.address;
using BusinessLayer.io.users.contactInformation;
using BusinessLogicLayer.io.contractTypeManagement.contractType.contract;
using BusinessLogicLayer.io.customerManagement.customer;
using BusinessLogicLayer.io.fileHandler;
using DataAccessLayer.io;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using WFPresentationLayer;

namespace WindowsFormsApplication1
{
    public partial class CustomerManagementDepartment : Form
    {
        private static SHSDatabaseContext sHSDatabaseContext = new SHSDatabaseContext();
        private ICustomerRecordKeeper customerRecordKeeper = new CustomerRecordKeeper(new UnitOfWork(sHSDatabaseContext), new FileHandler());
        private IContractTypeRecordKeeper contractTypeRecordKeeper = new ContractTypeRecordKeeper(new UnitOfWork(sHSDatabaseContext), new FileHandler());
        private List<Customer> customers;
        private List<ContractType> contractTypes;

        private DateTime callTime;
        Stopwatch timer;
        public CustomerManagementDepartment()
        {
            InitializeComponent();
        }

        private void CustomerManagementDepartment_Load(object sender, EventArgs e)
        {
            BindData();
        }


        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            customerRecordKeeper.UpdateCustomer(new UpdateCustomerRequest().setCustomer(dgvMngCust.CurrentRow.DataBoundItem as Customer));
            BindData();
        }

        private void btnCustRemove_Click(object sender, EventArgs e)
        {
            customerRecordKeeper.RemoveCustomer(new RemoveCustomerRequest().setCustomer(dgvMngCust.CurrentRow.DataBoundItem as Customer));
            BindData();
        }

        private void btnCReg_Click(object sender, EventArgs e)
        {
            customerRecordKeeper.CreateCustomer(new CreateCustomerRequest().setCustomer(
            new Customer(txtRSAID.Text, txtCustTitle.Text, txtCustName.Text, txtCustFullName.Text, txtCustSurname.Text, txtCustGender.Text,
            new ContactInformation(txtCustWorkTel.Text, txtCustMobile.Text, txtCustEmail.Text), Convert.ToDateTime(dtCustDOB.Text),
            new Address(txtCustAddressLine1.Text, txtCustAddressLine2.Text, txtCustCity.Text, txtCustCountry.Text, txtCustPostalCode.Text, txtCustSuburb.Text),
            new CustomerProductConfiguration(new List<Product>(), "No Configuration As Of Yet"),
            new BillingInformation(txtAccountNumber.Text,txtBank.Text, txtBranch.Text, new List<BillingInvoice>()),
            new Contract(cmbContractType.SelectedItem as ContractType,
                Convert.ToDateTime(dtContractEndDate.Value))
            )));
            new CustomerManagementDepartment().Show();
            this.Hide();
        }

        private void btnCReset_Click(object sender, EventArgs e)
        {
            new CustomerManagementDepartment().Show();
            this.Hide();
        }

        private void BindData()
        {
            customers = customerRecordKeeper.FindCustomer(new FindCustomerRequest().setSearchCriteria(new AllSearch())).getCustomers();
            contractTypes = contractTypeRecordKeeper.FindContractType(new FindContractTypeRequest().setSearchCriteria(new AllSearch())).getContractTypes();
            if (dgvMngCust.DataSource == null && customers.Count > 0)
            {
                dgvMngCust.AutoGenerateColumns = false;
                dgvMngCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvMngCust.ColumnCount = 5;

                dgvMngCust.Columns[0].HeaderText = "ID";
                dgvMngCust.Columns[0].Name = "ID";
                dgvMngCust.Columns[0].DataPropertyName = "id";

                dgvMngCust.Columns[1].HeaderText = "Title";
                dgvMngCust.Columns[1].Name = "Title";
                dgvMngCust.Columns[1].DataPropertyName = "title";

                dgvMngCust.Columns[2].HeaderText = "Name";
                dgvMngCust.Columns[2].Name = "Name";
                dgvMngCust.Columns[2].DataPropertyName = "name";

                dgvMngCust.Columns[3].HeaderText = "Surname";
                dgvMngCust.Columns[3].Name = "Surname";
                dgvMngCust.Columns[3].DataPropertyName = "surname";

                dgvMngCust.Columns[4].HeaderText = "Gender";
                dgvMngCust.Columns[4].Name = "Gender";
                dgvMngCust.Columns[4].DataPropertyName = "gender";

                dgvMngCust.DataSource = customers;

                txtUpName.DataBindings.Add("Text", customers, "Name");
                txtUpSurname.DataBindings.Add("Text", customers, "Surname");
                txtUpTitle.DataBindings.Add("Text", customers, "Title");
                txtUpGender.DataBindings.Add("Text", customers, "Gender");
                txtUpFullName.DataBindings.Add("Text", customers, "FullName");

                txtUpEmail.DataBindings.Add("Text", customers, "ContactInformation.Email");
                txtUpWorkTel.DataBindings.Add("Text", customers, "ContactInformation.WorkNumber");
                txtUpMobile.DataBindings.Add("Text", customers, "ContactInformation.MobileNumber");

                txtUpCity.DataBindings.Add("Text", customers, "Address.City");
                txtUpCountry.DataBindings.Add("Text", customers, "Address.Country");
                txtUpAddressLine1.DataBindings.Add("Text", customers, "Address.AddressLine1");
                txtUpAddressLine2.DataBindings.Add("Text", customers, "Address.AddressLine2");
                txtUpPostalCode.DataBindings.Add("Text", customers, "Address.PostalCode");
                txtUpSuburb.DataBindings.Add("Text", customers, "Address.Suburb");
            }
            else
            {
                dgvMngCust.DataSource = null;
                dgvMngCust.DataSource = customers;
                dgvMngCust.Update();
                dgvMngCust.Refresh();
            }

            if (dgvCustomers.DataSource == null && customers.Count > 0)
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvCustomers.ColumnCount = 5;

                dgvCustomers.Columns[0].HeaderText = "ID";
                dgvCustomers.Columns[0].Name = "ID";
                dgvCustomers.Columns[0].DataPropertyName = "id";

                dgvCustomers.Columns[1].HeaderText = "Title";
                dgvCustomers.Columns[1].Name = "Title";
                dgvCustomers.Columns[1].DataPropertyName = "title";

                dgvCustomers.Columns[2].HeaderText = "Name";
                dgvCustomers.Columns[2].Name = "Name";
                dgvCustomers.Columns[2].DataPropertyName = "name";

                dgvCustomers.Columns[3].HeaderText = "Surname";
                dgvCustomers.Columns[3].Name = "Surname";
                dgvCustomers.Columns[3].DataPropertyName = "surname";

                dgvCustomers.Columns[4].HeaderText = "Gender";
                dgvCustomers.Columns[4].Name = "Gender";
                dgvCustomers.Columns[4].DataPropertyName = "gender";

                dgvCustomers.DataSource = customers;
                txtPhone.DataBindings.Add("Text", customers, "ContactInformation.MobileNumber");
                txtEmail.DataBindings.Add("Text", customers, "ContactInformation.Email");
                txtCName.DataBindings.Add("Text", customers, "Name");
                cmbCustomerIDSearch.DataBindings.Add("Text", customers, "ID");
            }
            else
            {
                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = customers;
                dgvCustomers.Update();
                dgvCustomers.Refresh();
            }

            if (dgvContracts.DataSource == null && contractTypes.Count > 0)
            {
                dgvContracts.AutoGenerateColumns = false;
                dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvContracts.ColumnCount = 4;

                dgvContracts.Columns[0].HeaderText = "Contract ID";
                dgvContracts.Columns[0].Name = "ContractID";
                dgvContracts.Columns[0].DataPropertyName = "contractID";

                dgvContracts.Columns[1].HeaderText = "Contract Name";
                dgvContracts.Columns[1].Name = "ContractName";
                dgvContracts.Columns[1].DataPropertyName = "contractName";

                dgvContracts.Columns[2].HeaderText = "Included Credit %";
                dgvContracts.Columns[2].Name = "IncludedCreditPercentage";
                dgvContracts.Columns[2].DataPropertyName = "includedCreditPercentage";

                dgvContracts.Columns[3].HeaderText = "Free Technical Support";
                dgvContracts.Columns[3].Name = "FreeTechnicalSupport";
                dgvContracts.Columns[3].DataPropertyName = "freeTechnicalSupport";

                dgvContracts.DataSource = contractTypes;
                cmbContractType.DataSource = contractTypes;
                cmbContractType.DisplayMember = "ContractName";
                cmbContractType.ValueMember = "ContractName";
            }
            else
            {
                dgvContracts.DataSource = null;
                dgvContracts.DataSource = contractTypes;
                dgvContracts.Update();
                dgvContracts.Refresh();
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void btnCreateCustomerEnquiry_Click(object sender, EventArgs e)
        {
            Customer customer = customerRecordKeeper.RetrieveCustomer(new RetrieveCustomerRequest().setCustomerId((dgvCustomers.CurrentRow.DataBoundItem as Customer).ID)).getCustomer();
            customer.CustomerEnquiries.Add(new CustomerEnquiry(DateTime.UtcNow, rtxtEnquiryNote.Text));
            customerRecordKeeper.UpdateCustomer(new UpdateCustomerRequest().setCustomer(customer));
            btnDivertCallToSales.Enabled = true;
            btnDivertCallToTechnicalSupport.Enabled = true;
        }

        private void btnDivertCallToSales_Click(object sender, EventArgs e)
        {
            new SalesManagementDepartment().Show();
            this.Hide();
        }

        private void btnDivertCallToTechnicalSupport_Click(object sender, EventArgs e)
        {
            new TechnicalSupportDepartment().Show();
            this.Hide();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnViewCustomerAdditionalInfo_Click(object sender, EventArgs e)
        {
            new CustomerManagementAdditionalInformation((dgvCustomers.CurrentRow.DataBoundItem as Customer).ID).Show(this);
            this.Hide();
        }

        private void btnConfirmNewContract_Click(object sender, EventArgs e)
        {
            ServiceLevel serviceLevel = ServiceLevel.EntryLevel;
            switch (cmbServiceLevel.SelectedItem.ToString())
            {
                case "Entry":
                    serviceLevel = ServiceLevel.EntryLevel;
                    break;
                case "Deluxe":
                    serviceLevel = ServiceLevel.Deluxe;
                    break;
                case "Premium":
                    serviceLevel = ServiceLevel.Premium;
                    break;
                case "Ultimate":
                    serviceLevel = ServiceLevel.Ultimate;
                    break;
                default:
                    break;
            }
            contractTypeRecordKeeper.CreateContractType(new CreateContractTypeRequest().setContractType(
                new ContractType(Convert.ToDouble(numIncludedCredit.Value)/100, serviceLevel, chkTechnicalSupportIncluded.Checked, txtContractName.Text)));

            CustomerManagementDepartment customerManagementDepartment = new CustomerManagementDepartment();
            customerManagementDepartment.CustControl.SelectedTab = customerManagementDepartment.tabManageContracts;
            customerManagementDepartment.Show();
            this.Hide();
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
            new FileHandler("logs/" + callTime.DayOfYear.ToString() + "Call_Log.txt").AppendToTxt(new List<string> { "Call Time: " + timer.ElapsedMilliseconds.ToString() + "ms  Call Ended: " + DateTime.UtcNow });
        }
    }
}
