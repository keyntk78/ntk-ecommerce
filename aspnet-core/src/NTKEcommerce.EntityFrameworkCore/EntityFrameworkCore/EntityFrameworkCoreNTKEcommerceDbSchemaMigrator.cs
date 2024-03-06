using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NTKEcommerce.Data;
using Volo.Abp.DependencyInjection;

namespace NTKEcommerce.EntityFrameworkCore;

public class EntityFrameworkCoreNTKEcommerceDbSchemaMigrator
    : INTKEcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNTKEcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NTKEcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NTKEcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
