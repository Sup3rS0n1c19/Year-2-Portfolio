namespace CrazyTaxi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalculateFare = new System.Windows.Forms.Button();
            this.txtTotalFare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnCalculateFare
            // 
            this.btnCalculateFare.Location = new System.Drawing.Point(314, 194);
            this.btnCalculateFare.Name = "btnCalculateFare";
            this.btnCalculateFare.Size = new System.Drawing.Size(138, 23);
            this.btnCalculateFare.TabIndex = 1;
            this.btnCalculateFare.Text = "Calculate Fare";
            this.btnCalculateFare.UseVisualStyleBackColor = true;
            this.btnCalculateFare.Click += new System.EventHandler(this.btnCalculateFare_Click);
            // 
            // txtTotalFare
            // 
            this.txtTotalFare.Location = new System.Drawing.Point(260, 347);
            this.txtTotalFare.Name = "txtTotalFare";
            this.txtTotalFare.Size = new System.Drawing.Size(235, 20);
            this.txtTotalFare.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalFare);
            this.Controls.Add(this.btnCalculateFare);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCalculateFare;
        private System.Windows.Forms.TextBox txtTotalFare;
    }
}

