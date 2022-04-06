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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnHamburgerEkle_Click(object sender, EventArgs e)
        {
            if (Listeler.HamburgerListesi.Count == 0)
            {
                Hamburger hamburger = new Hamburger();
                hamburger.Ad = txtHamburgerAdi.Text;
                hamburger.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                hamburger.Ekle(hamburger);
                cmbHamburgerAdi.DataSource = Listeler.HamburgerListesi.ToList();
                lstEklenenHamburger.DataSource = Listeler.HamburgerListesi.ToList().Select(hamburger4 => hamburger4.Ad + " " + hamburger4.Fiyat.ToString("C2")).ToList();
                return;
            }
            foreach (Hamburger hamburger2 in Listeler.HamburgerListesi)
            {
                if (hamburger2.Ad.ToLower() != txtHamburgerAdi.Text.ToLower())
                {   
                    Hamburger hamburger = new Hamburger();
                    hamburger.Ad = txtHamburgerAdi.Text;
                    hamburger.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                    hamburger.Ekle(hamburger);
                    cmbHamburgerAdi.DataSource = Listeler.HamburgerListesi.ToList();
                    lstEklenenHamburger.DataSource = Listeler.HamburgerListesi.ToList().Select(hamburger4 => hamburger4.Ad + " " + hamburger4.Fiyat.ToString("C2")).ToList();
                    return;
                    
                }else 
                
                MessageBox.Show("Girmiş olduğunuz hamburger sistemde bulunuyor.");
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {   
            Hamburger hamburger = (Hamburger)cmbHamburgerAdi.SelectedItem;
            foreach (Hamburger hamburger1 in Listeler.HamburgerListesi)
            {
                if (hamburger1 == hamburger)
                {
                    hamburger1.FiyatGuncelle(Convert.ToDecimal(txtYeniFiyat.Text));
                    lstEklenenHamburger.DataSource = Listeler.HamburgerListesi.ToList().Select(hamburger4 => hamburger4.Ad + " " + hamburger4.Fiyat.ToString("C2")).ToList();
                    MessageBox.Show("Güncel Fiyat: " + hamburger1.Fiyat);
                }

            }
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            if (Listeler.EkstraListe.Count == 0)
            {
                Ekstra ekstra = new Ekstra();
                ekstra.Ad = txtExtraAd.Text;
                ekstra.Fiyat = Convert.ToDecimal(txtEkstraFiyat.Text);
                Listeler.EkstraListe.Add(ekstra);

                return;
            }
            foreach (Ekstra ekstra1 in Listeler.EkstraListe)
            {
                if (ekstra1.Ad.ToLower() != txtExtraAd.Text.ToLower())
                {
                    Ekstra ekstra3 = new Ekstra();
                    ekstra3.Ad= txtExtraAd.Text;
                    ekstra3.Fiyat = Convert.ToDecimal(txtEkstraFiyat.Text);
                    ekstra3.Ekle(ekstra3);
                    
                    return;

                }
                else

                    MessageBox.Show("Girmiş olduğunuz hamburger sistemde bulunuyor.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Hamburger hmb in Listeler.HamburgerListesi)
            {
                if(hmb.Ad+" "+hmb.Fiyat.ToString("C2")== (string)lstEklenenHamburger.SelectedItem)
                {
                    hmb.Kaldır(hmb);
                    lstEklenenHamburger.DataSource = Listeler.HamburgerListesi.ToList().Select(hamburger4 => hamburger4.Ad + " " + hamburger4.Fiyat.ToString("C2")).ToList();
                    return ;
                }

            }
            
        }

        private void btnHamburgerGecis_Click(object sender, EventArgs e)
        {
            if (Listeler.EkstraListe.Count == 0 || Listeler.HamburgerListesi.Count == 0)
            {
                DialogResult dr = MessageBox.Show("Ekstra listesi veya hamburger listesi boş! Geçmek istediğinize emin misiniz?", "BOŞ LİSTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    HamburgerForm hamburgerForm = new HamburgerForm();
                    hamburgerForm.Show();
                    this.Hide();
                }

            }
            else
            {
                HamburgerForm hamburgerForm = new HamburgerForm();
                hamburgerForm.Show();
                this.Hide();
            }
            
            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lstEklenenHamburger.DataSource=Listeler.HamburgerListesi.ToList().Select(hamburger => hamburger.Ad+" "+hamburger.Fiyat.ToString("C2")).ToList();
            cmbHamburgerAdi.DataSource= Listeler.HamburgerListesi.ToList().Select(hamburger => hamburger.Ad).ToList();
        }
    }
}
