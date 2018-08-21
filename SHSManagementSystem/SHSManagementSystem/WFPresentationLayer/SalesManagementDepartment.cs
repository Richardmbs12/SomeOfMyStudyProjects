using BusinessLayer.io.customerManagement.customer;
using BusinessLayer.io.customerManagement.customer.billing;
using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.customerManagement.enquiries.order;
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
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SalesManagementDepartment : Form
    {
        private static SHSDatabaseContext sHSDatabaseContext = new SHSDatabaseContext();
        private IProductTypeRecordKeeper productTypeRecordKeeper = new ProductTypeRecordKeeper(new UnitOfWork(sHSDatabaseContext), new FileHandler());
        private ICustomerRecordKeeper customerRecordKeeper = new CustomerRecordKeeper(new UnitOfWork(sHSDatabaseContext), new FileHandler());
        private IOrderRecordKeeper orderRecordKeeper = new OrderRecordKeeper(new UnitOfWork(sHSDatabaseContext), new FileHandler());

        private List<Customer> customers = new List<Customer>();
        private List<ProductType> productTypes = new List<ProductType>();
        List<Product> products = new List<Product>();
        List<ProductType> productTypesSelected = new List<ProductType>();

        Customer customer;
        BillingInvoice billingInvoice = new BillingInvoice {TotalPrice = 0};

        private DateTime callTime;
        Stopwatch timer;
        public SalesManagementDepartment()
        {
            InitializeComponent();
        }


        private void SalesManagementDepartment_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnDash_Click(object sender, System.EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
            this.Dispose();
        }

        private void BindData()
        {
            if (lbxProducts.DataSource == null && productTypes.Count == 0)
            {
                List<Expression<Func<ProductType, object>>> productTypeIncluders = new List<Expression<Func<ProductType, object>>>();
                productTypeIncluders.Add(x => x.Products);
                productTypes = productTypeRecordKeeper.FindProductType(new FindProductTypeRequest().setSearchCriteria(new AllSearch())).getProductTypes();
                    
                lbxProducts.DataSource = productTypes;

                txtProdName.DataBindings.Add("Text", productTypes, "ProductName");
                txtProductType.DataBindings.Add("Text", productTypes, "ProductDescription");
                lblProductPrice.DataBindings.Add("Text", productTypes, "Price");
                lblYearsOfWarranty.DataBindings.Add("Text", productTypes, "WarrantyDuration");
            }
            else if (productTypes.Count > 0)
            {
                lbxProducts.DataSource = null;
                lbxProducts.DataSource = productTypes;
                lbxProducts.Update();
                lbxProducts.Refresh();
            }

            if (dgvEnquiries.DataSource == null && customers.Count == 0)
            {
                List<Expression<Func<Customer, object>>> customerIncluders = new List<Expression<Func<Customer, object>>>();
                customerIncluders.Add(x => x.Address);
                customerIncluders.Add(x => x.ContactInformation);
                customerIncluders.Add(x => x.CustomerEnquiries);

                customers = customerRecordKeeper.FindCustomer(new FindCustomerRequest().setSearchCriteria(new AllSearch())).getCustomers();
                    
                txtCName.DataBindings.Add("Text", customers, "Name");
                txtEmail.DataBindings.Add("Text", customers, "ContactInformation.Email");
                txtPhone.DataBindings.Add("Text", customers, "ContactInformation.MobileNumber");
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

        private void btnFindCustomer_Click(object sender, System.EventArgs e)
        {
            List<CustomerEnquiry> customerEnquiries = customers.Single(c => c.ID == cmbCustomerIDSearch.Text).CustomerEnquiries;
            dgvEnquiries.DataSource = customerEnquiries;
            rtxtEnquiryNote.DataBindings.Clear();
            rtxtEnquiryNote.DataBindings.Add("Text", customerEnquiries, "EnquiryNote");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            tabControlSales.SelectedTab = tabPageCheckOut;
            lbxChekoutProducts.DataSource = productTypesSelected;

            customer = customerRecordKeeper.RetrieveCustomer(new RetrieveCustomerRequest().setCustomerId(cmbCustomerIDSearch.Text)).getCustomer();
            lblDiscount.Text = customer.Contract.ContractType.IncludedCreditPercentage.ToString();

            billingInvoice.CreditAmount = customer.Contract.ContractType.IncludedCreditPercentage * billingInvoice.TotalPrice;
            billingInvoice.AmountDue = billingInvoice.TotalPrice - billingInvoice.CreditAmount;
            lblAmountDue.Text = billingInvoice.AmountDue.ToString();
            lblAmountReduced.Text = billingInvoice.CreditAmount.ToString();
            lblCheckoutTotal.Text = billingInvoice.TotalPrice.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (numProdQty.Value > 0)
            {
                ProductType productType = lbxProducts.SelectedItem as ProductType;
                for (int i = 0; i < numProdQty.Value; i++)
                {
                    products.Add(new Product(DateTime.UtcNow, DateTime.UtcNow, productType));
                    billingInvoice.TotalPrice += productType.Price;
                    lblOrderSubTotal.Text = billingInvoice.TotalPrice.ToString();
                }

                bool addProd = true;
                if (productTypesSelected.Count>0)
                {
                    foreach (ProductType item in productTypesSelected)
                    {
                        if (item == productType)
                        {
                            addProd = false;
                        }
                    }
                    if (addProd)
                    {
                        productTypesSelected.Add(productType);
                    }
                }
                else
                {
                    productTypesSelected.Add(productType);
                }

            }

            lbxCart.DataSource = null;
            lbxCart.DataSource = productTypesSelected;
            lbxCart.Update();
            lbxCart.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            List<Product> deleteProducts = new List<Product>();
            foreach (Product item in products)
            {
                if (item.ProductType == lbxCart.SelectedItem as ProductType)
                {
                    deleteProducts.Add(item);
                    productTypesSelected.Remove(item.ProductType);
                }
            }

            foreach (Product item in deleteProducts)
            {
                products.Remove(item);
            }

            lbxCart.DataSource = null;
            lbxCart.DataSource = productTypesSelected;
            lbxCart.Update();
            lbxCart.Refresh();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            foreach (Product item in products)
            {
                if (item.ProductType == lbxCart.SelectedItem as ProductType)
                {
                    item.ProductType.QuantityInStock -= 1;
                    totalPrice += item.ProductType.Price;
                }
            }

            CustomerEnquiry customerEnquiry = dgvEnquiries.CurrentRow.DataBoundItem as CustomerEnquiry;
            billingInvoice.Date = DateTime.UtcNow;

            if (customer.BillingInformation.BillingHistory == null)
            {
                customer.BillingInformation.BillingHistory = new List<BillingInvoice>();
            }

            customer.ProductConfiguration.ConfigurationNote = "Few Products In Configuration";
            customer.ProductConfiguration.InstalledProducts = products;

            customer.BillingInformation.BillingHistory.Add(billingInvoice);

            Order customerOrder = new Order(customerEnquiry.TrackingNumber, products, customerEnquiry.EnquiryDateTime, customerEnquiry.EnquiryNote, billingInvoice);

            customerOrder.TechnicalTask = new TechnicalTask(false, rTechnicalTaskDesc.Text, DateTime.UtcNow);

            var index = customer.CustomerEnquiries.FindIndex(c => c.TrackingNumber == customerEnquiry.TrackingNumber);

            customer.CustomerEnquiries[index] = customerOrder;

            orderRecordKeeper.CreateOrder(new CreateOrderRequest().setOrder(customerOrder));

            customerRecordKeeper.UpdateCustomer(new UpdateCustomerRequest().setCustomer(customer));

            new FileHandler("logs/" + callTime.DayOfYear.ToString() + "Call_Log.txt").AppendToTxt(new List<string> { "Call Time: " + timer.ElapsedMilliseconds.ToString() + "ms  Call Ended: " + DateTime.UtcNow });

            new SalesManagementDepartment().Show();
            this.Hide();
            this.Dispose();
        }

        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Product item in products)
            {
                if (item.ProductType == lbxCart.SelectedItem as ProductType)
                {
                    i++;
                }
            }
            numProdQty.Value = i;
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUnitPrice.Text = (lbxProducts.SelectedItem as ProductType).Price.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControlSales.SelectedTab = tabPageMakeSale;
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
