using System;
using System.Linq;
using System.Windows.Forms;
using DbFirstEntityTesting.Model;
using DbFirstEntityTesting.Properties;

namespace DbFirstEntityTesting
{
    /// <summary>
    /// Rent movie form
    /// </summary>
    public partial class RentForm : Form
    {
        public RentForm(DataGridViewCellCollection aMovie)
        {
            InitializeComponent();
            TheMovie = aMovie;
            TheCustomer = null;
            LoadDG();
        }
        /// <summary>
        /// Loads customer DataGrid
        /// </summary>
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
        /// <summary>
        /// The movie record passed in from Main Form
        /// </summary>
        /// <remarks>This should not be edited once form is initialized</remarks>
        public DataGridViewCellCollection TheMovie { get; set; }
        /// <summary>
        /// The customer selected by this form. This will start as null and will be edited
        /// </summary>
        public DataGridViewCellCollection TheCustomer { get; set; }
        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Loads all records that contain at least one cell that contains the string from txtSearch.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSearch_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Selects a record based on the row clicked by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridView theSender = (DataGridView)sender;
            TheCustomer = theSender.Rows[e.RowIndex].Cells;

        }
        /// <summary>
        /// Creates a new record in RentedMovies table, saves changes to Database, and then closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRentMovie_Click(object sender, EventArgs e)
        {
            if(TheCustomer is null) {MessageBox.Show(Resources.select_customer); return; }
            RentedMovies newRentedMovie = new RentedMovies();
            using (var context = new Entities())
            {
                newRentedMovie.MovieIDFK = Convert.ToInt32(TheMovie["MovieID"].Value);//turns out you can use the column names instead of numbers in a DGVCellCollection
                newRentedMovie.CustIDFK = Convert.ToInt32(TheCustomer["CustID"].Value);
                newRentedMovie.DateRented = DateTime.Now;
                context.RentedMovies.Add(newRentedMovie);
                context.SaveChanges();
            }
            Close();

        }
    }
}
