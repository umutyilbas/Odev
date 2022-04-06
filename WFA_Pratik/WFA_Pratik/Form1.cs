using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Pratik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<CepTelefonu> list = new List<CepTelefonu>();
        CepTelefonu cepTelefonu = new CepTelefonu()
        {
            Ad = "Iphone",
            Fiyat = 20000m,
            Bellek = 10,
            Model = "Iphone 13"
        };
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cepTelefonu.Ekle();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cepTelefonu.Kaldir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cepTelefonu.Guncelle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cepTelefonu.Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cepTelefonu.KampanyaOlustur();
        }
    }
}
