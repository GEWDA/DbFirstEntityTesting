using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFirstEntityTesting.Model;

namespace DbFirstEntityTesting
{
    /// <summary>
    /// Customer form
    /// </summary>
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt64(txtPhone.Text);
            }
            catch
            {
                txtPhone.Text = null;//unlike UpdateMovie, I do not save the data from txtPhone, as it is the only field that can fail
            }
            foreach (var theTextBox in Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(theTextBox.Text)) { MessageBox.Show("Please fill in all fields appropriately"); return; }
            }
            Customer newCustomer = new Customer();
            using (var context = new Entities())
            {
                newCustomer.Address = txtAddress.Text;
                newCustomer.Phone = txtPhone.Text;
                newCustomer.FirstName = txtFirstName.Text;
                newCustomer.LastName = txtSurname.Text;
                newCustomer.IsDeleted = false;
                context.Customer.Add(newCustomer);
                //context.SaveChanges();
            }
            Close();
        }//todo: uncomment context.SaveChanges()
    }
}
