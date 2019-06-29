using PhoneBook.Models.Groups;
using PhoneBook.Models.Phones;
using PhoneBook.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models.Contacts
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Место работы")]
        public string Job { get; set; }
        [Display(Name = "Должность")]
        public string Position { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }

        public int UserId { get; set; } // ссылка на связанную модель User
        public User User { get; set; }

        [Display(Name = "Группа")]
        public int GroupId { get; set; }
        [Display(Name = "Группа")]
        public virtual Group Group { get; set; }

        public virtual List<Phone> Phones { get; set; }
    }
}
