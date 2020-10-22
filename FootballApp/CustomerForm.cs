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
    public partial class CustomerForm : Form
    {
        FootballProjectEntities db = new FootballProjectEntities();
        public CustomerForm()
        {
            InitializeComponent();
        }

        public void FillCustData()
        {
            dtgNewCustomer.DataSource = db.Customers.Select(c => new
            {
                c.Id,
                c.Firstname,
                c.Lastname,
                c.Phone,
                c.Address
            }).ToList();

            dtgNewCustomer.Columns[0].Visible = false;
        }
        private void btnAddCus_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstame.Text;
            string lastname = txtLastname.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string[] myArr = new string[] { firstname, lastname, phone, address };

            if (extentions.IsEmpty(myArr, string.Empty))
            {
                Customer newCus = new Customer()
                {
                    Firstname = firstname,
                    Lastname = lastname,
                    Phone = Convert.ToInt32(phone),
                    Address = address
                };
                db.Customers.Add(newCus);
                db.SaveChanges();
                FillCustData();
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillCustData();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 57 || txtPhone.Text.Length >= 10) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
