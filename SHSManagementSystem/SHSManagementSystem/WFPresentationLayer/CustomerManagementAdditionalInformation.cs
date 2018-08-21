using BusinessLayer.io.customerManagement.customer;
using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.customerManagement.enquiries.order;
using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiry;
using BusinessLayer.io.orderManagement.enquiries.order;
using BusinessLayer.io.productManagement.product;
using BusinessLayer.io.productManagement.productType;
using BusinessLayer.io.search.criteria;
using BusinessLayer.io.technicalSupport.technicalTask;
using BusinessLogicLayer.io.customerManagement.customer;
using BusinessLogicLayer.io.customerManagement.enquiries.order;
using BusinessLogicLayer.io.fileHandler;
using BusinessLogicLayer.io.productTypeManagement.productType;
using DataAccessLayer.io;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WFPresentationLayer
{
    public partial class CustomerManagementAdditionalInformation : Form
    {
        private Customer customer;

        private static SHSDatabaseContext sHSDatabaseContext = new SHSDatabaseContext();
        private IOrderRecordKeeper orderRecordKeeper = new OrderRecordKeeper(new UnitOfWork(sHSDatabaseContext), new FileHandler());
        private ICustomerRecordKeeper customerRecordKeeper = new CustomerRecordKeeper(new UnitOfWork(sHSDatabaseContext), new FileHandler());
        private IProductTypeRecordKeeper productTypeRecordKeeper = new ProductTypeRecordKeeper(new UnitOfWork(sHSDatabaseContext), new FileHandler());
        List<ProductType> productTypes;
        public CustomerManagementAdditionalInformation(string customerID)
        {
            InitializeComponent();
            customer = customerRecordKeeper.RetrieveCustomer(new RetrieveCustomerRequest().setCustomerId(customerID)).getCustomer();
            BindData();
        }

        private void BindData()
        {
            productTypes = productTypeRecordKeeper.FindProductType(new FindProductTypeRequest().setSearchCriteria(new AllSearch())).getProductTypes();

            if (customer != null)
            {
                if (dgvOrderedProducts.DataSource == null)
                {
                    dgvOrderedProducts.AutoGenerateColumns = false;
                    dgvOrderedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dgvOrderedProducts.ColumnCount = 2;

                    dgvOrderedProducts.Columns[0].HeaderText = "Serial Number";
                    dgvOrderedProducts.Columns[0].Name = "SerialNumber";
                    dgvOrderedProducts.Columns[0].DataPropertyName = "serialNumber";

                    dgvOrderedProducts.Columns[1].HeaderText = "Product ID";
                    dgvOrderedProducts.Columns[1].Name = "ProductID";
                    dgvOrderedProducts.Columns[1].DataPropertyName = "productID";
                }
                if (dgvCustomerProducts.DataSource == null)
                {

                    dgvCustomerProducts.AutoGenerateColumns = false;
                    dgvCustomerProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dgvCustomerProducts.ColumnCount = 2;

                    dgvCustomerProducts.Columns[0].HeaderText = "Serial Number";
                    dgvCustomerProducts.Columns[0].Name = "SerialNumber";
                    dgvCustomerProducts.Columns[0].DataPropertyName = "serialNumber";

                    dgvCustomerProducts.Columns[1].HeaderText = "Product ID";
                    dgvCustomerProducts.Columns[1].Name = "ProductID";
                    dgvCustomerProducts.Columns[1].DataPropertyName = "productID";

                    lblSerialNumber.DataBindings.Add("Text", customer.ProductConfiguration.InstalledProducts, "SerialNumber");
                    rtxtConfigurationDesc.DataBindings.Add("Text", customer.ProductConfiguration, "ConfigurationNote");

                    dgvCustomerProducts.DataSource = customer.ProductConfiguration.InstalledProducts;
                }
                if (dgvCustomerEnquiries.DataSource == null)
                {
                    dgvCustomerEnquiries.AutoGenerateColumns = false;
                    dgvCustomerEnquiries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dgvCustomerEnquiries.ColumnCount = 3;

                    dgvCustomerEnquiries.Columns[0].HeaderText = "Tracking Number";
                    dgvCustomerEnquiries.Columns[0].Name = "TrackingNumber";
                    dgvCustomerEnquiries.Columns[0].DataPropertyName = "trackingNumber";

                    dgvCustomerEnquiries.Columns[1].HeaderText = "Enquiry Date Time";
                    dgvCustomerEnquiries.Columns[1].Name = "EnquiryDateTime";
                    dgvCustomerEnquiries.Columns[1].DataPropertyName = "enquiryDateTime";

                    dgvCustomerEnquiries.Columns[2].HeaderText = "Enquiry Note";
                    dgvCustomerEnquiries.Columns[2].Name = "EnquiryNote";
                    dgvCustomerEnquiries.Columns[2].DataPropertyName = "enquiryNote";


                    lblCustomerID.Text = customer.ID;
                    lblCustomerIDConfig.Text = customer.ID;

                    lblTrackingNumber.DataBindings.Add("Text", customer.CustomerEnquiries, "TrackingNumber");
                    lblDateIssued.DataBindings.Add("Text", customer.CustomerEnquiries, "EnquiryDateTime");
                    rtxtEnquiryNote.DataBindings.Add("Text", customer.CustomerEnquiries, "EnquiryNote");
                }

                if (rbtnDefault.Checked)
                {
                    dgvCustomerEnquiries.DataSource = null;
                    dgvCustomerEnquiries.DataSource = customer.CustomerEnquiries;
                    dgvCustomerEnquiries.Update();
                    dgvCustomerEnquiries.Refresh();
                }
                else if (rbtnOrder.Checked)
                {
                    dgvCustomerEnquiries.DataSource = null;
                    List<Order> orders = new List<Order>();
                    foreach (CustomerEnquiry item in customer.CustomerEnquiries)
                    {
                        if (item is Order)
                        {
                            orders.Add(item as Order);
                        }
                    }

                    dgvCustomerEnquiries.DataSource = orders;
                    dgvCustomerEnquiries.Update();
                    dgvCustomerEnquiries.Refresh();
                }
                else if (rbtnTechnical.Checked)
                {
                    dgvCustomerEnquiries.DataSource = null;
                    List<TechnicalSupportEnquiry> technicalSupportEnquiries = new List<TechnicalSupportEnquiry>();
                    foreach (CustomerEnquiry item in customer.CustomerEnquiries)
                    {
                        if (item is TechnicalSupportEnquiry)
                        {
                            technicalSupportEnquiries.Add(item as TechnicalSupportEnquiry);
                        }
                    }
                    dgvCustomerEnquiries.DataSource = technicalSupportEnquiries;
                    dgvCustomerEnquiries.Update();
                    dgvCustomerEnquiries.Refresh();
                }
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void dgvCustomerEnquiries_SelectionChanged(object sender, EventArgs e)
        {
            lblOrderTotalPrice.Text = "";
            dgvOrderedProducts.DataSource = null;
            dgvOrderedProducts.Update();
            dgvOrderedProducts.Refresh();

            CustomerEnquiry customerEnquiry = dgvCustomerEnquiries.CurrentRow.DataBoundItem as CustomerEnquiry;

            if (customerEnquiry is Order)
            {
                Order order = orderRecordKeeper.RetrieveOrder(new RetrieveOrderRequest().setOrderTrackingNumber(customerEnquiry.TrackingNumber)).getOrder();

                lblEnquiryType.Text = "Order";

                lblOrderTotalPrice.Text = order.BillingInvoice.TotalPrice.ToString();

                dgvOrderedProducts.DataSource = order.ProductsOrdered;
                dgvOrderedProducts.Update();
                dgvOrderedProducts.Refresh();
            }
            else if ((dgvCustomerEnquiries.CurrentRow.DataBoundItem as CustomerEnquiry) is TechnicalSupportEnquiry)
            {
                lblEnquiryType.Text = "Technical Support Enquiry";
            }
            else
            {
                lblEnquiryType.Text = "Customer Enquiry";
            }

            if ((dgvCustomerEnquiries.CurrentRow.DataBoundItem as CustomerEnquiry).TechnicalTask != null)
            {
                TechnicalTask technicalTask = (dgvCustomerEnquiries.CurrentRow.DataBoundItem as CustomerEnquiry).TechnicalTask;
                rtxtTaskDesc.Text = technicalTask.TaskDescription;
                if (technicalTask.Completed)
                {
                    this.rbtnYes.Checked = true;
                }
                else
                {
                    this.rbtnNo.Checked = true;

                }
            }
        }

        private void rbtnDefault_CheckedChanged(object sender, EventArgs e)
        {
            BindData();
        }

        private void rbtnOrder_CheckedChanged(object sender, EventArgs e)
        {
            BindData();
        }

        private void rbtnTechnical_CheckedChanged(object sender, EventArgs e)
        {
            BindData();
        }

        private void dgvCustomerProducts_SelectionChanged(object sender, EventArgs e)
        {
            ProductType productType = new ProductType();
            Product product = (dgvCustomerProducts.CurrentRow.DataBoundItem as Product);
            foreach (ProductType productTypeTemp in productTypes)
            {
                foreach (Product productTemp in productTypeTemp.Products)
                {
                    if (productTemp.SerialNumber == product.SerialNumber)
                    {
                        productType = productTypeTemp;
                    }
                }
            }

            lblProductName.Text = productType.ProductName;
            lblWarranty.Text = productType.WarrantyDuration.ToString();
            lblProductPrice.Text = productType.Price.ToString();
            rTxtProductDescript.Text = productType.ProductDescription;
        }
    }
}
