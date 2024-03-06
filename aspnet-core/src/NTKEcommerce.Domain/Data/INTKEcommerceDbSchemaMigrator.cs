using System.Threading.Tasks;

namespace NTKEcommerce.Data;

public interface INTKEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
