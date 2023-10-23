namespace ConversionCalculator
{
    partial class ConversionCalculator
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
            this.txtMetres = new System.Windows.Forms.TextBox();
            this.txtLitres = new System.Windows.Forms.TextBox();
            this.txtKilograms = new System.Windows.Forms.TextBox();
            this.btnMetreConverter = new System.Windows.Forms.Button();
            this.btnKilogramConverter = new System.Windows.Forms.Button();
            this.btnLitreConverter = new System.Windows.Forms.Button();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMetres
            // 
            this.txtMetres.Location = new System.Drawing.Point(73, 42);
            this.txtMetres.Name = "txtMetres";
            this.txtMetres.Size = new System.Drawing.Size(100, 20);
            this.txtMetres.TabIndex = 0;
            // 
            // txtLitres
            // 
            this.txtLitres.Location = new System.Drawing.Point(482, 42);
            this.txtLitres.Name = "txtLitres";
            this.txtLitres.Size = new System.Drawing.Size(109, 20);
            this.txtLitres.TabIndex = 1;
            // 
            // txtKilograms
            // 
            this.txtKilograms.Location = new System.Drawing.Point(275, 42);
            this.txtKilograms.Name = "txtKilograms";
            this.txtKilograms.Size = new System.Drawing.Size(112, 20);
            this.txtKilograms.TabIndex = 2;
            // 
            // btnMetreConverter
            // 
            this.btnMetreConverter.Location = new System.Drawing.Point(73, 101);
            this.btnMetreConverter.Name = "btnMetreConverter";
            this.btnMetreConverter.Size = new System.Drawing.Size(100, 23);
            this.btnMetreConverter.TabIndex = 3;
            this.btnMetreConverter.Text = "Convert to Feet";
            this.btnMetreConverter.UseVisualStyleBackColor = true;
            this.btnMetreConverter.Click += new System.EventHandler(this.btnMetreConverter_Click);
            // 
            // btnKilogramConverter
            // 
            this.btnKilogramConverter.Location = new System.Drawing.Point(275, 101);
            this.btnKilogramConverter.Name = "btnKilogramConverter";
            this.btnKilogramConverter.Size = new System.Drawing.Size(112, 23);
            this.btnKilogramConverter.TabIndex = 4;
            this.btnKilogramConverter.Text = "Convert to Pounds";
            this.btnKilogramConverter.UseVisualStyleBackColor = true;
            this.btnKilogramConverter.Click += new System.EventHandler(this.btnKilogramConverter_Click);
            // 
            // btnLitreConverter
            // 
            this.btnLitreConverter.Location = new System.Drawing.Point(482, 101);
            this.btnLitreConverter.Name = "btnLitreConverter";
            this.btnLitreConverter.Size = new System.Drawing.Size(109, 23);
            this.btnLitreConverter.TabIndex = 5;
            this.btnLitreConverter.Text = "Convert to Gallons";
            this.btnLitreConverter.UseVisualStyleBackColor = true;
            this.btnLitreConverter.Click += new System.EventHandler(this.btnLitreConverter_Click);
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(73, 163);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(100, 20);
            this.txtFeet.TabIndex = 6;
            // 
            // txtPounds
            // 
            this.txtPounds.Location = new System.Drawing.Point(275, 163);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(112, 20);
            this.txtPounds.TabIndex = 7;
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(482, 163);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(109, 20);
            this.txtGallons.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter in Metres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter in Kilograms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter in Litres";
            // 
            // ConversionCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtPounds);
            this.Controls.Add(this.txtFeet);
            this.Controls.Add(this.btnLitreConverter);
            this.Controls.Add(this.btnKilogramConverter);
            this.Controls.Add(this.btnMetreConverter);
            this.Controls.Add(this.txtKilograms);
            this.Controls.Add(this.txtLitres);
            this.Controls.Add(this.txtMetres);
            this.Name = "ConversionCalculator";
            this.Text = "ConversionCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetres;
        private System.Windows.Forms.TextBox txtLitres;
        private System.Windows.Forms.TextBox txtKilograms;
        private System.Windows.Forms.Button btnMetreConverter;
        private System.Windows.Forms.Button btnKilogramConverter;
        private System.Windows.Forms.Button btnLitreConverter;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

