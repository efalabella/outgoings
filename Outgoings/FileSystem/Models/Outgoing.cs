using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Models
{
    public class Outgoing
    {
        public int Day { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public bool IsCreditCard { get; set; }
    }
}
