using FootballApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApp
{
    public partial class Login : Form
    {
        FootballProjectEntities db = new FootballProjectEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string adminName = txtName.Text;
            string adminPas = txtPas.Text;
            Admin selectedAdmin = db.Admins.FirstOrDefault(adm => adm.AdminEmail == adminName);
            if(selectedAdmin !=null)
            {
                if(selectedAdmin.AdminPassword == adminPas)
                {
                    AdminForm adForm = new AdminForm();
                    adForm.Show();
                    this.WindowState = FormWindowState.Minimized;
                }
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
