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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("2D6D0E61-C1BF-4878-ACF0-A33E6BC3CCF0"),
                RoleId = Guid.Parse("5004F758-C9CA-4BC0-BA63-3D18BCFCBB94"),

            },
            new AppUserRole
            {
                UserId= Guid.Parse("61CDCC92-E5E1-4DA9-8E36-0AF0950472DD"),
                RoleId= Guid.Parse("8AB669AA-3AF6-4DDE-AB97-167927ACC2F5"),

            }
            );
        }
    }
}
