using System;
using System.Linq;
using System.Windows.Forms;
using DbFirstEntityTesting.Model;
using DbFirstEntityTesting.Properties;

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
        /// <summary>
        /// Creates a new record in Customer table, saves changes to Database, and then closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt64(txtPhone.Text);
            }
            catch
            {
                txtPhone.Text = null;
            }
            foreach (var theTextBox in Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(theTextBox.Text)) { MessageBox.Show(Resources.fields_invalid); return; }
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
                context.SaveChanges();
            }
            Close();
        }
    }
}
