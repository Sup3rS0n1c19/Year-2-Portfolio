namespace PeopleDatabase2024
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
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.btnReadData = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.txtDeleteAge = new System.Windows.Forms.TextBox();
            this.lblDeleteName = new System.Windows.Forms.Label();
            this.lblDeleteAge = new System.Windows.Forms.Label();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.lblUpdateAddress = new System.Windows.Forms.Label();
            this.lblUpdateTelephoneNumber = new System.Windows.Forms.Label();
            this.txtUpdateTelephoneNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.lblUpdateAge = new System.Windows.Forms.Label();
            this.txtUpdateAge = new System.Windows.Forms.TextBox();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.lblUpdateID = new System.Windows.Forms.Label();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(12, 290);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(100, 23);
            this.btnAddRecord.TabIndex = 0;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 91);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 75);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 156);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 139);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(15, 209);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(98, 13);
            this.lblTelephoneNumber.TabIndex = 6;
            this.lblTelephoneNumber.Text = "Telephone Number";
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(15, 225);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtTelephoneNumber.TabIndex = 5;
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(12, 365);
            this.txtPeople.Multiline = true;
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(544, 297);
            this.txtPeople.TabIndex = 9;
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(176, 689);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(177, 23);
            this.btnReadData.TabIndex = 10;
            this.btnReadData.Text = "Read Data";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Location = new System.Drawing.Point(176, 250);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(100, 23);
            this.btnDeletePerson.TabIndex = 11;
            this.btnDeletePerson.Text = "Delete Person";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.Location = new System.Drawing.Point(176, 91);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteName.TabIndex = 12;
            // 
            // txtDeleteAge
            // 
            this.txtDeleteAge.Location = new System.Drawing.Point(176, 170);
            this.txtDeleteAge.Name = "txtDeleteAge";
            this.txtDeleteAge.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteAge.TabIndex = 13;
            this.txtDeleteAge.Text = "0";
            // 
            // lblDeleteName
            // 
            this.lblDeleteName.AutoSize = true;
            this.lblDeleteName.Location = new System.Drawing.Point(173, 75);
            this.lblDeleteName.Name = "lblDeleteName";
            this.lblDeleteName.Size = new System.Drawing.Size(35, 13);
            this.lblDeleteName.TabIndex = 14;
            this.lblDeleteName.Text = "Name";
            // 
            // lblDeleteAge
            // 
            this.lblDeleteAge.AutoSize = true;
            this.lblDeleteAge.Location = new System.Drawing.Point(173, 154);
            this.lblDeleteAge.Name = "lblDeleteAge";
            this.lblDeleteAge.Size = new System.Drawing.Size(26, 13);
            this.lblDeleteAge.TabIndex = 15;
            this.lblDeleteAge.Text = "Age";
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(336, 225);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAddress.TabIndex = 24;
            // 
            // lblUpdateAddress
            // 
            this.lblUpdateAddress.AutoSize = true;
            this.lblUpdateAddress.Location = new System.Drawing.Point(336, 208);
            this.lblUpdateAddress.Name = "lblUpdateAddress";
            this.lblUpdateAddress.Size = new System.Drawing.Size(45, 13);
            this.lblUpdateAddress.TabIndex = 23;
            this.lblUpdateAddress.Text = "Address";
            // 
            // lblUpdateTelephoneNumber
            // 
            this.lblUpdateTelephoneNumber.AutoSize = true;
            this.lblUpdateTelephoneNumber.Location = new System.Drawing.Point(336, 274);
            this.lblUpdateTelephoneNumber.Name = "lblUpdateTelephoneNumber";
            this.lblUpdateTelephoneNumber.Size = new System.Drawing.Size(98, 13);
            this.lblUpdateTelephoneNumber.TabIndex = 22;
            this.lblUpdateTelephoneNumber.Text = "Telephone Number";
            // 
            // txtUpdateTelephoneNumber
            // 
            this.txtUpdateTelephoneNumber.Location = new System.Drawing.Point(336, 290);
            this.txtUpdateTelephoneNumber.Name = "txtUpdateTelephoneNumber";
            this.txtUpdateTelephoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateTelephoneNumber.TabIndex = 21;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(333, 91);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateName.TabIndex = 20;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(333, 74);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateName.TabIndex = 19;
            this.lblUpdateName.Text = "Name";
            // 
            // lblUpdateAge
            // 
            this.lblUpdateAge.AutoSize = true;
            this.lblUpdateAge.Location = new System.Drawing.Point(333, 140);
            this.lblUpdateAge.Name = "lblUpdateAge";
            this.lblUpdateAge.Size = new System.Drawing.Size(26, 13);
            this.lblUpdateAge.TabIndex = 18;
            this.lblUpdateAge.Text = "Age";
            // 
            // txtUpdateAge
            // 
            this.txtUpdateAge.Location = new System.Drawing.Point(333, 156);
            this.txtUpdateAge.Name = "txtUpdateAge";
            this.txtUpdateAge.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAge.TabIndex = 17;
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(336, 336);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateRecord.TabIndex = 16;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // lblUpdateID
            // 
            this.lblUpdateID.AutoSize = true;
            this.lblUpdateID.Location = new System.Drawing.Point(330, 6);
            this.lblUpdateID.Name = "lblUpdateID";
            this.lblUpdateID.Size = new System.Drawing.Size(18, 13);
            this.lblUpdateID.TabIndex = 26;
            this.lblUpdateID.Text = "ID";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(333, 22);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateID.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 724);
            this.Controls.Add(this.lblUpdateID);
            this.Controls.Add(this.txtUpdateID);
            this.Controls.Add(this.txtUpdateAddress);
            this.Controls.Add(this.lblUpdateAddress);
            this.Controls.Add(this.lblUpdateTelephoneNumber);
            this.Controls.Add(this.txtUpdateTelephoneNumber);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.lblUpdateName);
            this.Controls.Add(this.lblUpdateAge);
            this.Controls.Add(this.txtUpdateAge);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.lblDeleteAge);
            this.Controls.Add(this.lblDeleteName);
            this.Controls.Add(this.txtDeleteAge);
            this.Controls.Add(this.txtDeleteName);
            this.Controls.Add(this.btnDeletePerson);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTelephoneNumber);
            this.Controls.Add(this.txtTelephoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnAddRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.TextBox txtDeleteAge;
        private System.Windows.Forms.Label lblDeleteName;
        private System.Windows.Forms.Label lblDeleteAge;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.Label lblUpdateAddress;
        private System.Windows.Forms.Label lblUpdateTelephoneNumber;
        private System.Windows.Forms.TextBox txtUpdateTelephoneNumber;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Label lblUpdateAge;
        private System.Windows.Forms.TextBox txtUpdateAge;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Label lblUpdateID;
        private System.Windows.Forms.TextBox txtUpdateID;
    }
}

