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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string rol=txtRol.Text.ToLower();
            if(rol == Roller.kullanıcı.ToString())
            {
                HamburgerForm hamburgerForm = new HamburgerForm();
                hamburgerForm.Show();
                this.Hide();
               
            }else if(rol == Roller.admin.ToString())
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
        }
    }
}
