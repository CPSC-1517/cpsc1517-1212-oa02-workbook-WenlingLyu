#nullable disable   //won't give warning of nullable types
using System.ComponentModel.DataAnnotations;//for Key
using System.ComponentModel.DataAnnotations.Schema; //for Table


namespace WestwindSystem.Entities
{
    [Table("Territories")]
    public class Territory
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        //this means key can not be Generate by database 
        [Required(ErrorMessage = "TerritoryID is required")]
        [StringLength(maximumLength:20, ErrorMessage = "TerritoryID is limited to 20 characters")]
        public int TerritoryID { get; set;}

        public string TerritoryDescription { get; set;}

        public int RegionID { get; set;}

    }
}
