using FileSystem.Models;
using System;
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
            string creditCardText = "";
            foreach (Outgoing og in Helper.GetPendingOutgoings(year, month))
            {
                creditCardText = (og.IsCreditCard) ? "tarjeta" : "efectivo";
                MessageBox.Show(string.Format("{0}, {1}, {2}, {3}", og.Day, og.Description, og.Amount, creditCardText));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPendingOutgoings(2013, 1);
        }
    }
}
