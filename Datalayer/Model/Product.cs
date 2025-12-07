using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Model
{
    public class Product
    {
    

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal SellingPrice { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
    }

}
