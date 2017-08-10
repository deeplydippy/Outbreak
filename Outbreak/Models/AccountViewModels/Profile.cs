using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Outbreak.Models.AccountViewModels
{
    public class ProfileViewModel
    {
        [Display(Name = "Отображать мой профиль в VK")]
        public bool ShowVK { get; set; }

        [Display(Name = "Отображать ссылку на мой профиль в Steam")]        
        public bool ShowSteam { get; set; }
    }
}
