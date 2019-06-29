using PhoneBook.Models.Catalogs;
using PhoneBook.Models.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.DataContext
{
    public class SampleData
    {
        public static void Initialize(PhoneBookContext context)
        {
            if (!context.TypePhones.Any())
            {
                context.TypePhones.AddRange(
                    new TypePhone
                    {
                        Name = "Мобильный"
                    },
                    new TypePhone
                    {
                        Name = "Рабочий"
                    },
                    new TypePhone
                    {
                        Name = "Домашний"
                    }
                );
                context.SaveChanges();
            }
            if (!context.Groups.Any())
            {
                context.Groups.AddRange(
                    new Group
                    {
                        Name = "Неизвестно"
                    },
                    new Group
                    {
                        Name = "Семья"
                    },
                    new Group
                    {
                        Name = "Работа"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
