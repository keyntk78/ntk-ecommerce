﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTKEcommerce.Products
{
    public class ProductAttributeDateTimeConfiguration : IEntityTypeConfiguration<ProductAttributeDateTime>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeDateTime> builder)
        {
            builder.ToTable(NTKEcommerceConsts.DbTablePrefix + "ProductAttributeDateTimes");
            builder.HasKey(x => x.Id);


           
        }
    }
}
