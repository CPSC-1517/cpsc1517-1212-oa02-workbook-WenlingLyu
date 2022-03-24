using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//for Key
using System.ComponentModel.DataAnnotations.Schema;//for Table
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindSystem.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; } = null!;

        public int? CategoryID { get; set; }

        public string QuantityPerUnit { get; set; } 

        public decimal UnitPrice { get; set; } //money dataType in C# we use decimal

        public int UnitsOnOrder { get; set; } 

        public bool Discontinued { get; set; } // we use bool to deal with bit dataType in SQL


    }
}
