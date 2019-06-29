using PhoneBook.Models.Contacts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models.Groups
{
    public class Group
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название группы")]
        public string Name { get; set; }

        public virtual List<Contact> Contacts { get; set; }
    }
}
