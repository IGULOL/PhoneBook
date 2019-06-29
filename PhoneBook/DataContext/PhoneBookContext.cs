using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Configurations;
using PhoneBook.Models.Catalogs;
using PhoneBook.Models.Contacts;
using PhoneBook.Models.Groups;
using PhoneBook.Models.Phones;
using PhoneBook.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.DataContext
{
    public class PhoneBookContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        //users наследуется

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<TypePhone> TypePhones { get; set; }
        public DbSet<Group> Groups { get; set; }

        public PhoneBookContext()
        {
            Database.EnsureCreated();
        }

        public PhoneBookContext(DbContextOptions<PhoneBookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new GroupConfiguration());
            builder.ApplyConfiguration(new TypePhoneConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
