using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Models.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder
                .HasMany(u => u.Phones)
                .WithOne(m => m.Contact)
                .HasForeignKey(m => m.ContactId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
