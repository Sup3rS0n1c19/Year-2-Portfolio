namespace ClassCalculator
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.btnCalculateResult = new System.Windows.Forms.Button();
            this.txtEquationSymbol = new System.Windows.Forms.TextBox();
            this.lblEquationSymbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(205, 88);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(505, 88);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 1;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(205, 69);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(81, 13);
            this.lblNumber1.TabIndex = 2;
            this.lblNumber1.Text = "Enter Number 1";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(505, 69);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(81, 13);
            this.lblNumber2.TabIndex = 3;
            this.lblNumber2.Text = "Enter Number 2";
            // 
            // btnCalculateResult
            // 
            this.btnCalculateResult.Location = new System.Drawing.Point(350, 147);
            this.btnCalculateResult.Name = "btnCalculateResult";
            this.btnCalculateResult.Size = new System.Drawing.Size(93, 23);
            this.btnCalculateResult.TabIndex = 4;
            this.btnCalculateResult.Text = "Calculate Result";
            this.btnCalculateResult.UseVisualStyleBackColor = true;
            this.btnCalculateResult.Click += new System.EventHandler(this.calculateResult_Click);
            // 
            // txtEquationSymbol
            // 
            this.txtEquationSymbol.Location = new System.Drawing.Point(387, 92);
            this.txtEquationSymbol.Name = "txtEquationSymbol";
            this.txtEquationSymbol.Size = new System.Drawing.Size(24, 20);
            this.txtEquationSymbol.TabIndex = 5;
            // 
            // lblEquationSymbol
            // 
            this.lblEquationSymbol.AutoSize = true;
            this.lblEquationSymbol.Location = new System.Drawing.Point(357, 69);
            this.lblEquationSymbol.Name = "lblEquationSymbol";
            this.lblEquationSymbol.Size = new System.Drawing.Size(86, 13);
            this.lblEquationSymbol.TabIndex = 6;
            this.lblEquationSymbol.Text = "Equation Symbol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEquationSymbol);
            this.Controls.Add(this.txtEquationSymbol);
            this.Controls.Add(this.btnCalculateResult);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Button btnCalculateResult;
        private System.Windows.Forms.TextBox txtEquationSymbol;
        private System.Windows.Forms.Label equationSymbol;
        private System.Windows.Forms.Label lblEquationSymbol;
    }
}

