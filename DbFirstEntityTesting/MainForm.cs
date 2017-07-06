using System;
using System.Linq;
using System.Windows.Forms;
using DbFirstEntityTesting.Model;
using DbFirstEntityTesting.Properties;

namespace DbFirstEntityTesting
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Stores a value that is passed to RentForm upon RentForm construction
        /// </summary>
        public DataGridViewCellCollection CurrentMovie { get; set; }
        /// <summary>
        /// Stores the ID of an unreturned movie, allowing it to be returned from method UpdateUnreturned()
        /// </summary>
        /// <seealso cref="UpdateUnreturned()"/>
        public DataGridViewCell UnreturnedMovie { get; set; }
        //EVENTS

        /// <summary>
        /// Selects a record - and fills in textboxes - based on the row and DataGrid clicked by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            else if(tpMovies.Contains(theSender))
            {
                lblMovieID.Text = theRecord[0].FormattedValue=="" ? "":theRecord[0].Value.ToString();//due to some unusual formatting of data
                txtRating.Text = theRecord[1].FormattedValue=="" ? "":theRecord[1].Value.ToString();//the Movies DataGrid must be checked for nulls.
                txtTitle.Text = theRecord[2].FormattedValue=="" ? "":theRecord[2].Value.ToString();//This is due to some movies having no plot or genre.
                txtYear.Text = theRecord[3].FormattedValue=="" ? "":theRecord[3].Value.ToString();//This also must be done 'manually' (i can't use a for each)
                txtRental_Cost.Text = theRecord[4].FormattedValue=="" ? "":theRecord[4].Value.ToString();//due to the values stored in the data grid not actually changing
                txtCopies.Text = theRecord[5].FormattedValue=="" ? "":theRecord[5].Value.ToString();
                txtPlot.Text = theRecord[6].FormattedValue=="" ? "":theRecord[6].Value.ToString();
                txtGenre.Text = theRecord[7].FormattedValue=="" ? "":theRecord[7].Value.ToString();
                CurrentMovie = theRecord;//for renting movie
            }
            else
            {
                UnreturnedMovie = theRecord[0];//in this case, I only need the ID
            }
        }
        /// <summary>
        /// Checks there is an unreturned movie selected, and then calls the UpdateUnreturned() method
        /// </summary>
        /// <seealso cref="UpdateUnreturned()"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (UnreturnedMovie is null) {MessageBox.Show(Resources.select_movie);return ; }
            UpdateUnreturned();
        }
        /// <summary>
        /// Checks if the customer textboxes are enabled/editable. If they are, it calls the UpdateCustomer() method, toggles btnUpdateCustomer.Text, and disables the textboxes. 
        /// Otherwise, it enables the textboxes and toggles btnUpdateCustomer.Text
        /// </summary>
        /// <remarks>Technically, this is both the 'edit' and the 'update' click event for btnUpdateCustomer</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Same as btnUpdateCustomer_Click, but replace references of 'customer' with 'movies'
        /// </summary>
        /// <see cref="btnUpdateCustomer_Click()"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// If a customer is selected, and if the user confirms, calls the DeleteCustomer() method
        /// </summary>
        /// <seealso cref="DeleteCustomer()"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustDelete_Click(object sender, EventArgs e)
        {
            if (lblCustID.Text == "#") {return;}//if no record has been selected
            if (MessageBox.Show(
                    Resources.confirm_delete_start+"customer "+Resources.confirm_delete_end,
                    "Confirm Action", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteCustomer();
            }
        }
        /// <see cref="btnCustDelete_Click()"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMovDelete_Click(object sender, EventArgs e)
        {
            if (lblMovieID.Text == "#") {return;}
            if (MessageBox.Show(
                    Resources.confirm_delete_start+"movie "+Resources.confirm_delete_end,
                    "Confirm Action", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteMovie();
            }
        }
        /// <summary>
        /// If a movie is selected, opens the RentForm form and passes the selected movie to the constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRent_Click(object sender, EventArgs e)
        {
            if(CurrentMovie is null) {MessageBox.Show(Resources.select_movie); return; }
            using (RentForm FormRent=new RentForm(CurrentMovie))
            {
                FormRent.ShowDialog();                
            }
        }
        /// <summary>
        /// opens the CustomerForm form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            using (CustomerForm FormCustomer = new CustomerForm())
            {
                FormCustomer.ShowDialog();
            }
        }
        /// <summary>
        /// Opens the MovieForm form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewMovie_Click(object sender, EventArgs e)
        {
            using (MovieForm FormMovie = new MovieForm())
            {
                FormMovie.ShowDialog();
            }
        }
        /// <summary>
        /// calls the LoadData() method
        /// </summary>
        /// <seealso cref="LoadData()"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
        //METHODS

        /// <summary>
        /// Calls all Load functions
        /// </summary>
        private void LoadData()
        {
            lblCustID.Text = "#";
            lblMovieID.Text = "#";
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
        /// <summary>
        /// Loads customer data into the customer DataGrid
        /// </summary>
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
        /// <summary>
        /// Loads movie data into the movies DataGrid
        /// </summary>
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
        /// <summary>
        /// Loads data into the rented movies DataGrid
        /// </summary>
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
        /// <summary>
        /// Loads data in to the unreturned DataGrid
        /// </summary>
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
        /// <summary>
        /// Checks if the data from the textboxes is valid. If true, updates selected customer, saves changes to the database, and reloads customers
        /// </summary>
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
                if (string.IsNullOrEmpty(theTextBox.Text) || lblCustID.Text == "#") {MessageBox.Show(Resources.fields_invalid);return;}
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
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Checks if the data from the textboxes is valid. If true, updates selected movie, saves changes to the database, and reloads movies
        /// </summary>
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
                if (string.IsNullOrEmpty(theTextBox.Text) || lblMovieID.Text == "#")
                {
                    txtRental_Cost.Text = RCval;
                    MessageBox.Show(Resources.fields_invalid);
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
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Sets the date returned to now for the selected unreturned movie, saves changes to the database, and reloads rented movies and unreturned movies
        /// </summary>
        private void UpdateUnreturned()
        {
            using (var context = new Entities())
            {
                var unreturned = (from u in context.RentedMovies
                                 where (u.RMID.ToString() == UnreturnedMovie.Value.ToString())
                                 select u).First();
                unreturned.DateReturned=DateTime.Now;
                context.SaveChanges();
            }
            LoadRentedMovies();
            LoadUnreturned();
        }
        /// <summary>
        /// Updates the selected customer's IsDeleted property to true, saves to database, and reloads the customers
        /// </summary>
        private void DeleteCustomer()
        {
            using (var context = new Entities())
            {
                var custDelete = (from c in context.Customer
                    where (c.CustID.ToString() == lblCustID.Text)
                    select c).First();
                custDelete.IsDeleted = true;
                context.SaveChanges();
            }
            LoadCustomers();
        }
        /// <summary>
        /// Updates the selected movie's IsDeleted property to true, saves to database, and reloads the movies
        /// </summary>
        private void DeleteMovie()
        {
            using (var context = new Entities())
            {
                var movDelete = (from m in context.Movies
                    where (m.MovieID.ToString() == lblMovieID.Text)
                    select m).First();
                movDelete.IsDeleted = true;
                context.SaveChanges();
            }
            LoadMovies();
        }
    }
}
