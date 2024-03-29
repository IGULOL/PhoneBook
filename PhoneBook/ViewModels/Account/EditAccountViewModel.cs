﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.ViewModels.Account
{
    public class EditAccountViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
    }
}
