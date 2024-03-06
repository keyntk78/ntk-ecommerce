using System;
using System.Collections.Generic;
using System.Text;
using NTKEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace NTKEcommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class NTKEcommerceAdminAppService : ApplicationService
{
    protected NTKEcommerceAdminAppService()
    {
        LocalizationResource = typeof(NTKEcommerceResource);
    }
}
