using NTKEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NTKEcommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NTKEcommerceController : AbpControllerBase
{
    protected NTKEcommerceController()
    {
        LocalizationResource = typeof(NTKEcommerceResource);
    }
}
