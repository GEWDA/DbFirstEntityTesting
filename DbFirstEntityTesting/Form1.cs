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


        //EVENTS



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



        //METHODS
        private void LoadData()
        {
            LoadCustomers();
            LoadMovies();
            LoadRentedMovies();
            LoadUnreturned();
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
                var query = from r in context.CustomerAndMoviesRented
                    select new
                    {
                        r.RMID,
                        r.FirstName,
                        r.LastName,
                        r.Address,
                        r.Title,
                        r.Rental_Cost,
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
                Convert.ToInt16(txtPhone.Text);
            }
            catch
            {
                txtPhone.Text = null;
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
            try
            {
                Convert.ToDecimal(txtRental_Cost.Text);
            }
            catch
            {
                txtRental_Cost.Text = null;
            }
            foreach (var theTextBox in tpMovies.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(theTextBox.Text)) { MessageBox.Show("Please fill in all fields appropriately"); return; }
            }
            using (var context = new Entities())
            {
                var movRecord = (from m in context.Movies
                    where (m.MovieID.ToString()==lblMovieID.Text)
                              select m).First();    //i will only be updating 1 record at a time, and two records can't have
                movRecord.Title = txtTitle.Text;       //the same ID, so I will select the first (and the only) record I find
                movRecord.Rating = txtRating.Text;
                movRecord.Year = txtYear.Text;
                movRecord.Rental_Cost = Convert.ToDecimal(txtRental_Cost.Text);
                movRecord.Copies = txtCopies.Text;
                movRecord.Plot = txtPlot.Text;
                movRecord.Genre = txtGenre.Text;
                //context.SaveChanges();
            }
        }//todo: uncomment context.SaveChanges()



    }
}
