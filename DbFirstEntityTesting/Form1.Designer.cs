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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridRentedMovies = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridMovies = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridUnreturned = new System.Windows.Forms.DataGridView();
            this.lblIDtag = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtRental_Cost = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.lblPlot = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedMovies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnreturned)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridRentedMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(921, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rented Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridRentedMovies
            // 
            this.dataGridRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRentedMovies.Location = new System.Drawing.Point(8, 8);
            this.dataGridRentedMovies.Name = "dataGridRentedMovies";
            this.dataGridRentedMovies.Size = new System.Drawing.Size(908, 450);
            this.dataGridRentedMovies.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCustID);
            this.tabPage2.Controls.Add(this.txtPhone);
            this.tabPage2.Controls.Add(this.dataGridCustomers);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lblFirstName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtSurname);
            this.tabPage2.Controls.Add(this.lblSurname);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.txtFirstName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(921, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(8, 8);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.Size = new System.Drawing.Size(908, 448);
            this.dataGridCustomers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblMovieID);
            this.tabPage3.Controls.Add(this.txtGenre);
            this.tabPage3.Controls.Add(this.dataGridMovies);
            this.tabPage3.Controls.Add(this.lblGenre);
            this.tabPage3.Controls.Add(this.lblIDtag);
            this.tabPage3.Controls.Add(this.txtPlot);
            this.tabPage3.Controls.Add(this.lblTitle);
            this.tabPage3.Controls.Add(this.txtCopies);
            this.tabPage3.Controls.Add(this.lblPlot);
            this.tabPage3.Controls.Add(this.lblRating);
            this.tabPage3.Controls.Add(this.lblCopies);
            this.tabPage3.Controls.Add(this.lblYear);
            this.tabPage3.Controls.Add(this.txtRental_Cost);
            this.tabPage3.Controls.Add(this.lblCost);
            this.tabPage3.Controls.Add(this.txtRating);
            this.tabPage3.Controls.Add(this.txtTitle);
            this.tabPage3.Controls.Add(this.txtYear);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(921, 523);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridMovies
            // 
            this.dataGridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovies.Location = new System.Drawing.Point(6, 6);
            this.dataGridMovies.Name = "dataGridMovies";
            this.dataGridMovies.Size = new System.Drawing.Size(912, 452);
            this.dataGridMovies.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridUnreturned);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(921, 523);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Unreturned Movies";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridUnreturned
            // 
            this.dataGridUnreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUnreturned.Location = new System.Drawing.Point(6, 6);
            this.dataGridUnreturned.Name = "dataGridUnreturned";
            this.dataGridUnreturned.Size = new System.Drawing.Size(912, 452);
            this.dataGridUnreturned.TabIndex = 0;
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
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(63, 471);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblMovieID
            // 
            this.lblMovieID.BackColor = System.Drawing.SystemColors.Control;
            this.lblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(32, 471);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(34, 14);
            this.lblMovieID.TabIndex = 3;
            this.lblMovieID.Text = "4";
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
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(116, 498);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 20);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year:";
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
            // txtRating
            // 
            this.txtRating.Cursor = System.Windows.Forms.Cursors.No;
            this.txtRating.Enabled = false;
            this.txtRating.Location = new System.Drawing.Point(66, 495);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(44, 20);
            this.txtRating.TabIndex = 9;
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
            // txtPlot
            // 
            this.txtPlot.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPlot.Enabled = false;
            this.txtPlot.Location = new System.Drawing.Point(440, 468);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(241, 20);
            this.txtPlot.TabIndex = 14;
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
            // lblCopies
            // 
            this.lblCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopies.Location = new System.Drawing.Point(313, 471);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(52, 20);
            this.lblCopies.TabIndex = 11;
            this.lblCopies.Text = "Copies:";
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
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(213, 498);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 20);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Genre:";
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Phone:";
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
            // lblSurname
            // 
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(225, 468);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 20);
            this.lblSurname.TabIndex = 22;
            this.lblSurname.Text = "Surname:";
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
            // lblCustID
            // 
            this.lblCustID.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(32, 468);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(34, 14);
            this.lblCustID.TabIndex = 19;
            this.lblCustID.Text = "4";
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
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "ID:";
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedMovies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnreturned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
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
    }
}

