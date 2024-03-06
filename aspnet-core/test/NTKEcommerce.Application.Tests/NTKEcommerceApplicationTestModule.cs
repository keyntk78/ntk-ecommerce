using Volo.Abp.Modularity;

namespace NTKEcommerce;

[DependsOn(
    typeof(NTKEcommerceApplicationModule),
    typeof(NTKEcommerceDomainTestModule)
    )]
public class NTKEcommerceApplicationTestModule : AbpModule
{

}
