namespace CinemaBooking
{
    partial class SignUp
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
            this.Nimi_lbl = new System.Windows.Forms.Label();
            this.Nimi_txb = new System.Windows.Forms.TextBox();
            this.Parool_txt = new System.Windows.Forms.Label();
            this.Paool_txb = new System.Windows.Forms.TextBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nimi_lbl
            // 
            this.Nimi_lbl.AutoSize = true;
            this.Nimi_lbl.Location = new System.Drawing.Point(140, 102);
            this.Nimi_lbl.Name = "Nimi_lbl";
            this.Nimi_lbl.Size = new System.Drawing.Size(27, 13);
            this.Nimi_lbl.TabIndex = 4;
            this.Nimi_lbl.Text = "Nimi";
            // 
            // Nimi_txb
            // 
            this.Nimi_txb.Location = new System.Drawing.Point(143, 138);
            this.Nimi_txb.Name = "Nimi_txb";
            this.Nimi_txb.Size = new System.Drawing.Size(153, 20);
            this.Nimi_txb.TabIndex = 5;
            // 
            // Parool_txt
            // 
            this.Parool_txt.AutoSize = true;
            this.Parool_txt.Location = new System.Drawing.Point(140, 177);
            this.Parool_txt.Name = "Parool_txt";
            this.Parool_txt.Size = new System.Drawing.Size(37, 13);
            this.Parool_txt.TabIndex = 7;
            this.Parool_txt.Text = "Parool";
            // 
            // Paool_txb
            // 
            this.Paool_txb.Location = new System.Drawing.Point(143, 203);
            this.Paool_txb.Name = "Paool_txb";
            this.Paool_txb.Size = new System.Drawing.Size(153, 20);
            this.Paool_txb.TabIndex = 8;
            // 
            // OK_btn
            // 
            this.OK_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OK_btn.Location = new System.Drawing.Point(143, 250);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(153, 33);
            this.OK_btn.TabIndex = 9;
            this.OK_btn.Text = "Ok";
            this.OK_btn.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(451, 386);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Paool_txb);
            this.Controls.Add(this.Parool_txt);
            this.Controls.Add(this.Nimi_txb);
            this.Controls.Add(this.Nimi_lbl);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nimi_lbl;
        private System.Windows.Forms.TextBox Nimi_txb;
        private System.Windows.Forms.Label Parool_txt;
        private System.Windows.Forms.TextBox Paool_txb;
        private System.Windows.Forms.Button OK_btn;
    }
}