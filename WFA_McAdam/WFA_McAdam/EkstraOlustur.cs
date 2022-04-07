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
    public partial class EkstraOlustur : Form
    {
        public EkstraOlustur()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            if (DataBase.Ekstra.Count == 0)
            {
                Ekstra ekstra = new Ekstra();
                ekstra.Ad = txtEkstra.Text;
                ekstra.Fiyat = nudEkstraFiyat.Value;
                DataBase.Ekstra.Add(ekstra);
                txtEkstra.Text = "";
                nudEkstraFiyat.Value = 0;
                return;
            }
            foreach (Ekstra ekstra1 in DataBase.Ekstra)
            {
                if (ekstra1.Ad.ToLower() == txtEkstra.Text.ToLower())
                {
                    MessageBox.Show("Girmiş olduğunuz ekstra sistemde bulunmaktadır.");
                    txtEkstra.Text = "";
                    nudEkstraFiyat.Value = 0;
                    return;
                }

            }
            Ekstra ekstra2 = new Ekstra();
            ekstra2.Ad = txtEkstra.Text;
            ekstra2.Fiyat = nudEkstraFiyat.Value;
            DataBase.Ekstra.Add(ekstra2);
            txtEkstra.Text = "";
            nudEkstraFiyat.Value = 0;
        }
    }
}
