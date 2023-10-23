namespace PythagorasFunction
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtHypotenuse = new System.Windows.Forms.TextBox();
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblHypotenuse = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(335, 237);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate Hypotenuse";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(335, 162);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(142, 20);
            this.txtSideB.TabIndex = 1;
            // 
            // txtHypotenuse
            // 
            this.txtHypotenuse.Location = new System.Drawing.Point(335, 335);
            this.txtHypotenuse.Name = "txtHypotenuse";
            this.txtHypotenuse.Size = new System.Drawing.Size(142, 20);
            this.txtHypotenuse.TabIndex = 3;
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(377, 64);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(69, 13);
            this.lblSideA.TabIndex = 4;
            this.lblSideA.Text = "Enter Side A:";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(377, 146);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(69, 13);
            this.lblSideB.TabIndex = 5;
            this.lblSideB.Text = "Enter Side B:";
            // 
            // lblHypotenuse
            // 
            this.lblHypotenuse.AutoSize = true;
            this.lblHypotenuse.Location = new System.Drawing.Point(379, 319);
            this.lblHypotenuse.Name = "lblHypotenuse";
            this.lblHypotenuse.Size = new System.Drawing.Size(67, 13);
            this.lblHypotenuse.TabIndex = 6;
            this.lblHypotenuse.Text = "Hypotenuse:";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(335, 80);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(142, 20);
            this.txtSideA.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHypotenuse);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.lblSideA);
            this.Controls.Add(this.txtHypotenuse);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtHypotenuse;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblHypotenuse;
        private System.Windows.Forms.TextBox txtSideA;
    }
}

