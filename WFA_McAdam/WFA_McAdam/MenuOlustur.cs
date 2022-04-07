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
    public partial class MenuOlustur : Form
    {
        public MenuOlustur()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (DataBase.Menus.Count == 0)
            {
                Menu menu = new Menu();
                menu.Ad = txtMenuAd.Text;
                menu.Fiyat = nudMenuFiyat.Value;
                DataBase.Menus.Add(menu);
                txtMenuAd.Text = "";
                nudMenuFiyat.Value = 0;
                return;
            }
            foreach (Menu menu1 in DataBase.Menus)
            {
                if (menu1.Ad.ToLower() == txtMenuAd.Text.ToLower())
                {
                    MessageBox.Show("Girmiş olduğunuz menü sistemde bulunmaktadır.");
                    txtMenuAd.Text = "";
                    nudMenuFiyat.Value = 0;
                    return;
                }

            }
            Menu menu2 = new Menu();
            menu2.Ad = txtMenuAd.Text;
            menu2.Fiyat = nudMenuFiyat.Value;
            DataBase.Menus.Add(menu2);
            txtMenuAd.Text = "";
            nudMenuFiyat.Value = 0;


        }

       
    }
}





