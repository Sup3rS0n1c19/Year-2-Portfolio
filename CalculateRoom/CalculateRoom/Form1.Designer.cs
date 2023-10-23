namespace CalculateRoom
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
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.txtRoomLength = new System.Windows.Forms.TextBox();
            this.txtRoomWidth = new System.Windows.Forms.TextBox();
            this.txtRoomArea = new System.Windows.Forms.TextBox();
            this.lblRoomWidth = new System.Windows.Forms.Label();
            this.lblRoomLength = new System.Windows.Forms.Label();
            this.lblRoomArea = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtRoomHeight = new System.Windows.Forms.TextBox();
            this.btnCalculateVolume = new System.Windows.Forms.Button();
            this.txtRoomVolume = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblRoomHeight = new System.Windows.Forms.Label();
            this.lblRoomVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(12, 228);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(174, 22);
            this.btnCalculateArea.TabIndex = 0;
            this.btnCalculateArea.Text = "Calcuate Ze Room Area";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRoomLength
            // 
            this.txtRoomLength.Location = new System.Drawing.Point(12, 18);
            this.txtRoomLength.Multiline = true;
            this.txtRoomLength.Name = "txtRoomLength";
            this.txtRoomLength.Size = new System.Drawing.Size(174, 39);
            this.txtRoomLength.TabIndex = 1;
            // 
            // txtRoomWidth
            // 
            this.txtRoomWidth.Location = new System.Drawing.Point(12, 89);
            this.txtRoomWidth.Multiline = true;
            this.txtRoomWidth.Name = "txtRoomWidth";
            this.txtRoomWidth.Size = new System.Drawing.Size(174, 40);
            this.txtRoomWidth.TabIndex = 2;
            // 
            // txtRoomArea
            // 
            this.txtRoomArea.Location = new System.Drawing.Point(12, 349);
            this.txtRoomArea.Multiline = true;
            this.txtRoomArea.Name = "txtRoomArea";
            this.txtRoomArea.Size = new System.Drawing.Size(174, 50);
            this.txtRoomArea.TabIndex = 3;
            // 
            // lblRoomWidth
            // 
            this.lblRoomWidth.AutoSize = true;
            this.lblRoomWidth.Location = new System.Drawing.Point(192, 102);
            this.lblRoomWidth.Name = "lblRoomWidth";
            this.lblRoomWidth.Size = new System.Drawing.Size(86, 13);
            this.lblRoomWidth.TabIndex = 4;
            this.lblRoomWidth.Text = "Enter room width";
            this.lblRoomWidth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRoomLength
            // 
            this.lblRoomLength.AutoSize = true;
            this.lblRoomLength.Location = new System.Drawing.Point(192, 31);
            this.lblRoomLength.Name = "lblRoomLength";
            this.lblRoomLength.Size = new System.Drawing.Size(90, 13);
            this.lblRoomLength.TabIndex = 5;
            this.lblRoomLength.Text = "Enter room length";
            // 
            // lblRoomArea
            // 
            this.lblRoomArea.AutoSize = true;
            this.lblRoomArea.Location = new System.Drawing.Point(192, 371);
            this.lblRoomArea.Name = "lblRoomArea";
            this.lblRoomArea.Size = new System.Drawing.Size(76, 13);
            this.lblRoomArea.TabIndex = 6;
            this.lblRoomArea.Text = "Ze Room Area";
            this.lblRoomArea.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(421, 90);
            this.txtWidth.Multiline = true;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(174, 39);
            this.txtWidth.TabIndex = 7;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(421, 17);
            this.txtLength.Multiline = true;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(174, 40);
            this.txtLength.TabIndex = 8;
            // 
            // txtRoomHeight
            // 
            this.txtRoomHeight.Location = new System.Drawing.Point(421, 171);
            this.txtRoomHeight.Multiline = true;
            this.txtRoomHeight.Name = "txtRoomHeight";
            this.txtRoomHeight.Size = new System.Drawing.Size(174, 40);
            this.txtRoomHeight.TabIndex = 9;
            // 
            // btnCalculateVolume
            // 
            this.btnCalculateVolume.Location = new System.Drawing.Point(421, 269);
            this.btnCalculateVolume.Name = "btnCalculateVolume";
            this.btnCalculateVolume.Size = new System.Drawing.Size(174, 22);
            this.btnCalculateVolume.TabIndex = 10;
            this.btnCalculateVolume.Text = "Calcuate Ze Room Volume";
            this.btnCalculateVolume.UseVisualStyleBackColor = true;
            this.btnCalculateVolume.Click += new System.EventHandler(this.btnCalculateVolume_Click);
            // 
            // txtRoomVolume
            // 
            this.txtRoomVolume.Location = new System.Drawing.Point(421, 349);
            this.txtRoomVolume.Multiline = true;
            this.txtRoomVolume.Name = "txtRoomVolume";
            this.txtRoomVolume.Size = new System.Drawing.Size(174, 50);
            this.txtRoomVolume.TabIndex = 11;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(601, 31);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(90, 13);
            this.lblLength.TabIndex = 12;
            this.lblLength.Text = "Enter room length";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(601, 102);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(86, 13);
            this.lblWidth.TabIndex = 13;
            this.lblWidth.Text = "Enter room width";
            // 
            // lblRoomHeight
            // 
            this.lblRoomHeight.AutoSize = true;
            this.lblRoomHeight.Location = new System.Drawing.Point(601, 186);
            this.lblRoomHeight.Name = "lblRoomHeight";
            this.lblRoomHeight.Size = new System.Drawing.Size(90, 13);
            this.lblRoomHeight.TabIndex = 14;
            this.lblRoomHeight.Text = "Enter room height";
            // 
            // lblRoomVolume
            // 
            this.lblRoomVolume.AutoSize = true;
            this.lblRoomVolume.Location = new System.Drawing.Point(597, 371);
            this.lblRoomVolume.Name = "lblRoomVolume";
            this.lblRoomVolume.Size = new System.Drawing.Size(89, 13);
            this.lblRoomVolume.TabIndex = 15;
            this.lblRoomVolume.Text = "Ze Room Volume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 433);
            this.Controls.Add(this.lblRoomVolume);
            this.Controls.Add(this.lblRoomHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtRoomVolume);
            this.Controls.Add(this.btnCalculateVolume);
            this.Controls.Add(this.txtRoomHeight);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblRoomArea);
            this.Controls.Add(this.lblRoomLength);
            this.Controls.Add(this.lblRoomWidth);
            this.Controls.Add(this.txtRoomArea);
            this.Controls.Add(this.txtRoomWidth);
            this.Controls.Add(this.txtRoomLength);
            this.Controls.Add(this.btnCalculateArea);
            this.Name = "Form1";
            this.Text = "Calculator v1.3.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.TextBox txtRoomLength;
        private System.Windows.Forms.TextBox txtRoomWidth;
        private System.Windows.Forms.TextBox txtRoomArea;
        private System.Windows.Forms.Label lblRoomWidth;
        private System.Windows.Forms.Label lblRoomLength;
        private System.Windows.Forms.Label lblRoomArea;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtRoomHeight;
        private System.Windows.Forms.Button btnCalculateVolume;
        private System.Windows.Forms.TextBox txtRoomVolume;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblRoomHeight;
        private System.Windows.Forms.Label lblRoomVolume;
    }
}

