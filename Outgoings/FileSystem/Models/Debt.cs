using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Models
{
    public class Debt
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string ToPerson { get; set; }
    }
}
