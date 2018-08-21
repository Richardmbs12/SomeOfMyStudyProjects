using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPresentationLayer;

namespace WindowsFormsApplication1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCustomerDepartment_Click(object sender, EventArgs e)
        {
            new CustomerManagementDepartment().Show();
            this.Hide();
        }

        private void EmployeeManagementDepartment_Click(object sender, EventArgs e)
        {
            new EmployeeManagement().Show();
            this.Hide();
        }

        private void btnProductDepartment_Click(object sender, EventArgs e)
        {
            new ProductManagementDepartment().Show();
            this.Hide();
        }

        private void btnSalesManagementDepartment_Click(object sender, EventArgs e)
        {
            new SalesManagementDepartment().Show();
            this.Hide();
        }

        private void btnTechnicalSupportDepartment_Click(object sender, EventArgs e)
        {
            new TechnicalSupportDepartment().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
