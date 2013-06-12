using FileSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileSystem
{
    public static class Mapper
    {
        public static List<Debt> GetDebts(string json) 
        {
            return JsonConvert.DeserializeObject<List<Debt>>(json);
        }

        public static List<Outgoing> GetOutgoings(string json)
        {
            return JsonConvert.DeserializeObject<List<Outgoing>>(json);
        }
    }
}
