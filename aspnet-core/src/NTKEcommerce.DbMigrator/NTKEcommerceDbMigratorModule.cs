using NTKEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace NTKEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NTKEcommerceEntityFrameworkCoreModule),
    typeof(NTKEcommerceApplicationContractsModule)
    )]
public class NTKEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
