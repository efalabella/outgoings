using FileSystem;
using FileSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadPendingOutgoings(int year, int month)
        {
            StreamReader reader = (new StreamReader(GetPendingOgFile(year, month)));
            string json = reader.ReadToEnd();
            
            MessageBox.Show(json);

            string creditCardText = "";
            foreach (Outgoing og in Mapper.GetOutgoings(json))
            {
                creditCardText = (og.IsCreditCard) ? "tarjeta" : "efectivo";
                MessageBox.Show(string.Format("{0}, {1}, {2}, {3}", og.Day, og.Description, og.Amount, creditCardText));
            }
        }

        public string GetPendingOgFile(int year, int month)
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + string.Format("data\\fs\\{0}\\{1}\\pending.json", year, month.ToString("00"));
            return fileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPendingOutgoings(2013, 1);
        }
    }
}
