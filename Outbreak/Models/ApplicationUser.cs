using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Outbreak.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string steamLink { get; set; }
        public string vkLink { get; set; }
        public string commNick { get; set; } //nick for site and TS
        public string tempNick { get; set; } //nick in game
        public string docCode { get; set; } //code of nick
    }
}
