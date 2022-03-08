using Microsoft.EntityFrameworkCore;//for dbContextOptionBuilder
using Microsoft.Extensions.DependencyInjection; //for IserviceCollection
namespace WestwindSystem
{
    public static class BackendExtensions
    {
        public static void WestwindBackendDependencies(
            this IServiceCollection service,
            Action<DbContextOptionsBuilder>option)
        {

        }
    }
}
