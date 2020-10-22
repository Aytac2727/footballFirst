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
    public partial class AdminForm : Form
    {
        FootballProjectEntities db = new FootballProjectEntities();
        public AdminForm()
        {
            InitializeComponent();
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cusForm = new CustomerForm();
            cusForm.Show();
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
