namespace ForLoopName
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
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.btnWriteName = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtNameWritten = new System.Windows.Forms.TextBox();
            this.lblNameWritten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(339, 47);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 20);
            this.txtEnterName.TabIndex = 0;
            // 
            // btnWriteName
            // 
            this.btnWriteName.Location = new System.Drawing.Point(339, 101);
            this.btnWriteName.Name = "btnWriteName";
            this.btnWriteName.Size = new System.Drawing.Size(100, 23);
            this.btnWriteName.TabIndex = 1;
            this.btnWriteName.Text = "Write name?";
            this.btnWriteName.UseVisualStyleBackColor = true;
            this.btnWriteName.Click += new System.EventHandler(this.btnWriteName_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(359, 31);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(61, 13);
            this.lblEnterName.TabIndex = 2;
            this.lblEnterName.Text = "Enter name";
            // 
            // txtNameWritten
            // 
            this.txtNameWritten.Location = new System.Drawing.Point(339, 182);
            this.txtNameWritten.Multiline = true;
            this.txtNameWritten.Name = "txtNameWritten";
            this.txtNameWritten.Size = new System.Drawing.Size(100, 256);
            this.txtNameWritten.TabIndex = 3;
            // 
            // lblNameWritten
            // 
            this.lblNameWritten.AutoSize = true;
            this.lblNameWritten.Location = new System.Drawing.Point(359, 166);
            this.lblNameWritten.Name = "lblNameWritten";
            this.lblNameWritten.Size = new System.Drawing.Size(69, 13);
            this.lblNameWritten.TabIndex = 4;
            this.lblNameWritten.Text = "NameWritten";
            this.lblNameWritten.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNameWritten);
            this.Controls.Add(this.txtNameWritten);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.btnWriteName);
            this.Controls.Add(this.txtEnterName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Button btnWriteName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtNameWritten;
        private System.Windows.Forms.Label lblNameWritten;
    }
}

