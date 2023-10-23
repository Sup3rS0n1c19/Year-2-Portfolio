namespace VM
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnBuyItem = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(349, 309);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(108, 20);
            this.txtItem.TabIndex = 0;
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Location = new System.Drawing.Point(252, 359);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(83, 23);
            this.btnCheckStock.TabIndex = 1;
            this.btnCheckStock.Text = "Check Stock";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(471, 359);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(75, 23);
            this.btnAddStock.TabIndex = 2;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnBuyItem
            // 
            this.btnBuyItem.Location = new System.Drawing.Point(367, 359);
            this.btnBuyItem.Name = "btnBuyItem";
            this.btnBuyItem.Size = new System.Drawing.Size(75, 23);
            this.btnBuyItem.TabIndex = 4;
            this.btnBuyItem.Text = "Buy Item";
            this.btnBuyItem.UseVisualStyleBackColor = true;
            this.btnBuyItem.Click += new System.EventHandler(this.btnBuyItem_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(377, 293);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(55, 13);
            this.lblItem.TabIndex = 5;
            this.lblItem.Text = "Enter Item";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnBuyItem);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.txtItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnBuyItem;
        private System.Windows.Forms.Label lblItem;
    }
}

