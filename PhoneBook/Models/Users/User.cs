using Microsoft.AspNetCore.Identity;
using PhoneBook.Models.Contacts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models.Users
{
    public class User : IdentityUser<int>
    {
        //id, email наследуются 

        [Required]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        public virtual List<Contact> Contacts { get; set; }
    }
}
