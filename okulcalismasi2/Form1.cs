using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okulcalismasi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogretmen ogr = new Ogretmen
            {
                Ad = "Ahmet",
                Soyad = "Öz",
                Brans = "Matematik"

            };
            OkulElemanlari per = ogr; // !!!
            MessageBox.Show(per.Ad);
            public abstract class MotorluArac
        {
            public int MotorHacmi { get; set; }
            public int ModelYili { get; set; }
            public abstract void Calis();
            public abstract void Dur();
        }
        public class Otomobil : MotorluArac
        {
            public bool OtomatikVites { get; set; }
            public override void Calis()
            {
                MessageBox.Show("Otomobil çalıştı.");
            }
            public override void Dur()
            {
                MessageBox.Show("Otomobil durdu.");
            }
        }
    }
    }
}
