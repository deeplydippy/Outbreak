using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outbreak.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string Name { get; set; }
        public string Roles { get; set; }
        public string identityCode { get; set; }
        public string signature { get; set; }
        public string subRoles { get; set; }
        public bool live { get; set; }
    }
}
