namespace PeopleDB2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddRecord = new Button();
            lblName = new Label();
            txtName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            SuspendLayout();
            // 
            // btnAddRecord
            // 
            btnAddRecord.Location = new Point(74, 257);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(94, 23);
            btnAddRecord.TabIndex = 0;
            btnAddRecord.Text = "Add Record";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(68, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(68, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(68, 140);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(68, 158);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnAddRecord);
            Name = "Form1";
            Text = "People Database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddRecord;
        private Label lblName;
        private TextBox txtName;
        private Label lblAge;
        private TextBox txtAge;
    }
}