namespace CinemaBooking
{
    partial class Register
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
            this.OK_btn = new System.Windows.Forms.Button();
            this.Nimi_txb = new System.Windows.Forms.TextBox();
            this.Email_txb = new System.Windows.Forms.TextBox();
            this.Nimi_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Parool_txt = new System.Windows.Forms.Label();
            this.Paool_txb = new System.Windows.Forms.TextBox();
            this.KordaParooli_txt = new System.Windows.Forms.Label();
            this.KordaParooli_txb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OK_btn.Location = new System.Drawing.Point(209, 291);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(153, 33);
            this.OK_btn.TabIndex = 0;
            this.OK_btn.Text = "Ok";
            this.OK_btn.UseVisualStyleBackColor = false;
            // 
            // Nimi_txb
            // 
            this.Nimi_txb.Location = new System.Drawing.Point(200, 87);
            this.Nimi_txb.Name = "Nimi_txb";
            this.Nimi_txb.Size = new System.Drawing.Size(153, 20);
            this.Nimi_txb.TabIndex = 1;
            // 
            // Email_txb
            // 
            this.Email_txb.Location = new System.Drawing.Point(200, 146);
            this.Email_txb.Name = "Email_txb";
            this.Email_txb.Size = new System.Drawing.Size(153, 20);
            this.Email_txb.TabIndex = 2;
            // 
            // Nimi_lbl
            // 
            this.Nimi_lbl.AutoSize = true;
            this.Nimi_lbl.Location = new System.Drawing.Point(200, 68);
            this.Nimi_lbl.Name = "Nimi_lbl";
            this.Nimi_lbl.Size = new System.Drawing.Size(27, 13);
            this.Nimi_lbl.TabIndex = 3;
            this.Nimi_lbl.Text = "Nimi";
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Location = new System.Drawing.Point(200, 130);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(32, 13);
            this.Email_lbl.TabIndex = 4;
            this.Email_lbl.Text = "Email";
            // 
            // Parool_txt
            // 
            this.Parool_txt.AutoSize = true;
            this.Parool_txt.Location = new System.Drawing.Point(206, 186);
            this.Parool_txt.Name = "Parool_txt";
            this.Parool_txt.Size = new System.Drawing.Size(37, 13);
            this.Parool_txt.TabIndex = 6;
            this.Parool_txt.Text = "Parool";
            // 
            // Paool_txb
            // 
            this.Paool_txb.Location = new System.Drawing.Point(206, 202);
            this.Paool_txb.Name = "Paool_txb";
            this.Paool_txb.Size = new System.Drawing.Size(153, 20);
            this.Paool_txb.TabIndex = 5;
            // 
            // KordaParooli_txt
            // 
            this.KordaParooli_txt.AutoSize = true;
            this.KordaParooli_txt.Location = new System.Drawing.Point(209, 238);
            this.KordaParooli_txt.Name = "KordaParooli_txt";
            this.KordaParooli_txt.Size = new System.Drawing.Size(69, 13);
            this.KordaParooli_txt.TabIndex = 8;
            this.KordaParooli_txt.Text = "Korda parooli";
            // 
            // KordaParooli_txb
            // 
            this.KordaParooli_txb.Location = new System.Drawing.Point(209, 254);
            this.KordaParooli_txb.Name = "KordaParooli_txb";
            this.KordaParooli_txb.Size = new System.Drawing.Size(153, 20);
            this.KordaParooli_txb.TabIndex = 7;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 404);
            this.Controls.Add(this.KordaParooli_txt);
            this.Controls.Add(this.KordaParooli_txb);
            this.Controls.Add(this.Parool_txt);
            this.Controls.Add(this.Paool_txb);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.Nimi_lbl);
            this.Controls.Add(this.Email_txb);
            this.Controls.Add(this.Nimi_txb);
            this.Controls.Add(this.OK_btn);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.TextBox Nimi_txb;
        private System.Windows.Forms.TextBox Email_txb;
        private System.Windows.Forms.Label Nimi_lbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.Label Parool_txt;
        private System.Windows.Forms.TextBox Paool_txb;
        private System.Windows.Forms.Label KordaParooli_txt;
        private System.Windows.Forms.TextBox KordaParooli_txb;
    }
}