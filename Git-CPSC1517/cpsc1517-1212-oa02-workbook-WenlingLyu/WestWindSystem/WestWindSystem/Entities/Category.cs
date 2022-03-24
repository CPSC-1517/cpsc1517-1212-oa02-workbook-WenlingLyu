using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//for key
using System.ComponentModel.DataAnnotations.Schema; //for table
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindSystem.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryID { get; set; } = 0;

        public string CategoryName { get; set; } = null!;

        public  string? Description { get; set; } // ? behind the string means it is nullable

        //public byte[] Picture { get; set; } // byte[] is for picture

        //public string PictureMimeType { get; set; }
    }
}
