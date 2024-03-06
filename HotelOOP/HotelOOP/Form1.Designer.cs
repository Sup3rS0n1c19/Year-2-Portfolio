namespace HotelOOP
{
    partial class TheEagleHotel
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
            this.lblTheEagleHotel = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnVacate = new System.Windows.Forms.Button();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblReportOnRooms = new System.Windows.Forms.Label();
            this.lblCustomerCountReport = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblIncomeReport = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grpOptions.SuspendLayout();
            this.grpReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTheEagleHotel
            // 
            this.lblTheEagleHotel.AutoSize = true;
            this.lblTheEagleHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTheEagleHotel.Location = new System.Drawing.Point(27, 13);
            this.lblTheEagleHotel.Name = "lblTheEagleHotel";
            this.lblTheEagleHotel.Size = new System.Drawing.Size(152, 25);
            this.lblTheEagleHotel.TabIndex = 0;
            this.lblTheEagleHotel.Text = "The Eagle Hotel";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(32, 86);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(32, 67);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(32, 201);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(97, 23);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Create Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click_1);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(32, 149);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNumber.TabIndex = 4;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(35, 130);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(75, 13);
            this.lblRoomNumber.TabIndex = 5;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.btnCreateReport);
            this.grpOptions.Controls.Add(this.btnVacate);
            this.grpOptions.Location = new System.Drawing.Point(12, 240);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(144, 185);
            this.grpOptions.TabIndex = 6;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            this.grpOptions.Visible = false;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(20, 48);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(95, 23);
            this.btnCreateReport.TabIndex = 1;
            this.btnCreateReport.Text = "Create Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            // 
            // btnVacate
            // 
            this.btnVacate.Location = new System.Drawing.Point(20, 19);
            this.btnVacate.Name = "btnVacate";
            this.btnVacate.Size = new System.Drawing.Size(95, 23);
            this.btnVacate.TabIndex = 0;
            this.btnVacate.Text = "Vacate Room";
            this.btnVacate.UseVisualStyleBackColor = true;
            this.btnVacate.Click += new System.EventHandler(this.btnVacate_Click);
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.lblIncomeReport);
            this.grpReports.Controls.Add(this.textBox3);
            this.grpReports.Controls.Add(this.lblCustomerCountReport);
            this.grpReports.Controls.Add(this.textBox2);
            this.grpReports.Controls.Add(this.lblReportOnRooms);
            this.grpReports.Controls.Add(this.textBox1);
            this.grpReports.Location = new System.Drawing.Point(196, 12);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(310, 413);
            this.grpReports.TabIndex = 7;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 92);
            this.textBox1.TabIndex = 0;
            // 
            // lblReportOnRooms
            // 
            this.lblReportOnRooms.AutoSize = true;
            this.lblReportOnRooms.Location = new System.Drawing.Point(6, 20);
            this.lblReportOnRooms.Name = "lblReportOnRooms";
            this.lblReportOnRooms.Size = new System.Drawing.Size(90, 13);
            this.lblReportOnRooms.TabIndex = 1;
            this.lblReportOnRooms.Text = "Report on Rooms";
            // 
            // lblCustomerCountReport
            // 
            this.lblCustomerCountReport.AutoSize = true;
            this.lblCustomerCountReport.Location = new System.Drawing.Point(6, 159);
            this.lblCustomerCountReport.Name = "lblCustomerCountReport";
            this.lblCustomerCountReport.Size = new System.Drawing.Size(117, 13);
            this.lblCustomerCountReport.TabIndex = 3;
            this.lblCustomerCountReport.Text = "Customer Count Report";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 178);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 92);
            this.textBox2.TabIndex = 2;
            // 
            // lblIncomeReport
            // 
            this.lblIncomeReport.AutoSize = true;
            this.lblIncomeReport.Location = new System.Drawing.Point(6, 296);
            this.lblIncomeReport.Name = "lblIncomeReport";
            this.lblIncomeReport.Size = new System.Drawing.Size(77, 13);
            this.lblIncomeReport.TabIndex = 5;
            this.lblIncomeReport.Text = "Income Report";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 315);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 92);
            this.textBox3.TabIndex = 4;
            // 
            // TheEagleHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpReports);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblTheEagleHotel);
            this.Name = "TheEagleHotel";
            this.Text = "Welcome to The Eagle Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpReports.ResumeLayout(false);
            this.grpReports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheEagleHotel;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnVacate;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.GroupBox grpReports;
        private System.Windows.Forms.Label lblReportOnRooms;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIncomeReport;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCustomerCountReport;
        private System.Windows.Forms.TextBox textBox2;
    }
}

