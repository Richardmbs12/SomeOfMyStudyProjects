using BusinessLayer.io.customerManagementEmployeeManagement.customerManagementCustomerManagementEmployee;
using BusinessLayer.io.employeeManagement;
using BusinessLayer.io.employeeManagement.customerManagementEmployee;
using BusinessLayer.io.employeeManagement.productManagementEmployee;
using BusinessLayer.io.employeeManagement.technicalSupportManagementEmployee;
using BusinessLayer.io.search.criteria;
using BusinessLayer.io.technicalSupport.schedule;
using BusinessLayer.io.users.address;
using BusinessLayer.io.users.contactInformation;
using BusinessLayer.io.users.loginInformation;
using BusinessLogicLayer.io.customerManagementEmployeeManagement.customerManagementCustomerManagementEmployee;
using BusinessLogicLayer.io.employeeManagement;
using BusinessLogicLayer.io.fileHandler;
using BusinessLogicLayer.io.productManagementEmployeeManagement.productManagementProductManagementEmployee;
using BusinessLogicLayer.io.technicalSupportManagementEmployeeManagement.technicalSupportManagementTechnicalSupportManagementEmployee;
using DataAccessLayer.io;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EmployeeManagement : Form
    {
        private IEmployeeRecordKeeper employeeRecordKeeper = new EmployeeRecordKeeper(new UnitOfWork(new SHSDatabaseContext()), new FileHandler());
        private ITechnicalSupportManagementEmployeeRecordKeeper technicalSupportManagementEmployeeRecordKeeper = 
            new TechnicalSupportManagementEmployeeRecordKeeper(new UnitOfWork(new SHSDatabaseContext()), new FileHandler());
        private IProductManagementEmployeeRecordKeeper productManagementEmployeeRecordKeeper = new ProductManagementEmployeeRecordKeeper(new UnitOfWork(new SHSDatabaseContext()), new FileHandler());
        private ICustomerManagementEmployeeRecordKeeper customerManagementEmployeeRecordKeeper = new CustomerManagementEmployeeRecordKeeper(new UnitOfWork(new SHSDatabaseContext()), new FileHandler());

        private List<Employee> employees = new List<Employee>();
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void EmployeeManagement_Load(object sender, System.EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            employees = employeeRecordKeeper.FindEmployee(new FindEmployeeRequest().setSearchCriteria(new AllSearch())).getEmployees();
            if (dgvEMng.DataSource == null/* && employees.Count > 0*/)
            {
                dgvEMng.AutoGenerateColumns = false;
                dgvEMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvEMng.ColumnCount = 5;

                dgvEMng.Columns[0].HeaderText = "ID";
                dgvEMng.Columns[0].Name = "ID";
                dgvEMng.Columns[0].DataPropertyName = "id";

                dgvEMng.Columns[1].HeaderText = "Title";
                dgvEMng.Columns[1].Name = "Title";
                dgvEMng.Columns[1].DataPropertyName = "title";

                dgvEMng.Columns[2].HeaderText = "Name";
                dgvEMng.Columns[2].Name = "Name";
                dgvEMng.Columns[2].DataPropertyName = "name";

                dgvEMng.Columns[3].HeaderText = "Surname";
                dgvEMng.Columns[3].Name = "Surname";
                dgvEMng.Columns[3].DataPropertyName = "surname";

                dgvEMng.Columns[4].HeaderText = "Gender";
                dgvEMng.Columns[4].Name = "Gender";
                dgvEMng.Columns[4].DataPropertyName = "gender";

                dgvEMng.DataSource = employees;

                txtUpName.DataBindings.Add("Text", employees, "Name");
                txtUpSurname.DataBindings.Add("Text", employees, "Surname");
                txtUpTitle.DataBindings.Add("Text", employees, "Title");
                txtUpGender.DataBindings.Add("Text", employees, "Gender");
                txtUpFullName.DataBindings.Add("Text", employees, "FullName");

                txtUpEmail.DataBindings.Add("Text", employees, "ContactInformation.Email");
                txtUpWorkTel.DataBindings.Add("Text", employees, "ContactInformation.WorkNumber");
                txtUpMobile.DataBindings.Add("Text", employees, "ContactInformation.MobileNumber");

                txtUpCity.DataBindings.Add("Text", employees, "Address.City");
                txtUpCountry.DataBindings.Add("Text", employees, "Address.Country");
                txtUpAddressLine1.DataBindings.Add("Text", employees, "Address.AddressLine1");
                txtUpAddressLine2.DataBindings.Add("Text", employees, "Address.AddressLine2");
                txtUpPostalCode.DataBindings.Add("Text", employees, "Address.PostalCode");
                txtUpSuburb.DataBindings.Add("Text", employees, "Address.Suburb");
            }
            else
            {
                dgvEMng.DataSource = null;
                dgvEMng.DataSource = employees;
                dgvEMng.Update();
                dgvEMng.Refresh();
            }
        }

        private void btnSaveEmployee_Click(object sender, System.EventArgs e)
        {
            employeeRecordKeeper.UpdateEmployee(new UpdateEmployeeRequest().setEmployee(dgvEMng.CurrentRow.DataBoundItem as Employee));
            BindData();
        }

        private void btnRemoveEmployee_Click(object sender, System.EventArgs e)
        {
            employeeRecordKeeper.RemoveEmployee(new RemoveEmployeeRequest().setEmployee(dgvEMng.CurrentRow.DataBoundItem as Employee));
            BindData();
        }

        private void btnEmpSearch_Click(object sender, System.EventArgs e)
        {

        }

        private void btnResetEmployee_Click(object sender, System.EventArgs e)
        {
            new EmployeeManagement().Show();
            this.Hide();
        }

        private void btnDash_Click(object sender, System.EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void btnSubmitEmployee_Click(object sender, EventArgs e)
        {
            switch (cmbDepartment.SelectedItem.ToString())
            {
                case "Product Department":
                    productManagementEmployeeRecordKeeper.CreateProductManagementEmployee(new CreateProductManagementEmployeeRequest().setProductManagementEmployee(
                    new ProductManagementEmployee(txtID.Text, txtTitle.Text, txtFirstName.Text, txtFullName.Text, txtLastName.Text, txtGender.Text,
                    new ContactInformation(txtWorkTel.Text, txtMobile.Text, txtEmail.Text), Convert.ToDateTime(dtDOB.Text), 
                    new LoginInformation(txtUserName.Text, txtPassword.Text, AuthenticationLevel.ProductManagementDepartment),
                    new Address(txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtCountry.Text, txtPostalCode.Text, txtSuburb.Text))));
                    break;

                case "Customer Department":
                    customerManagementEmployeeRecordKeeper.CreateCustomerManagementEmployee(new CreateCustomerManagementEmployeeRequest().setCustomerManagementEmployee(
                    new CustomerManagementEmployee(txtID.Text, txtTitle.Text, txtFirstName.Text, txtFullName.Text, txtLastName.Text, txtGender.Text,
                    new ContactInformation(txtWorkTel.Text, txtMobile.Text, txtEmail.Text), Convert.ToDateTime(dtDOB.Text),
                    new LoginInformation(txtUserName.Text, txtPassword.Text, AuthenticationLevel.CustomerManagementDepartment),
                    new Address(txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtCountry.Text, txtPostalCode.Text, txtSuburb.Text))));
                    break;

                case "Technical Support Department":
                    technicalSupportManagementEmployeeRecordKeeper.CreateTechnicalSupportManagementEmployee(new CreateTechnicalSupportManagementEmployeeRequest().setTechnicalSupportManagementEmployee(
                    new TechnicalSupportManagementEmployee(txtID.Text, txtTitle.Text, txtFirstName.Text, txtFullName.Text, txtLastName.Text, txtGender.Text,
                    new ContactInformation(txtWorkTel.Text, txtMobile.Text, txtEmail.Text), Convert.ToDateTime(dtDOB.Text),
                    new LoginInformation(txtUserName.Text, txtPassword.Text, AuthenticationLevel.TechnicalSupportManagementDepartment),
                    new Address(txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtCountry.Text, txtPostalCode.Text, txtSuburb.Text),
                    new List<Schedule>())));
                    break;

                case "Administrator":
                    employeeRecordKeeper.CreateEmployee(new CreateEmployeeRequest().setEmployee(
                    new Employee(txtID.Text, txtTitle.Text, txtFirstName.Text, txtFullName.Text, txtLastName.Text, txtGender.Text,
                    new ContactInformation(txtWorkTel.Text, txtMobile.Text, txtEmail.Text), Convert.ToDateTime(dtDOB.Text),
                    new LoginInformation(txtUserName.Text, txtPassword.Text, AuthenticationLevel.Administrator),
                    new Address(txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtCountry.Text, txtPostalCode.Text, txtSuburb.Text))));
                    break;
                default:
                    break;
            }

            new EmployeeManagement().Show();
            this.Hide();
        }

        private void btnConfirmEmployee_Click(object sender, EventArgs e)
        {
            empControl.SelectedTab = tabConfirmEmployee;
        }

        private void dgvEMng_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEMng.CurrentRow.DataBoundItem as Employee is TechnicalSupportManagementEmployee)
            {
                txtEmployeeDepartment.Text = "Technical Support Department";
            } else if (dgvEMng.CurrentRow.DataBoundItem as Employee is CustomerManagementEmployee)
            {
                txtEmployeeDepartment.Text = "Customer Departmentt";
            }
            else if (dgvEMng.CurrentRow.DataBoundItem as Employee is ProductManagementEmployee)
            {
                txtEmployeeDepartment.Text = "Product Department";
            }
            else if ((dgvEMng.CurrentRow.DataBoundItem as Employee).LoginDetails.AuthenticationLevel == AuthenticationLevel.Administrator)
            {
                txtEmployeeDepartment.Text = "HR or Higher Management";
            }
        }
    }
}
