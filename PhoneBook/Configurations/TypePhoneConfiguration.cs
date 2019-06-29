using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Configurations
{
    public class TypePhoneConfiguration : IEntityTypeConfiguration<TypePhone>
    {
        public void Configure(EntityTypeBuilder<TypePhone> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder
                .HasMany(u => u.Phones)
                .WithOne(m => m.TypePhone)
                .HasForeignKey(m => m.TypePhoneId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
