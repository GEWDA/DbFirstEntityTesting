namespace DbFirstEntityTesting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRented = new System.Windows.Forms.TabPage();
            this.dataGridRentedMovies = new System.Windows.Forms.DataGridView();
            this.tpCustomers = new System.Windows.Forms.TabPage();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.tpMovies = new System.Windows.Forms.TabPage();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.dataGridMovies = new System.Windows.Forms.DataGridView();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblIDtag = new System.Windows.Forms.Label();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.lblPlot = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtRental_Cost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.tpUnreturned = new System.Windows.Forms.TabPage();
            this.dataGridUnreturned = new System.Windows.Forms.DataGridView();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnUpdateMovies = new System.Windows.Forms.Button();
            this.btnCustDelete = new System.Windows.Forms.Button();
            this.btnMovDelete = new System.Windows.Forms.Button();
            this.btnNewMovie = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpRented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedMovies)).BeginInit();
            this.tpCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.tpMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).BeginInit();
            this.tpUnreturned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnreturned)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRented);
            this.tabControl1.Controls.Add(this.tpCustomers);
            this.tabControl1.Controls.Add(this.tpMovies);
            this.tabControl1.Controls.Add(this.tpUnreturned);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRented
            // 
            this.tpRented.Controls.Add(this.dataGridRentedMovies);
            this.tpRented.Location = new System.Drawing.Point(4, 22);
            this.tpRented.Margin = new System.Windows.Forms.Padding(2);
            this.tpRented.Name = "tpRented";
            this.tpRented.Padding = new System.Windows.Forms.Padding(2);
            this.tpRented.Size = new System.Drawing.Size(921, 523);
            this.tpRented.TabIndex = 0;
            this.tpRented.Text = "Rented Movies";
            this.tpRented.UseVisualStyleBackColor = true;
            // 
            // dataGridRentedMovies
            // 
            this.dataGridRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRentedMovies.Location = new System.Drawing.Point(8, 8);
            this.dataGridRentedMovies.Name = "dataGridRentedMovies";
            this.dataGridRentedMovies.Size = new System.Drawing.Size(908, 450);
            this.dataGridRentedMovies.TabIndex = 0;
            // 
            // tpCustomers
            // 
            this.tpCustomers.Controls.Add(this.btnNewCustomer);
            this.tpCustomers.Controls.Add(this.btnCustDelete);
            this.tpCustomers.Controls.Add(this.btnUpdateCustomer);
            this.tpCustomers.Controls.Add(this.lblCustID);
            this.tpCustomers.Controls.Add(this.txtPhone);
            this.tpCustomers.Controls.Add(this.dataGridCustomers);
            this.tpCustomers.Controls.Add(this.label1);
            this.tpCustomers.Controls.Add(this.label9);
            this.tpCustomers.Controls.Add(this.lblFirstName);
            this.tpCustomers.Controls.Add(this.label6);
            this.tpCustomers.Controls.Add(this.txtSurname);
            this.tpCustomers.Controls.Add(this.lblSurname);
            this.tpCustomers.Controls.Add(this.txtAddress);
            this.tpCustomers.Controls.Add(this.txtFirstName);
            this.tpCustomers.Location = new System.Drawing.Point(4, 22);
            this.tpCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.tpCustomers.Name = "tpCustomers";
            this.tpCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.tpCustomers.Size = new System.Drawing.Size(921, 523);
            this.tpCustomers.TabIndex = 1;
            this.tpCustomers.Text = "Customers";
            this.tpCustomers.UseVisualStyleBackColor = true;
            // 
            // lblCustID
            // 
            this.lblCustID.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(32, 468);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(34, 14);
            this.lblCustID.TabIndex = 19;
            this.lblCustID.Text = "#";
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(212, 492);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(74, 20);
            this.txtPhone.TabIndex = 32;
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(8, 8);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.Size = new System.Drawing.Size(908, 448);
            this.dataGridCustomers.TabIndex = 0;
            this.dataGridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Phone:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "ID:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(63, 468);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(47, 20);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "Name:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address:";
            // 
            // txtSurname
            // 
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(291, 465);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(92, 20);
            this.txtSurname.TabIndex = 26;
            // 
            // lblSurname
            // 
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(225, 468);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 20);
            this.lblSurname.TabIndex = 22;
            this.lblSurname.Text = "Surname:";
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.No;
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(72, 492);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(81, 20);
            this.txtAddress.TabIndex = 25;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(116, 465);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(103, 20);
            this.txtFirstName.TabIndex = 23;
            // 
            // tpMovies
            // 
            this.tpMovies.Controls.Add(this.btnRent);
            this.tpMovies.Controls.Add(this.btnNewMovie);
            this.tpMovies.Controls.Add(this.btnMovDelete);
            this.tpMovies.Controls.Add(this.btnUpdateMovies);
            this.tpMovies.Controls.Add(this.lblMovieID);
            this.tpMovies.Controls.Add(this.txtGenre);
            this.tpMovies.Controls.Add(this.dataGridMovies);
            this.tpMovies.Controls.Add(this.lblGenre);
            this.tpMovies.Controls.Add(this.lblIDtag);
            this.tpMovies.Controls.Add(this.txtPlot);
            this.tpMovies.Controls.Add(this.lblTitle);
            this.tpMovies.Controls.Add(this.txtCopies);
            this.tpMovies.Controls.Add(this.lblPlot);
            this.tpMovies.Controls.Add(this.lblRating);
            this.tpMovies.Controls.Add(this.lblCopies);
            this.tpMovies.Controls.Add(this.lblYear);
            this.tpMovies.Controls.Add(this.txtRental_Cost);
            this.tpMovies.Controls.Add(this.lblCost);
            this.tpMovies.Controls.Add(this.txtRating);
            this.tpMovies.Controls.Add(this.txtTitle);
            this.tpMovies.Controls.Add(this.txtYear);
            this.tpMovies.Location = new System.Drawing.Point(4, 22);
            this.tpMovies.Margin = new System.Windows.Forms.Padding(2);
            this.tpMovies.Name = "tpMovies";
            this.tpMovies.Size = new System.Drawing.Size(921, 523);
            this.tpMovies.TabIndex = 2;
            this.tpMovies.Text = "Movies";
            this.tpMovies.UseVisualStyleBackColor = true;
            // 
            // lblMovieID
            // 
            this.lblMovieID.BackColor = System.Drawing.SystemColors.Control;
            this.lblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(32, 471);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(34, 14);
            this.lblMovieID.TabIndex = 3;
            this.lblMovieID.Text = "#";
            // 
            // txtGenre
            // 
            this.txtGenre.Cursor = System.Windows.Forms.Cursors.No;
            this.txtGenre.Enabled = false;
            this.txtGenre.Location = new System.Drawing.Point(266, 495);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(74, 20);
            this.txtGenre.TabIndex = 16;
            // 
            // dataGridMovies
            // 
            this.dataGridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovies.Location = new System.Drawing.Point(6, 6);
            this.dataGridMovies.Name = "dataGridMovies";
            this.dataGridMovies.Size = new System.Drawing.Size(912, 452);
            this.dataGridMovies.TabIndex = 0;
            this.dataGridMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(213, 498);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 20);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Genre:";
            // 
            // lblIDtag
            // 
            this.lblIDtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDtag.Location = new System.Drawing.Point(10, 471);
            this.lblIDtag.Name = "lblIDtag";
            this.lblIDtag.Size = new System.Drawing.Size(27, 20);
            this.lblIDtag.TabIndex = 1;
            this.lblIDtag.Text = "ID:";
            // 
            // txtPlot
            // 
            this.txtPlot.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPlot.Enabled = false;
            this.txtPlot.Location = new System.Drawing.Point(440, 468);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(241, 20);
            this.txtPlot.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(63, 471);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // txtCopies
            // 
            this.txtCopies.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCopies.Enabled = false;
            this.txtCopies.Location = new System.Drawing.Point(371, 468);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(23, 20);
            this.txtCopies.TabIndex = 13;
            // 
            // lblPlot
            // 
            this.lblPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlot.Location = new System.Drawing.Point(400, 471);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(34, 20);
            this.lblPlot.TabIndex = 12;
            this.lblPlot.Text = "Plot:";
            // 
            // lblRating
            // 
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(10, 498);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(50, 20);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Rating:";
            // 
            // lblCopies
            // 
            this.lblCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopies.Location = new System.Drawing.Point(313, 471);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(52, 20);
            this.lblCopies.TabIndex = 11;
            this.lblCopies.Text = "Copies:";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(116, 498);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 20);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year:";
            // 
            // txtRental_Cost
            // 
            this.txtRental_Cost.Cursor = System.Windows.Forms.Cursors.No;
            this.txtRental_Cost.Enabled = false;
            this.txtRental_Cost.Location = new System.Drawing.Point(257, 468);
            this.txtRental_Cost.Name = "txtRental_Cost";
            this.txtRental_Cost.Size = new System.Drawing.Size(50, 20);
            this.txtRental_Cost.TabIndex = 10;
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(213, 471);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(38, 20);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost:";
            // 
            // txtRating
            // 
            this.txtRating.Cursor = System.Windows.Forms.Cursors.No;
            this.txtRating.Enabled = false;
            this.txtRating.Location = new System.Drawing.Point(66, 495);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(44, 20);
            this.txtRating.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(104, 468);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(103, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Cursor = System.Windows.Forms.Cursors.No;
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(161, 495);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(46, 20);
            this.txtYear.TabIndex = 8;
            // 
            // tpUnreturned
            // 
            this.tpUnreturned.Controls.Add(this.btnReturn);
            this.tpUnreturned.Controls.Add(this.dataGridUnreturned);
            this.tpUnreturned.Location = new System.Drawing.Point(4, 22);
            this.tpUnreturned.Margin = new System.Windows.Forms.Padding(2);
            this.tpUnreturned.Name = "tpUnreturned";
            this.tpUnreturned.Size = new System.Drawing.Size(921, 523);
            this.tpUnreturned.TabIndex = 3;
            this.tpUnreturned.Text = "Unreturned Movies";
            this.tpUnreturned.UseVisualStyleBackColor = true;
            // 
            // dataGridUnreturned
            // 
            this.dataGridUnreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUnreturned.Location = new System.Drawing.Point(6, 6);
            this.dataGridUnreturned.Name = "dataGridUnreturned";
            this.dataGridUnreturned.Size = new System.Drawing.Size(912, 452);
            this.dataGridUnreturned.TabIndex = 0;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(404, 492);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 33;
            this.btnUpdateCustomer.Text = "Edit...";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnUpdateMovies
            // 
            this.btnUpdateMovies.Location = new System.Drawing.Point(687, 468);
            this.btnUpdateMovies.Name = "btnUpdateMovies";
            this.btnUpdateMovies.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMovies.TabIndex = 34;
            this.btnUpdateMovies.Text = "Edit...";
            this.btnUpdateMovies.UseVisualStyleBackColor = true;
            this.btnUpdateMovies.Click += new System.EventHandler(this.btnUpdateMovies_Click);
            // 
            // btnCustDelete
            // 
            this.btnCustDelete.Location = new System.Drawing.Point(485, 492);
            this.btnCustDelete.Name = "btnCustDelete";
            this.btnCustDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCustDelete.TabIndex = 34;
            this.btnCustDelete.Text = "Delete";
            this.btnCustDelete.UseVisualStyleBackColor = true;
            this.btnCustDelete.Click += new System.EventHandler(this.btnCustDelete_Click);
            // 
            // btnMovDelete
            // 
            this.btnMovDelete.Location = new System.Drawing.Point(687, 495);
            this.btnMovDelete.Name = "btnMovDelete";
            this.btnMovDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMovDelete.TabIndex = 35;
            this.btnMovDelete.Text = "Delete";
            this.btnMovDelete.UseVisualStyleBackColor = true;
            this.btnMovDelete.Click += new System.EventHandler(this.btnMovDelete_Click);
            // 
            // btnNewMovie
            // 
            this.btnNewMovie.Location = new System.Drawing.Point(768, 468);
            this.btnNewMovie.Name = "btnNewMovie";
            this.btnNewMovie.Size = new System.Drawing.Size(150, 23);
            this.btnNewMovie.TabIndex = 36;
            this.btnNewMovie.Text = "New Movie...";
            this.btnNewMovie.UseVisualStyleBackColor = true;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(768, 495);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(150, 23);
            this.btnRent.TabIndex = 37;
            this.btnRent.Text = "Rent Movie...";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(566, 492);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(150, 23);
            this.btnNewCustomer.TabIndex = 38;
            this.btnNewCustomer.Text = "New Customer...";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(768, 464);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 23);
            this.btnReturn.TabIndex = 39;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 616);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpRented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedMovies)).EndInit();
            this.tpCustomers.ResumeLayout(false);
            this.tpCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.tpMovies.ResumeLayout(false);
            this.tpMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).EndInit();
            this.tpUnreturned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnreturned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRented;
        private System.Windows.Forms.TabPage tpCustomers;
        private System.Windows.Forms.TabPage tpMovies;
        private System.Windows.Forms.TabPage tpUnreturned;
        private System.Windows.Forms.DataGridView dataGridRentedMovies;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.DataGridView dataGridMovies;
        private System.Windows.Forms.DataGridView dataGridUnreturned;
        private System.Windows.Forms.Label lblIDtag;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtRental_Cost;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnUpdateMovies;
        private System.Windows.Forms.Button btnCustDelete;
        private System.Windows.Forms.Button btnMovDelete;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnNewMovie;
        private System.Windows.Forms.Button btnReturn;
    }
}

