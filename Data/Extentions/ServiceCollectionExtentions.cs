using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Data.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static void AddPersistenceContexts(this IServiceCollection services)
        {
            services.AddDbContext<ComicsOrganizerDbContext>((serviceProvider, options) =>
            {
                options.UseNpgsql("host=localhost;database=comicsdb;password=p;username=postgres;enlist=true;");
            });

        }
    }
}
