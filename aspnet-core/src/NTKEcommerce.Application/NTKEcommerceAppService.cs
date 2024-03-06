using System;
using System.Collections.Generic;
using System.Text;
using NTKEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace NTKEcommerce;

/* Inherit your application services from this class.
 */
public abstract class NTKEcommerceAppService : ApplicationService
{
    protected NTKEcommerceAppService()
    {
        LocalizationResource = typeof(NTKEcommerceResource);
    }
}
