namespace ThemeParkManaager
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
            this.btnTicketResults = new System.Windows.Forms.Button();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblTickets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTicketResults
            // 
            this.btnTicketResults.Location = new System.Drawing.Point(299, 233);
            this.btnTicketResults.Name = "btnTicketResults";
            this.btnTicketResults.Size = new System.Drawing.Size(121, 23);
            this.btnTicketResults.TabIndex = 0;
            this.btnTicketResults.Text = "Ticket Sales Result";
            this.btnTicketResults.UseVisualStyleBackColor = true;
            this.btnTicketResults.Click += new System.EventHandler(this.btnTicketResults_Click);
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(299, 138);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(121, 20);
            this.txtTickets.TabIndex = 1;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(309, 122);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(91, 13);
            this.lblTickets.TabIndex = 2;
            this.lblTickets.Text = "Enter tickets sold:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.btnTicketResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTicketResults;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lblTickets;
    }
}

