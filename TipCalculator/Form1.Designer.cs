namespace TipCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.promptTxt = new System.Windows.Forms.Label();
            this.billTxtBox = new System.Windows.Forms.TextBox();
            this.TipTxtBox = new System.Windows.Forms.TextBox();
            this.TipPrcntLabel = new System.Windows.Forms.Label();
            this.TipPrcntTxtBox = new System.Windows.Forms.TextBox();
            this.TotalAmtLabel = new System.Windows.Forms.Label();
            this.TotalAmtTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptTxt
            // 
            this.promptTxt.AutoSize = true;
            this.promptTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promptTxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.promptTxt.Location = new System.Drawing.Point(111, 37);
            this.promptTxt.Name = "promptTxt";
            this.promptTxt.Size = new System.Drawing.Size(100, 18);
            this.promptTxt.TabIndex = 0;
            this.promptTxt.Text = "Enter Total Bill";
            // 
            // billTxtBox
            // 
            this.billTxtBox.Location = new System.Drawing.Point(262, 33);
            this.billTxtBox.Name = "billTxtBox";
            this.billTxtBox.Size = new System.Drawing.Size(399, 27);
            this.billTxtBox.TabIndex = 2;
            this.billTxtBox.TextChanged += new System.EventHandler(this.billTxtBox_TextChanged);
            // 
            // TipTxtBox
            // 
            this.TipTxtBox.Location = new System.Drawing.Point(262, 252);
            this.TipTxtBox.Name = "TipTxtBox";
            this.TipTxtBox.Size = new System.Drawing.Size(133, 27);
            this.TipTxtBox.TabIndex = 3;
            // 
            // TipPrcntLabel
            // 
            this.TipPrcntLabel.AutoSize = true;
            this.TipPrcntLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TipPrcntLabel.Location = new System.Drawing.Point(111, 91);
            this.TipPrcntLabel.Name = "TipPrcntLabel";
            this.TipPrcntLabel.Size = new System.Drawing.Size(145, 20);
            this.TipPrcntLabel.TabIndex = 4;
            this.TipPrcntLabel.Text = "Enter Tip Percentage";
            // 
            // TipPrcntTxtBox
            // 
            this.TipPrcntTxtBox.Location = new System.Drawing.Point(262, 88);
            this.TipPrcntTxtBox.Name = "TipPrcntTxtBox";
            this.TipPrcntTxtBox.Size = new System.Drawing.Size(399, 27);
            this.TipPrcntTxtBox.TabIndex = 5;
            this.TipPrcntTxtBox.TextChanged += new System.EventHandler(this.TipPrcntTxtBox_TextChanged);
            // 
            // TotalAmtLabel
            // 
            this.TotalAmtLabel.AutoSize = true;
            this.TotalAmtLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmtLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TotalAmtLabel.Location = new System.Drawing.Point(111, 297);
            this.TotalAmtLabel.Name = "TotalAmtLabel";
            this.TotalAmtLabel.Size = new System.Drawing.Size(145, 24);
            this.TotalAmtLabel.TabIndex = 6;
            this.TotalAmtLabel.Text = "Total Amount";
            // 
            // TotalAmtTxtBox
            // 
            this.TotalAmtTxtBox.Location = new System.Drawing.Point(262, 294);
            this.TotalAmtTxtBox.Name = "TotalAmtTxtBox";
            this.TotalAmtTxtBox.Size = new System.Drawing.Size(133, 27);
            this.TotalAmtTxtBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(111, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tip Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalAmtTxtBox);
            this.Controls.Add(this.TotalAmtLabel);
            this.Controls.Add(this.TipPrcntTxtBox);
            this.Controls.Add(this.TipPrcntLabel);
            this.Controls.Add(this.TipTxtBox);
            this.Controls.Add(this.billTxtBox);
            this.Controls.Add(this.promptTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptTxt;
        private System.Windows.Forms.TextBox billTxtBox;
        private System.Windows.Forms.TextBox TipTxtBox;
        private System.Windows.Forms.Label TipPrcntLabel;
        private System.Windows.Forms.TextBox TipPrcntTxtBox;
        private System.Windows.Forms.Label TotalAmtLabel;
        private System.Windows.Forms.TextBox TotalAmtTxtBox;
        private System.Windows.Forms.Label label1;
    }
}

