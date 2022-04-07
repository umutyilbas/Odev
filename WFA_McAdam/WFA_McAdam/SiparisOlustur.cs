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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

       
        List<Siparis> sepet=new List<Siparis>();

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {   
            rbKucuk.Checked= true;
            cmbMenu.DataSource=DataBase.Menus.ToList();
            foreach (Ekstra ekstra in DataBase.Ekstra)
            {
                checkedListBox1.Items.Add(ekstra);
            }
        }
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Siparis si=new Siparis();
            Menu menu = (Menu)cmbMenu.SelectedItem;
            si.Menu = menu;
            decimal fiyat = menu.Fiyat;
            if (rbBuyuk.Checked)
            {
                menu.Boyut = Boyutlar.Büyük;
                menu.Fiyat += 5m;
            }
            else if (rbKucuk.Checked)
            {
                menu.Boyut = Boyutlar.Küçük;
                
            }
            else if (rbOrta.Checked)
            {
                menu.Boyut = Boyutlar.Orta;
                menu.Fiyat += 3m;
            }
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                List<Ekstra> list = new List<Ekstra>();
                foreach (Ekstra ekstra in checkedListBox1.CheckedItems)
                {
                    list.Add(ekstra);
                    si.Ekstralar = list;
                    
                }

            }
            si.Adet = (byte)nudAdet.Value;
            
            listBox1.Items.Add(si);
            sepet.Add(si);
            DataBase.SiparisData.Add(si);
            decimal toplam = 0;
            foreach (Siparis siparis in sepet)
            {
                toplam += siparis.Fiyat;

            }
            lblToplamTutar.Text = toplam.ToString("C2");
            
        }
    }
}
