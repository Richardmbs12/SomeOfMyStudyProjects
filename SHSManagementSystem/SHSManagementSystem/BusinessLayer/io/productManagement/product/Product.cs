using BusinessLayer.io.customerManagement.customer.productConfiguration;
using BusinessLayer.io.customerManagement.enquiries.order;
using BusinessLayer.io.productManagement.productType;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.io.productManagement.product
{
    public class Product
    {
        public Product(int serialNumber, DateTime stockInDate, DateTime stockOutDate, ProductType productType)
        {
            this.SerialNumber = serialNumber;
            this.StockInDate = stockInDate;
            this.StockOutDate = stockOutDate;
            this.ProductType = productType;
        }

        public Product(DateTime stockInDate, DateTime stockOutDate, ProductType productType)
        {
            this.StockInDate = stockInDate;
            this.StockOutDate = stockOutDate;
            this.ProductType = productType;
        }
        public Product()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SerialNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/DD/YYYY}")]
        public DateTime StockOutDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/DD/YYYY}")]
        public DateTime StockInDate { get; set; }
        //EF
        public int ProductID { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ProductInstallationHistory ProductInstallationHistory { get; set; }

        [ForeignKey("Order")]
        public int TrackingNumber { get; set; }
        public virtual Order Order { get; set; }

        [ForeignKey("CustomerProductConfiguration")]
        public string ID { get; set; }
        public virtual CustomerProductConfiguration CustomerProductConfiguration { get; set; }
    }
}
