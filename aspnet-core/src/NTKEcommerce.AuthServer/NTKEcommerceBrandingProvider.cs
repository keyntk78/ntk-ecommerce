using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace NTKEcommerce;

[Dependency(ReplaceServices = true)]
public class NTKEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NTKEcommerce";
}
