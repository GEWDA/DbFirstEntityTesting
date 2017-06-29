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

            LoadData();

        }
        public Form3 FormNewCustomer { get; set; }
        public Form4 FormNewMovie { get; set; }
        public DataGridViewCellCollection CurrentMovie { get; set; }

        //EVENTS


        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0){return;}
            DataGridView theSender = (DataGridView) sender;
            var theRecord=theSender.Rows[e.RowIndex].Cells;
            if (tpCustomers.Contains(theSender))
            {
                lblCustID.Text = theRecord[0].Value.ToString();
                txtFirstName.Text = theRecord[1].Value.ToString();
                txtSurname.Text = theRecord[2].Value.ToString();
                txtAddress.Text = theRecord[3].Value.ToString();
                txtPhone.Text = theRecord[4].Value.ToString();
            }
            else
            {
                lblMovieID.Text = theRecord[0].Value.ToString();
                txtRating.Text = theRecord[1].Value.ToString();
                txtTitle.Text = theRecord[2].Value.ToString();
                txtYear.Text = theRecord[3].Value.ToString();
                txtRental_Cost.Text = theRecord[4].Value.ToString();
                txtCopies.Text = theRecord[5].Value.ToString();
                txtPlot.Text = theRecord[6].Value.ToString();
                txtGenre.Text = theRecord[7].Value.ToString();
                CurrentMovie = theRecord;//for renting movie
            }
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtSurname.Enabled)
            {
                UpdateCustomer();
                btnUpdateCustomer.Text = "Edit...";
            }
            else { btnUpdateCustomer.Text="Update";}
            foreach (var field in tpCustomers.Controls.OfType<TextBox>())
            {
                field.Enabled = !field.Enabled;
                field.Cursor = field.Cursor == Cursors.No ? Cursors.IBeam : Cursors.No;
            }
            LoadCustomers();
        }
        private void btnUpdateMovies_Click(object sender, EventArgs e)
        {
            if (txtTitle.Enabled)
            {
                UpdateMovie();
                btnUpdateMovies.Text = "Edit...";
            }
            else { btnUpdateMovies.Text = "Update"; }
            foreach (var field in tpMovies.Controls.OfType<TextBox>())
            {
                field.Enabled = !field.Enabled;
                field.Cursor=field.Cursor==Cursors.No?Cursors.IBeam:Cursors.No;
            }
            LoadMovies();
        }
        private void btnCustDelete_Click(object sender, EventArgs e)
        {
            if (lblCustID.Text == "#") {return;}
            if (MessageBox.Show(
                    "Are you sure you wish to delete this customer record?\nThis will not impact already recorded sales",
                    "Confirm Action", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteCustomer();
            }
        }
        private void btnMovDelete_Click(object sender, EventArgs e)
        {
            if (lblMovieID.Text == "#") {return;}
            if (MessageBox.Show(
                    "Are you sure you wish to delete this movie record?\nThis will not impact already recorded sales",
                    "Confirm Action", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteMovie();
            }
        }


        //METHODS


        private void CreateMovie()
        {
            
        }
        private void LoadData()
        {
            LoadCustomers();
            LoadMovies();
            LoadRentedMovies();
            LoadUnreturned();
            dataGridCustomers.Columns[0].Width=60;
            dataGridMovies.Columns[0].Width = 60;
            dataGridMovies.Columns[5].Width = 60;
            dataGridRentedMovies.Columns[0].Width = 60;
            dataGridRentedMovies.Columns[1].Width = 67;
            dataGridRentedMovies.Columns[3].Width = 67;
            dataGridUnreturned.Columns[0].Width = 60;
        }
        private void LoadCustomers()
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
            }
        }
        private void LoadMovies()
        {
            using (var context = new Entities())
            {
                var query = from m in context.Movies
                            where (!m.IsDeleted)
                    select new
                    {
                        m.MovieID,
                        m.Rating,
                        m.Title,
                        m.Year,
                        m.Rental_Cost,
                        m.Copies,
                        m.Plot,
                        m.Genre,
                    };

                dataGridMovies.DataSource = query.ToList();
            }
        }
        private void LoadRentedMovies()
        {
            using (var context = new Entities())
            {
                var query = from r in context.RentedMovies
                    select new
                    {
                        r.RMID,
                        r.MovieIDFK,
                        r.Movies.Title,
                        r.CustIDFK,
                        r.Customer.FirstName,
                        r.Customer.LastName,
                        r.DateRented,
                        r.DateReturned
                    };

                dataGridRentedMovies.DataSource = query.ToList();
            }
        }
        private void LoadUnreturned()
        {
            using (var context = new Entities())
            {
                var query = from u in context.CustomerAndMoviesRented
                            where (u.DateReturned == null)
                    select new
                    {
                        u.RMID,
                        u.FirstName,
                        u.LastName,
                        u.Address,
                        u.Title,
                        u.Rental_Cost,
                        u.DateRented,
                        u.DateReturned
                    };

                dataGridUnreturned.DataSource = query.ToList();
            }
        }
        private void UpdateCustomer()
        {
            try
            {
                Convert.ToInt64(txtPhone.Text);
            }
            catch
            {
                txtPhone.Text = null;//unlike UpdateMovie, I do not save the data from txtPhone, as it is the only field that can fail
            }
            foreach (var theTextBox in tpCustomers.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(theTextBox.Text)){MessageBox.Show("Please fill in all fields appropriately");return;}
            }
            using (var context = new Entities())
            {
                var custRecord = (from c in context.Customer
                    where (c.CustID.ToString() == lblCustID.Text)
                    select c).First();
                custRecord.FirstName = txtFirstName.Text;
                custRecord.LastName = txtSurname.Text;
                custRecord.Address = txtAddress.Text;
                custRecord.Phone = txtPhone.Text;
                //context.SaveChanges();
            }
        }//todo: uncomment context.SaveChanges()
        private void UpdateMovie()
        {
                var RCval = txtRental_Cost.Text;//saved due to temporary overwrite if the fields are formatted incorrectly
            try
            {
                Convert.ToDecimal(txtRental_Cost.Text);
                Convert.ToInt16(txtCopies.Text);
                Convert.ToInt16(txtYear.Text);
            }
            catch
            {

                txtRental_Cost.Text = null;//I only need one field to be null for NullOrEmpty to trigger
            }
            foreach (var theTextBox in tpMovies.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(theTextBox.Text))
                {
                    txtRental_Cost.Text = RCval;
                    MessageBox.Show("Please fill in all fields appropriately");
                    return;
                }
            }
            using (var context = new Entities())
            {
                var movRecord = (from m in context.Movies
                    where (m.MovieID.ToString()==lblMovieID.Text)
                              select m).First();    //i will only be updating 1 record at a time, and two records can't have
                movRecord.Title = txtTitle.Text;       //the same ID, so I will select the first (which is also the only) record I find
                movRecord.Rating = txtRating.Text;
                movRecord.Year = txtYear.Text;
                movRecord.Rental_Cost = Convert.ToDecimal(txtRental_Cost.Text);
                movRecord.Copies = txtCopies.Text;
                movRecord.Plot = txtPlot.Text;
                movRecord.Genre = txtGenre.Text;
                //context.SaveChanges();
            }
        }//todo: uncomment context.SaveChanges()
        private void DeleteCustomer()
        {
            using (var context = new Entities())
            {
                var custDelete = (from c in context.Customer
                    where (c.CustID.ToString() == lblCustID.Text)
                    select c).First();
                custDelete.IsDeleted = true;
                //context.SaveChanges();
            }
            LoadCustomers();
        }//todo: uncomment context.SaveChanges()
        private void DeleteMovie()
        {
            using (var context = new Entities())
            {
                var movDelete = (from m in context.Movies
                    where (m.MovieID.ToString() == lblMovieID.Text)
                    select m).First();
                movDelete.IsDeleted = true;
                //context.SaveChanges();
            }
            LoadMovies();
        }//todo: uncomment context.SaveChanges()

        private void btnRent_Click(object sender, EventArgs e)
        {
            using (Form2 FormRent=new Form2(CurrentMovie))
            {
                FormRent.ShowDialog();                
            }

        }
    }
}
