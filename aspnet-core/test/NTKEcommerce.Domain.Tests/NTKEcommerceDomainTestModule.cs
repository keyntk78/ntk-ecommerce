using NTKEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NTKEcommerce;

[DependsOn(
    typeof(NTKEcommerceEntityFrameworkCoreTestModule)
    )]
public class NTKEcommerceDomainTestModule : AbpModule
{

}
