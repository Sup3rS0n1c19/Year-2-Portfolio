namespace VowelOrConsonant
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
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.txtLetterResult = new System.Windows.Forms.TextBox();
            this.btnCheckLetter = new System.Windows.Forms.Button();
            this.lblLetter = new System.Windows.Forms.Label();
            this.lblLetterResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(313, 125);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(181, 20);
            this.txtLetter.TabIndex = 0;
            // 
            // txtLetterResult
            // 
            this.txtLetterResult.Location = new System.Drawing.Point(313, 278);
            this.txtLetterResult.Name = "txtLetterResult";
            this.txtLetterResult.Size = new System.Drawing.Size(181, 20);
            this.txtLetterResult.TabIndex = 1;
            // 
            // btnCheckLetter
            // 
            this.btnCheckLetter.Location = new System.Drawing.Point(367, 203);
            this.btnCheckLetter.Name = "btnCheckLetter";
            this.btnCheckLetter.Size = new System.Drawing.Size(80, 23);
            this.btnCheckLetter.TabIndex = 2;
            this.btnCheckLetter.Text = "Check Letter";
            this.btnCheckLetter.UseVisualStyleBackColor = true;
            this.btnCheckLetter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(376, 109);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(62, 13);
            this.lblLetter.TabIndex = 3;
            this.lblLetter.Text = "Enter Letter";
            // 
            // lblLetterResult
            // 
            this.lblLetterResult.AutoSize = true;
            this.lblLetterResult.Location = new System.Drawing.Point(376, 262);
            this.lblLetterResult.Name = "lblLetterResult";
            this.lblLetterResult.Size = new System.Drawing.Size(67, 13);
            this.lblLetterResult.TabIndex = 4;
            this.lblLetterResult.Text = "Letter Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLetterResult);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.btnCheckLetter);
            this.Controls.Add(this.txtLetterResult);
            this.Controls.Add(this.txtLetter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.TextBox txtLetterResult;
        private System.Windows.Forms.Button btnCheckLetter;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label lblLetterResult;
    }
}

