using Volo.Abp.Modularity;

namespace NTKEcommerce.Admin;

[DependsOn(
    typeof(NTKEcommerceAdminApplicationModule),
    typeof(NTKEcommerceDomainTestModule)
    )]
public class NTKEcommerceApplicationTestModule : AbpModule
{

}
