using Microsoft.EntityFrameworkCore;//for DbContextOptionsBuilder
using Microsoft.Extensions.DependencyInjection; // For  IServiceCollection
using WestWindSystem.DAL; // for westWindContext
using WestWindSystem.BLL;

namespace WestWindSystem
{
    public static class BackendExtensions //extension has to be a static class
    {
        //must has a static method
        public static void BackendDependencies(this IServiceCollection services,
            Action<DbContextOptionsBuilder> options)
        {
            services.AddDbContext<WestWindContext>(options);

            services.AddTransient<CategoryServices>((serviceProvider) =>
            {
                var dbContext = serviceProvider.GetService<WestWindContext>();
                return new CategoryServices(dbContext);
            });

            services.AddTransient<ProductServices>((serviceProvider) =>
            {
                var dbContext = serviceProvider.GetService<WestWindContext>();
                return new ProductServices(dbContext);
            });

        }

    }
}