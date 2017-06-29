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
    public partial class Form2 : Form
    {
        public Form2(DataGridViewCellCollection aMovie)
        {
            InitializeComponent();
            TheMovie = aMovie;
            LoadDG();
        }

        private void LoadDG()
        {
            using (var context = new Entities())
            {
                var query = from c in context.Customer
                    where (!c.IsDeleted)
                    select new
                    {
                        c.CustID,
                        c.FirstName,
                        c.LastName,
                        c.Address,
                        c.Phone,
                    };

                dataGridCustomers.DataSource = query.ToList();
                dataGridCustomers.Columns[0].Width = 60;
            }
        }

        public DataGridViewCellCollection TheMovie { get; set; }
        public DataGridViewCellCollection TheCustomer { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var query = from c in context.Customer
                    where (!c.IsDeleted && (c.FirstName.Contains(txtSearch.Text) || c.LastName.Contains(txtSearch.Text) || c.Address.Contains(txtSearch.Text) || c.Phone.Contains(txtSearch.Text)))
                    select new
                    {
                        c.CustID,
                        c.FirstName,
                        c.LastName,
                        c.Address,
                        c.Phone,
                    };

                dataGridCustomers.DataSource = query.ToList();
            }
        }
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridView theSender = (DataGridView)sender;
            TheCustomer = theSender.Rows[e.RowIndex].Cells;

        }
    }
}
