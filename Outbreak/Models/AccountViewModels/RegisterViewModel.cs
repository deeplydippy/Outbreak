using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Outbreak.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required (ErrorMessage = "Адрес электронной почты обязателен")]
        [EmailAddress(ErrorMessage = "Некорректный адрес электронной почты")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль обязателен")]
        [StringLength(100, ErrorMessage = "Пароль должен быть от {2} до {1} символов длиной", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Повторить пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
