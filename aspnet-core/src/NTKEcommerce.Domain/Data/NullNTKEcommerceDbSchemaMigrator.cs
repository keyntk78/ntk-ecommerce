using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NTKEcommerce.Data;

/* This is used if database provider does't define
 * INTKEcommerceDbSchemaMigrator implementation.
 */
public class NullNTKEcommerceDbSchemaMigrator : INTKEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
