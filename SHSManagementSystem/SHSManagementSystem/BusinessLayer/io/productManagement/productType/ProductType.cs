using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessLayer.io.productManagement.product;

namespace BusinessLayer.io.productManagement.productType
{
    public class ProductType
    {
        public ProductType(int productID, double price, string productDescription, byte[] productImage, int quantityInStock, string productName, int warranryDuration)
        {
            this.ProductID = productID;
            this.ProductDescription = productDescription;
            this.Price = price;
            this.ProductImage = productImage;
            this.ProductName = productName;
            this.QuantityInStock = quantityInStock;
            this.WarrantyDuration = WarrantyDuration;
        }

        public ProductType(double price, string productDescription, int quantityInStock, string productName, int warranryDuration)
        {
            this.ProductDescription = productDescription;
            this.Price = price;
            this.ProductName = productName;
            this.QuantityInStock = quantityInStock;
            this.WarrantyDuration = warranryDuration;
        }

        public ProductType(double price, string productDescription, byte[] productImage, int quantityInStock, string productName, int warranryDuration)
        {
            this.ProductDescription = productDescription;
            this.Price = price;
            this.ProductImage = productImage;
            this.ProductName = productName;
            this.QuantityInStock = quantityInStock;
            this.WarrantyDuration = WarrantyDuration;
        }
        public ProductType()
        {

        }
        public int WarrantyDuration { get; set; }
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
        public byte[] ProductImage { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProductID { get; set; }
        //EF
        public virtual List<Product> Products { get; set; }
        //public int WarehouseID { get; set; }
        //public virtual Stock Stock { get; set; }

        public override string ToString()
        {
            return this.ProductID + " " + ProductName;
        }
    }
}
