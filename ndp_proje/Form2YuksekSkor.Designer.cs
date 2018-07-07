namespace ndp_proje
{
    partial class Form2YuksekSkor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2YuksekSkor));
            this.isim = new System.Windows.Forms.TextBox();
            this.iptal = new System.Windows.Forms.Button();
            this.tamam = new System.Windows.Forms.Button();
            this.yuksekskor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isim
            // 
            this.isim.BackColor = System.Drawing.Color.DodgerBlue;
            this.isim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isim.Font = new System.Drawing.Font("Turkish Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.ForeColor = System.Drawing.Color.Black;
            this.isim.Location = new System.Drawing.Point(94, 132);
            this.isim.MaxLength = 12;
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(129, 24);
            this.isim.TabIndex = 2;
            this.isim.Text = "İSİMSİZ";
            this.isim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.Teal;
            this.iptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iptal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iptal.Location = new System.Drawing.Point(94, 184);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(75, 23);
            this.iptal.TabIndex = 3;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // tamam
            // 
            this.tamam.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tamam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tamam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tamam.Location = new System.Drawing.Point(233, 184);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(75, 23);
            this.tamam.TabIndex = 4;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = false;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // yuksekskor
            // 
            this.yuksekskor.AutoSize = true;
            this.yuksekskor.BackColor = System.Drawing.Color.DodgerBlue;
            this.yuksekskor.Font = new System.Drawing.Font("Turkish Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuksekskor.ForeColor = System.Drawing.Color.Black;
            this.yuksekskor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yuksekskor.Location = new System.Drawing.Point(223, 132);
            this.yuksekskor.Name = "yuksekskor";
            this.yuksekskor.Size = new System.Drawing.Size(58, 24);
            this.yuksekskor.TabIndex = 5;
            this.yuksekskor.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ndp_proje.Properties.Resources.Form2_arka;
            this.ClientSize = new System.Drawing.Size(400, 233);
            this.Controls.Add(this.yuksekskor);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.isim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yüksek Skor ! Tebrikler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Button tamam;
        public System.Windows.Forms.Label yuksekskor;
    }
}