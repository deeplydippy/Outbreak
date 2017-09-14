using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outbreak.Models
{
    public class Mission
    {
        public int TaskId { get; set; }
        public int TypeId { get; set; }
        public string Executor { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool Actual { get; set; }
        public ApplicationUser Creator { get; set; }
    }
}
