using PhoneBook.Models.Phones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models.Catalogs
{
    public class TypePhone
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Тип")]
        public string Name { get; set; }

        public virtual List<Phone> Phones { get; set; }
    }
}
