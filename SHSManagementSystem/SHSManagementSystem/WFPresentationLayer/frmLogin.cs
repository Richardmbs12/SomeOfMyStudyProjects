using BusinessLayer.io.employeeManagement;
using BusinessLayer.io.search.criteria;
using BusinessLayer.io.users.loginInformation;
using BusinessLogicLayer.io.employeeManagement;
using BusinessLogicLayer.io.fileHandler;
using DataAccessLayer.io;
using DataAccessLayer.Persistance.UnitOfWork;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        private IEmployeeRecordKeeper employeeRecordKeeper = new EmployeeRecordKeeper(new UnitOfWork(new SHSDatabaseContext()), new FileHandler());
        private List<Employee> employees = new List<Employee>();

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            employees = employeeRecordKeeper.FindEmployee(new FindEmployeeRequest().setSearchCriteria(new AllSearch())).getEmployees();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            bool loginSuccess = false;
            foreach (Employee emp in employees)
            {
                if (emp.LoginDetails.Password == txtPassword.Text && emp.LoginDetails.UserName == txtUsername.Text)
                {
                    loginSuccess = true;
                    new Dashboard().Show();
                    this.Hide();
                }
            }
            if (!loginSuccess)
            {
                MessageBox.Show("Incorrect Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
