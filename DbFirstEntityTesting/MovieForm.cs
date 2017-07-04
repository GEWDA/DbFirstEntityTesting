using DbFirstEntityTesting.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFirstEntityTesting
{
    /// <summary>
    /// Movie form 
    /// </summary>
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        Movies newMovie = new Movies();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!CheckValidity()) {return; }
            using (var context = new Entities())
            {
                newMovie.Copies = txtCopies.Text;
                newMovie.Genre = txtGenre.Text;
                newMovie.IsDeleted = false;
                newMovie.Plot = txtPlot.Text;
                newMovie.Rating = txtRating.Text;
                newMovie.Rental_Cost = Convert.ToDecimal(txtRental_Cost.Text);
                newMovie.Title = txtTitle.Text;
                newMovie.Year = txtYear.Text;
                context.Movies.Add(newMovie);
                context.SaveChanges();
            }
            Close();
        }

        private bool CheckValidity()
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
            foreach (var theTextBox in Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(theTextBox.Text))
                {
                    txtRental_Cost.Text = RCval;
                    MessageBox.Show("Please fill in all fields appropriately");
                    return false;
                }
            }
            return true;
        }
    }
}
