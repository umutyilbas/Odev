using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }
        decimal ciro = 0;
        private void Siparisler_Load(object sender, EventArgs e)
        {
            listBox1.DataSource=DataBase.SiparisData.ToList();
            foreach (Siparis siparis in DataBase.SiparisData)
            {
                ciro += siparis.Fiyat;
            }
            lblCiro.Text = ciro.ToString("C2");
        }
    }
}
