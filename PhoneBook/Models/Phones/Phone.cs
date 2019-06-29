using PhoneBook.Models.Catalogs;
using PhoneBook.Models.Contacts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models.Phones
{
    public class Phone
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Номер")]
        public string Number { get; set; }

        [Display(Name = "Тип")]
        public int TypePhoneId { get; set; } // ссылка на связанную модель TypePhone
        [Display(Name = "Тип")]
        public TypePhone TypePhone { get; set; }

        public int ContactId { get; set; }  // ссылка на связанную модель Contact
        public Contact Contact { get; set; }
    }
}

/*
 * @model IEnumerable<PhoneBook.Models.Catalogs.TypePhone>
@{
    //ViewData["Title"] = "Список смартфонов";
    Layout = null;
}
<!DOCTYPE html>

<html>
<head>
    <title>Магазин смартфонов</title>
</head>
<body>
    <h3>Смартфоны</h3>
    <table>
        <tr>
            <td>Тип</td>
            <td></td>
        </tr>
        @foreach (var typephone in Model)
        {
            <tr>
                <td>@typephone.Name</td>
                <td><a href="~/Home/Buy/@typephone.Id">Купить</a></td>
            </tr>
        }
    </table>
</body>
</html>
 */
