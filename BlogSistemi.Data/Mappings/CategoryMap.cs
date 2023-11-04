using BlogSistemi.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSistemi.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {


                Id = Guid.Parse("87607752-BD4F-498C-9C1C-EFC5573D120D"),
                Name = "Asp.Net Core",
                CreateDate = DateTime.Now,


            },
            new Category
            {


                Id = Guid.Parse("FCA52C48-C773-4F61-B892-0673234348DD"),
                Name = "Net Core",
                CreateDate = DateTime.Now,



            });
        }
    }
}
