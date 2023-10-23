namespace ExamGrader
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
            this.txtFirstResult = new System.Windows.Forms.TextBox();
            this.txtSecondResult = new System.Windows.Forms.TextBox();
            this.txtThirdResult = new System.Windows.Forms.TextBox();
            this.txtFourthResult = new System.Windows.Forms.TextBox();
            this.txtOverallResult = new System.Windows.Forms.TextBox();
            this.lblFirstResult = new System.Windows.Forms.Label();
            this.lblFourthResult = new System.Windows.Forms.Label();
            this.lblThirdResult = new System.Windows.Forms.Label();
            this.lblSecondResult = new System.Windows.Forms.Label();
            this.btnGradeResults = new System.Windows.Forms.Button();
            this.lblOverallResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstResult
            // 
            this.txtFirstResult.Location = new System.Drawing.Point(253, 44);
            this.txtFirstResult.Name = "txtFirstResult";
            this.txtFirstResult.Size = new System.Drawing.Size(250, 20);
            this.txtFirstResult.TabIndex = 0;
            // 
            // txtSecondResult
            // 
            this.txtSecondResult.Location = new System.Drawing.Point(253, 116);
            this.txtSecondResult.Name = "txtSecondResult";
            this.txtSecondResult.Size = new System.Drawing.Size(250, 20);
            this.txtSecondResult.TabIndex = 1;
            // 
            // txtThirdResult
            // 
            this.txtThirdResult.Location = new System.Drawing.Point(253, 199);
            this.txtThirdResult.Name = "txtThirdResult";
            this.txtThirdResult.Size = new System.Drawing.Size(250, 20);
            this.txtThirdResult.TabIndex = 2;
            // 
            // txtFourthResult
            // 
            this.txtFourthResult.Location = new System.Drawing.Point(253, 282);
            this.txtFourthResult.Name = "txtFourthResult";
            this.txtFourthResult.Size = new System.Drawing.Size(250, 20);
            this.txtFourthResult.TabIndex = 3;
            // 
            // txtOverallResult
            // 
            this.txtOverallResult.Location = new System.Drawing.Point(253, 399);
            this.txtOverallResult.Multiline = true;
            this.txtOverallResult.Name = "txtOverallResult";
            this.txtOverallResult.Size = new System.Drawing.Size(250, 39);
            this.txtOverallResult.TabIndex = 4;
            // 
            // lblFirstResult
            // 
            this.lblFirstResult.AutoSize = true;
            this.lblFirstResult.Location = new System.Drawing.Point(329, 28);
            this.lblFirstResult.Name = "lblFirstResult";
            this.lblFirstResult.Size = new System.Drawing.Size(107, 13);
            this.lblFirstResult.TabIndex = 5;
            this.lblFirstResult.Text = "Enter first exam result";
            this.lblFirstResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFourthResult
            // 
            this.lblFourthResult.AutoSize = true;
            this.lblFourthResult.Location = new System.Drawing.Point(329, 266);
            this.lblFourthResult.Name = "lblFourthResult";
            this.lblFourthResult.Size = new System.Drawing.Size(118, 13);
            this.lblFourthResult.TabIndex = 6;
            this.lblFourthResult.Text = "Enter fourth exam result";
            // 
            // lblThirdResult
            // 
            this.lblThirdResult.AutoSize = true;
            this.lblThirdResult.Location = new System.Drawing.Point(329, 183);
            this.lblThirdResult.Name = "lblThirdResult";
            this.lblThirdResult.Size = new System.Drawing.Size(111, 13);
            this.lblThirdResult.TabIndex = 7;
            this.lblThirdResult.Text = "Enter third exam result";
            this.lblThirdResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSecondResult
            // 
            this.lblSecondResult.AutoSize = true;
            this.lblSecondResult.Location = new System.Drawing.Point(329, 100);
            this.lblSecondResult.Name = "lblSecondResult";
            this.lblSecondResult.Size = new System.Drawing.Size(126, 13);
            this.lblSecondResult.TabIndex = 8;
            this.lblSecondResult.Text = "Enter second exam result";
            // 
            // btnGradeResults
            // 
            this.btnGradeResults.Location = new System.Drawing.Point(332, 341);
            this.btnGradeResults.Name = "btnGradeResults";
            this.btnGradeResults.Size = new System.Drawing.Size(90, 23);
            this.btnGradeResults.TabIndex = 9;
            this.btnGradeResults.Text = "Grade Results";
            this.btnGradeResults.UseVisualStyleBackColor = true;
            this.btnGradeResults.Click += new System.EventHandler(this.btngradeResults_Click);
            // 
            // lblOverallResult
            // 
            this.lblOverallResult.AutoSize = true;
            this.lblOverallResult.Location = new System.Drawing.Point(340, 383);
            this.lblOverallResult.Name = "lblOverallResult";
            this.lblOverallResult.Size = new System.Drawing.Size(73, 13);
            this.lblOverallResult.TabIndex = 10;
            this.lblOverallResult.Text = "Overall Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOverallResult);
            this.Controls.Add(this.btnGradeResults);
            this.Controls.Add(this.lblSecondResult);
            this.Controls.Add(this.lblThirdResult);
            this.Controls.Add(this.lblFourthResult);
            this.Controls.Add(this.lblFirstResult);
            this.Controls.Add(this.txtOverallResult);
            this.Controls.Add(this.txtFourthResult);
            this.Controls.Add(this.txtThirdResult);
            this.Controls.Add(this.txtSecondResult);
            this.Controls.Add(this.txtFirstResult);
            this.Name = "Form1";
            this.Text = "Results Grader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstResult;
        private System.Windows.Forms.TextBox txtSecondResult;
        private System.Windows.Forms.TextBox txtThirdResult;
        private System.Windows.Forms.TextBox txtFourthResult;
        private System.Windows.Forms.TextBox txtOverallResult;
        private System.Windows.Forms.Label lblFirstResult;
        private System.Windows.Forms.Label lblFourthResult;
        private System.Windows.Forms.Label lblThirdResult;
        private System.Windows.Forms.Label lblSecondResult;
        private System.Windows.Forms.Button btnGradeResults;
        private System.Windows.Forms.Label lblOverallResult;
    }
}

