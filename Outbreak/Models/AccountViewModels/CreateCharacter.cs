using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Outbreak.Models.AccountViewModels
{
    public class CreateCharacterViewModel
    {
        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "ФИО обязательно!")]
        public string Name { get; set; }

        [Display(Name = "Предыстория")]
        [Required(ErrorMessage = "Предыстория обязательна!")]
        public string Biography { get; set; }
    }
}
