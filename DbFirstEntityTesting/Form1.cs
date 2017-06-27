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

        private void UpdateCustomer()
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
        private void UpdateMovie()
        {
            using (var context = new Entities())
            {
                var record = (from m in context.Movies
                    where (m.MovieID.ToString()==lblMovieID.Text)
                              select m).First();    //i will only be updating 1 record at a time, and two records can't have
                record.Title = txtTitle.Text;       //the same ID, so I will select the first (and the only) record I find
                record.Rating = txtRating.Text;
                record.Year = txtYear.Text;
                record.Rental_Cost = Convert.ToDecimal(txtRental_Cost.Text);
                record.Copies = txtCopies.Text;
                record.Plot = txtPlot.Text;
                record.Genre = txtGenre.Text;

                context.SaveChanges();
            }
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



    }
}
