using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Dolap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //değişkenler
        List<Urun> urunler = new List<Urun>();
        decimal toplamTutar = 0;
        decimal genelTutar = 0;
        //Metotlar
        Ayakkabi AyakkabiOlustur(string marka,string model,int numara,decimal fiyat)
        {
            Ayakkabi ayakkabi = new Ayakkabi();
            ayakkabi.Marka = marka;
            ayakkabi.Model = model;
            ayakkabi.Numara = numara;
            ayakkabi.Kategori = "Ayakkabı";
            ayakkabi.Fiyat = fiyat;
            return ayakkabi;
            
        }
        Tshirt TshirtOlustur(string marka,string model,string renk,string beden,decimal fiyat)
        {
            Tshirt tshirt = new Tshirt();
            tshirt.Marka = marka;
            tshirt.Model = model;
            tshirt.Renk = renk;
            tshirt.Beden = beden;
            tshirt.Kategori = "Giyim";
            tshirt.Fiyat = fiyat;
            return tshirt;

        }
        Pantolon PantolonOlustur(string marka, string model, string renk,string kumasTuru ,string beden, decimal fiyat)
        {
            Pantolon pantolon = new Pantolon();
            pantolon.Marka = marka;
            pantolon.Model = model;
            pantolon.Renk = renk;
            pantolon.Beden = beden;
            pantolon.Kategori = "Giyim";
            pantolon.Fiyat = fiyat;
            pantolon.KumasTuru = kumasTuru;
            return pantolon;
        }
        Mont MontOlustur(string marka, string model, string renk, string beden, decimal fiyat,bool waterproof)
        {
            Mont mont = new Mont();
            mont.Marka = marka;
            mont.Model = model;
            mont.Renk = renk;
            mont.Beden = beden;
            mont.Kategori = "Giyim";
            mont.Fiyat = fiyat;
            mont.WaterProof = waterproof;
            return mont;

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Ayakkabılar
            Ayakkabi ayakkabi = AyakkabiOlustur("Nike","Air Max Plus",40,2469m);
            urunler.Add(ayakkabi);
            Ayakkabi ayakkabi1 = AyakkabiOlustur("Adidas", "Superstar", 38,800m) ;
            urunler.Add(ayakkabi1);
            Ayakkabi ayakkabi2 = AyakkabiOlustur("Tom Ford", "Deri Bot", 42,30000m);
            urunler.Add(ayakkabi2);
            //Tshirtler
            Tshirt tshirt = TshirtOlustur("Les Benjamins", "Bisiklet Yaka", "Mavi", "M", 449m);
            urunler.Add(tshirt);
            Tshirt tshirt1 = TshirtOlustur("AVVA","Bisiklet Yaka","Siyah","XL",134m);
            urunler.Add(tshirt1);
            Tshirt tshirt2 = TshirtOlustur("Faik Sönmez","Bisiklet Yaka","Kırmızı","S",100m);
            urunler.Add(tshirt2);
            //Pantolonlar
            Pantolon pantolon = PantolonOlustur("Mavi", "Jake 90 s", "Beyaz", "Kot", "S", 160m);
            urunler.Add(pantolon);
            Pantolon pantolon1 = PantolonOlustur("Network", "Jogger Fit", "Siyah", "Kumaş", "M",579m);
            urunler.Add(pantolon1);
            Pantolon pantolon2 = PantolonOlustur("Hemington", "TOM CHINO LEISURE","Kum Rengi","Keten","M",1999m);
            urunler.Add(pantolon2);
            //Montlar
            Mont mont = MontOlustur("Lacoste","Heritage","Lacivert","M",2437m,true);
            urunler.Add(mont);
            Mont mont1 = MontOlustur("Columbia","Mountainside Polar","Mavi","S",1424M,false);
            urunler.Add(mont1);
            Mont mont2 = MontOlustur("Tommy Hilfiger","Essential","Çok Renkli","L",1439M,true);
            urunler.Add(mont2);

            foreach(Urun urun in urunler)
            {
                if(urun is Ayakkabi)
                {
                    lstAyakkabi.Items.Add(urun);
                }
                else if(urun is Pantolon)
                {
                    lstPantolon.Items.Add(urun);
                }
                else if(urun is Mont)
                {
                    lstMont.Items.Add(urun);
                }
                else if(urun is Tshirt)
                {
                    lstTshirt.Items.Add(urun);
                }

            }






          







            /*
             uygulama açıldığında;
 3 adet ayakkabı
 3 adet tshirt
 3 adet pantolon
 3 adet mont

tanımlayarak ilgili list boxlarda özellikleri ile listeleyin. Kullanıcı listbox içerisinde tanımlı olan item'a çift tıkladıktan sonra lstSepet'e seçili olan item özellikleri ile eklensin ve toplam tutar'a ilgili ürünün fiyatı dahil edilsin.

alışverişi tamamla butonuna basıldıktan sonra lstSepet içerisinde bulunan itemlar listview içerisinde göserilsin ve lstSepet temizlensin.

listboxlar içerisinde fiyatlar kdv hariç sepete eklenildiğinde kdv dahil olarak hem gösterilecek hem de hesaplanacak.
             */


        }

        private void lstAyakkabi_DoubleClick(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi=(Ayakkabi)lstAyakkabi.SelectedItem;
            lstSepet.Items.Add(ayakkabi);
            toplamTutar += ayakkabi.Fiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");

        }

        private void lstTshirt_DoubleClick(object sender, EventArgs e)
        {
            Tshirt tshirt=(Tshirt)lstTshirt.SelectedItem;
            lstSepet.Items.Add(tshirt);
            toplamTutar += tshirt.Fiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
        }

        private void lstMont_DoubleClick(object sender, EventArgs e)
        {
            Mont mont=(Mont)lstMont.SelectedItem;
            lstSepet.Items.Add(mont);
            toplamTutar += mont.Fiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
        }

        private void lstPantolon_DoubleClick(object sender, EventArgs e)
        {
            Pantolon pantolon=(Pantolon)lstPantolon.SelectedItem;
            lstSepet.Items.Add(pantolon);
            toplamTutar += pantolon.Fiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            foreach(Urun urun in lstSepet.Items)
            {   ListViewItem lvi=new ListViewItem();
                lvi.Text = urun.Marka + " " + urun.Model;
                lvi.SubItems.Add(urun.Kategori);
                lvi.SubItems.Add(DateTime.Now.ToString());
                lvi.SubItems.Add(urun.KDVliFiyat.ToString("C2"));
                listView1.Items.Add(lvi);
                genelTutar += urun.KDVliFiyat;
                
            }
            lblGenelToplam.Text = genelTutar.ToString("C2");
            lstSepet.Items.Clear();
            toplamTutar= 0;
        }
    }
}
