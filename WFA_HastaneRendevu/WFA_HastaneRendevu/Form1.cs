using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRendevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] bransAdlari = new string[100];
        string[] doktorAdlari = new string[300];
        int i = 0;
        int j = 0;
        private void btnBransEkle_Click(object sender, EventArgs e)
        {

            if (txtBrans.Text != "")
            {
                if (Brans.BransListesi.Count == 0)
                {
                    Brans brans = new Brans();
                    brans.Ad = txtBrans.Text;
                    bransAdlari[i] = brans.Ad.ToLower();
                    i++;
                    Brans.BransListesi.Add(brans);
                    cmbBrans.Items.Add(brans.Ad);
                    cmbBransRandevu.Items.Add(brans.Ad);
                    txtBrans.Text = null;
                    MessageBox.Show("Branş sisteme başarıyla kaydedildi.");

                }
                else
                {


                    if (!bransAdlari.Contains(txtBrans.Text.ToLower()))
                    {
                        Brans brans1 = new Brans();
                        brans1.Ad = txtBrans.Text;
                        bransAdlari[i] = brans1.Ad.ToLower();
                        i++;
                        Brans.BransListesi.Add(brans1);
                        cmbBrans.Items.Add(brans1.Ad);
                        cmbBransRandevu.Items.Add(brans1.Ad);
                        MessageBox.Show("Branş sisteme başarıyla kaydedildi.");
                        txtBrans.Text = null;

                    }
                    else
                    {
                        MessageBox.Show("Girmiş olduğunuz branş sistemde bulunmaktadır!");
                    }


                }


            }
            else
            {
                MessageBox.Show("Branş alanı boş bırakılamaz. Lütfen branş adı girin.");
            }



        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            if (txtDoktorAd.Text != "" && cmbBrans.SelectedIndex != -1)
            {


                if (Doktor.Doktorlar.Count == 0)
                {
                    Doktor doktor = new Doktor();
                    doktor.Ad = txtDoktorAd.Text;
                    foreach (Brans brans in Brans.BransListesi)
                    {
                        if (brans.Ad == cmbBrans.Text)
                        {
                            doktor.Brans = brans;
                        }
                    }
                    Doktor.Doktorlar.Add(doktor);
                    doktorAdlari[j] = doktor.Ad.ToLower();
                    MessageBox.Show("Doktor sisteme başarıyla eklendi.");
                    j++;


                }
                else
                {
                    if (!doktorAdlari.Contains(txtDoktorAd.Text.ToLower()))
                    {
                        Doktor doktor = new Doktor();
                        doktor.Ad = txtDoktorAd.Text;
                        foreach (Brans brans in Brans.BransListesi)
                        {
                            if (brans.Ad == cmbBrans.Text)
                            {
                                doktor.Brans = brans;
                            }
                        }
                        Doktor.Doktorlar.Add(doktor);
                        doktorAdlari[j] = doktor.Ad.ToLower();
                        MessageBox.Show("Doktor sisteme başarıyla eklendi.");
                        j++;
                    }
                    else
                    {
                        MessageBox.Show("Eklemeye çalıştığınız doktor sistemde bulunuyor!");
                    }


                }

                txtDoktorAd.Text = null;
                cmbBrans.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Doktor adı ve branş alanları boş bırakılamaz!");
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int dakika = 0;
            int saat = 9;

            flowLayoutPanel1.Controls.Clear();



            if (dateTimePicker1.Value.Day > DateTime.Now.Day)
            {
                for (int i = 0; i < 3; i++)
                {

                    for (int y = 0; y < 4; y++)
                    {

                        DateTime dt = new DateTime(2022, 2, 1, saat, dakika, 0);
                        Button btn = new Button();
                        flowLayoutPanel1.Controls.Add(btn);
                        btn.Width = 110;
                        btn.Height = 30;
                        btn.Left = y * 110;
                        btn.Top = i * 30;
                        btn.Text = dt.ToShortTimeString();
                        btn.BackColor = Color.Green;


                        if (dakika == 0)
                        {
                            dakika = 30;
                        }

                        else
                        {
                            dakika = 0;
                            saat++;
                        }

                        flowLayoutPanel1.Controls.Add(btn);
                        btn.Click += Btn_Click;

                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen ileri tarihteki bir günden ranevu alınız.");
            }
        }







        private void Btn_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == null && txtSoyad.Text == null && txtTckn.Text == null && cmbBransRandevu.SelectedIndex == -1 && cmbDoktorRandevu.SelectedIndex == -1)
            {
                MessageBox.Show("Boş bıraktığınız bilgiler var.Lütfen randevu için gerekli bütün bilgileri doldurun.");
            }
            Button btn = (Button)sender;

            DialogResult dr = MessageBox.Show("Randevu onaylansın mı?", "RANDEVU ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Randevu randevu = new Randevu();
                foreach (Doktor doktor in Doktor.Doktorlar)
                {
                    if ("Dr. " + doktor.Ad == cmbDoktorRandevu.Text)
                    {
                        randevu.Doktor = doktor;
                        randevu.Tarih = dateTimePicker1.Value;
                        randevu.HastaAdi = txtAd.Text;
                        randevu.HastaSoyad = txtSoyad.Text;
                        randevu.Brans = doktor.Brans;
                        randevu.Tckn = txtTckn.Text;

                    }
                }
                btn.Enabled = false;
                btn.BackColor = Color.Red;
                Randevu.RandevuListesi.Add(randevu);
                MessageBox.Show("Randevunuz oluşturuldu.Randevu bilgileriniz:" + "\n" + "Hasta Ad: " + randevu.HastaAdi + "\n" + "Hasta Soyad: " + randevu.HastaSoyad + "\n" + "TCKN: " + randevu.Tckn + "\n" + "Branş: " + randevu.Brans + "\n" + "Doktor: " + randevu.Doktor + "\n" + "Randevu Tarihi: " + randevu.Tarih.ToShortDateString() + "\n" + "Randevu Saati: " + btn.Text);
            }
            else
            {
                MessageBox.Show("Ranevu oluşturma işlemi iptal edildi.");
            }
        }

        private void cmbBransRandevu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorRandevu.Items.Clear();

            foreach (Doktor doktor in Doktor.Doktorlar)
            {
                foreach (Brans brans in Brans.BransListesi)
                {
                    if (cmbBransRandevu.Text == brans.Ad)
                    {
                        if (doktor.Brans == brans)
                        {
                            cmbDoktorRandevu.Items.Add(doktor);
                        }
                    }
                }

            }

        }
    }
}
