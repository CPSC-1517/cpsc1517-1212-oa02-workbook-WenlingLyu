using System.ComponentModel.DataAnnotations; // for [Key],[Required],[StringLength]
using System.ComponentModel.DataAnnotations.Schema; // for [Table] 


namespace WestwindSystem.Entities
{
    [Table("Categories")]

    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Category name is required.")]
        [StringLength(15,ErrorMessage ="Category name must contain 15 or less characters.")]
        [Column("CategoryName")] // use this to match Name with dataBase name "categoryName"
        //if dont use this, it could not find what name is cuz it not exist in database
        public string Name { get; set; } = null!;
        // = null! means if this property is null then it should assign a value,
        // in this case , it means it assign a null to this property
        [Column(TypeName ="next")]
        public string? Description { get; set; } // ?  means this property is nullable

    }
}
