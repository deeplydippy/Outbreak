using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outbreak.Models
{
    public class Diary
    {
        public int DiaryId { get; set; }
        public ApplicationUser User { get; set; }
        public Character Char { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
