using Microsoft.EntityFrameworkCore; // for DbContext, DbContextOptions
using WestwindSystem.Entities; //for Category

namespace WestwindSystem.DAL
{
    internal class WestwindContext:DbContext  //must inherate from Dbcontext
    {
        public WestwindContext()
        {

        }
        public WestwindContext(DbContextOptions<WestwindContext> options) : base(options) //options means take "options"
            //from <WestWindContext>options and pass it to the base(options)
        {
            
        }
        //Dbset manage a set of entity objects 
        public DbSet<Category> Categories { get; set; } = null!; //Dbset means the data base we want to access
        public DbSet<Region> Regions { get; set; } = null!;
        public DbSet<BuildVersion>BuildVersion { get; set; } = null!;
    }
}
