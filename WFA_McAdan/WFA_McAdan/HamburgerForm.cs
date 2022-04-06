using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdan
{
    public partial class HamburgerForm : Form
    {
        public HamburgerForm()
        {
            InitializeComponent();
        }
        decimal adet=0;
        private void HamburgerForm_Load(object sender, EventArgs e)
        {
            rbKucuk.Checked = true;
            if (Listeler.EkstraListe.Count == 0 || Listeler.HamburgerListesi.Count == 0)
            {

                return;
            }
            foreach (Hamburger hamburger in Listeler.HamburgerListesi)
            {
                cmbMenu.DataSource = Listeler.HamburgerListesi.ToList();

            }

            foreach (Ekstra ekstra in Listeler.EkstraListe)
            {
                checkedListBox1.Items.Add(ekstra);

            }



        }

        private void btnAdminGecis_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            foreach (Hamburger hamburger in Listeler.HamburgerListesi)
            {
                Hamburger hamburger1 = (Hamburger)cmbMenu.SelectedItem;
                if (hamburger.Ad == hamburger1.Ad)
                {
                    if (rbOrta.Checked)
                    {
                        hamburger.Boyut = Boyutlar.Orta;
                        hamburger.Fiyat += 3m;
                    }
                    else if (rbBuyuk.Checked)
                    {
                        hamburger.Boyut = Boyutlar.Büyük;
                        hamburger.Fiyat += 5m;
                    }
                    else if (rbKucuk.Checked)
                    {

                        hamburger.Boyut = Boyutlar.Küçük;
                    }

                    if (checkedListBox1.CheckedItems.Count > 0)
                    {   List<Ekstra> list = new List<Ekstra>();
                        foreach (Ekstra ekstra in checkedListBox1.CheckedItems)
                        {
                            list.Add(ekstra);
                            hamburger.HamburgerEkstras=list;
                        }
                        
                    }
                    adet = nudAdet.Value;
                    lblTutar.Text = (hamburger.ToplamFiyat*adet).ToString("C2");
                    listBox1.Items.Add(hamburger.Ad+" "+hamburger.ToplamFiyat*adet+" "+hamburger.Boyut.ToString());
                }
            }

        }
    }
}
