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
