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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loadCustomers();

        }

        private void loadCustomers()
        {
            using (var context = new Entities())
            {
                var query = from c in context.Customer
                    select new
                    {
                        c.FirstName,
                        c.LastName,
                        c.Address
                    };

                dataGridView3.DataSource = query.ToList();
            }
        }
    }
}
