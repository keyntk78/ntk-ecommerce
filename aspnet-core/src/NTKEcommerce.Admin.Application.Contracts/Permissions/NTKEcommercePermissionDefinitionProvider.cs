using NTKEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NTKEcommerce.Admin.Permissions;

public class NTKEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NTKEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NTKEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NTKEcommerceResource>(name);
    }
}
