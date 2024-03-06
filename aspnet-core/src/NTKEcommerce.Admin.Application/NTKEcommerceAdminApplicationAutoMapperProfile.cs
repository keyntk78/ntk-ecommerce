using AutoMapper;
using NTKEcommerce.Admin.ProductCategories;
using NTKEcommerce.Admin.Products;
using NTKEcommerce.ProductCategories;
using NTKEcommerce.Products;

namespace NTKEcommerce.Admin;

public class NTKEcommerceAdminApplicationAutoMapperProfile : Profile
{
    public NTKEcommerceAdminApplicationAutoMapperProfile()
    {
        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();
    }
}
