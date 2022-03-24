using Microsoft.EntityFrameworkCore; // for inherit, DbContext, DbContextOptions,Dbset 
using WestWindSystem.Entities; // for category and other entities

namespace WestWindSystem.DAL
{
    //step1: inherit from DbContext
    //DAL is the only class that stays internal
    internal class WestWindContext: DbContext 
    {
        //step2: create a greedt constructor with parameter foe DbContextOptions
        // and pass the DbContextOptions to the constructor of DbContext
        public WestWindContext(DbContextOptions<WestWindContext> options) : base(options)
        {

        }

        //Step3: Create a Dbset property for each entity
        public DbSet<Category> Categories { get; set; } //DbSet is a collection
        public DbSet<Product> Products { get; set; }
    }

}
