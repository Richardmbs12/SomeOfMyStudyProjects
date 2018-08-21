using BusinessLayer.io.productManagement.productType;
using BusinessLayer.io.search.criteria;
using BusinessLogicLayer.io.fileHandler;
using BusinessLogicLayer.io.productTypeManagement.productType;
using DataAccessLayer.io;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProductManagementDepartment : Form
    {
        private IProductTypeRecordKeeper productTypeRecordKeeper = new ProductTypeRecordKeeper(new UnitOfWork(new SHSDatabaseContext()), new FileHandler());

        private List<ProductType> productTypes = new List<ProductType>();
        public ProductManagementDepartment()
        {
            InitializeComponent();
        }

        private void ProductManagementDepartment_Load(object sender, System.EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            List<Expression<Func<ProductType, object>>> productTypeIncluders = new List<Expression<Func<ProductType, object>>>();
            productTypeIncluders.Add(x => x.Products);

            productTypes = productTypeRecordKeeper.FindProductType(new FindProductTypeRequest().setSearchCriteria(new AllSearch())).getProductTypes();

            if (dgvMngProd.DataSource == null && productTypes.Count>0)
            {
                dgvMngProd.AutoGenerateColumns = false;
                dgvMngProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvMngProd.ColumnCount = 5;

                dgvMngProd.Columns[0].HeaderText = "ID";
                dgvMngProd.Columns[0].Name = "ProductID";
                dgvMngProd.Columns[0].DataPropertyName = "productID";

                dgvMngProd.Columns[1].HeaderText = "Name";
                dgvMngProd.Columns[1].Name = "ProductName";
                dgvMngProd.Columns[1].DataPropertyName = "productName";

                dgvMngProd.Columns[2].HeaderText = "Price";
                dgvMngProd.Columns[2].Name = "Price";
                dgvMngProd.Columns[2].DataPropertyName = "price";

                dgvMngProd.Columns[3].HeaderText = "Years Warranty";
                dgvMngProd.Columns[3].Name = "WarrantyDuration";
                dgvMngProd.Columns[3].DataPropertyName = "warrantyDuration";

                dgvMngProd.Columns[4].HeaderText = "Quantity Available";
                dgvMngProd.Columns[4].Name = "QuantityInStock";
                dgvMngProd.Columns[4].DataPropertyName = "quantityInStock";

                dgvMngProd.DataSource = productTypes;

                txtManageProductName.DataBindings.Add("Text", productTypes, "ProductName");
                txtManageProductPrice.DataBindings.Add("Text", productTypes, "Price");
                rTxtManageProductDescript.DataBindings.Add("Text", productTypes, "ProductDescription");
                nUpDownManageProductWarranty.DataBindings.Add("Text", productTypes, "WarrantyDuration");
                nUpDownManageQuantity.DataBindings.Add("Text", productTypes, "QuantityInStock");
            }
            else if (productTypes.Count > 0)
            {
                dgvMngProd.DataSource = null;
                dgvMngProd.DataSource = productTypes;
                dgvMngProd.Update();
                dgvMngProd.Refresh();
            }

        }

        private void btnUpdateProduct_Click(object sender, System.EventArgs e)
        {
            ProductType productType = dgvMngProd.CurrentRow.DataBoundItem as ProductType;
            productType = new ProductType(Convert.ToDouble(txtManageProductPrice.Text),rTxtManageProductDescript.Text,Convert.ToInt32(nUpDownManageQuantity.Value),txtManageProductName.Text,Convert.ToInt32(nUpDownManageProductWarranty.Value));
            BindData();
        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            productTypeRecordKeeper.CreateProductType(new CreateProductTypeRequest().setProductType(new ProductType(Convert.ToDouble(txtProductTypePrice.Text), rTxtProductDescription.Text, Convert.ToInt32(nUpDownQuantityStocked.Value), txtProductName.Text, Convert.ToInt32(nUpDownWarranty.Value))));

            new ProductManagementDepartment().Show();
            this.Hide();
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            new ProductManagementDepartment().Show();
            this.Hide();
            this.Dispose();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            productTypeRecordKeeper.RemoveProductType(new RemoveProductTypeRequest().setProductType(dgvMngProd.CurrentRow.DataBoundItem as ProductType));
            BindData();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
            this.Dispose();
        }
    }
}
