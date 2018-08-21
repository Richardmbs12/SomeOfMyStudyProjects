//using BusinessLayer.io.productManagement.productType;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;


//namespace BusinessLayer.io.productManagement.stock
//{
//    [Table("Stock")]
//    public class Stock
//    {
//        public Stock(List<ProductType> productsInStock)
//        {
//            this.ProductsInStock = productsInStock;
//        }
//        public Stock()
//        {

//        }
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        [Key]
//        public int WarehouseID { get; set; }
//        //EF
//        public virtual List<ProductType> ProductsInStock { get; set; }
//    }
//}
