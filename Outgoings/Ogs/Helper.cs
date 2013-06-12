using FileSystem;
using FileSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogs
{
    public static class Helper
    {
        public static List<Outgoing> GetPendingOutgoings(int year, int month)
        {
            StreamReader reader = (new StreamReader(GetPendingOutgoingFile(year, month)));
            string json = reader.ReadToEnd();
            
            return Mapper.GetOutgoings(json);
        }

        public static string GetPendingOutgoingFile(int year, int month)
        {
            return AppDomain.CurrentDomain.BaseDirectory + string.Format("data\\fs\\{0}\\{1}\\pending.json", year, month.ToString("00"));
        }

        public static string GetDoneOutgoingFile(int year, int month)
        {
            return AppDomain.CurrentDomain.BaseDirectory + string.Format("data\\fs\\{0}\\{1}\\done.json", year, month.ToString("00"));
        }
    }
}
