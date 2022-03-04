using System.ComponentModel.DataAnnotations; //for Key, Required, StringLength
using System.ComponentModel.DataAnnotations.Schema;//for Table


namespace WestwindSystem.Entities
{
    [Table("Regions")] //Data table
    public class Region
    {
        [Key] // Primary key
        public int RegionId { get; set; }   
        [Required(ErrorMessage ="Region Description is required")]
        [StringLength(50,ErrorMessage ="Region Description is limited 50 characters")]
        public string RegionDescription { get; set; }
    }
}
