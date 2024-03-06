using AutoMapper;
using NTKEcommerce.Admin.ProductCategories;
using NTKEcommerce.ProductCategories;

namespace NTKEcommerce.Admin;

public class NTKEcommerceAdminApplicationAutoMapperProfile : Profile
{
    public NTKEcommerceAdminApplicationAutoMapperProfile()
    {
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();
    }
}
