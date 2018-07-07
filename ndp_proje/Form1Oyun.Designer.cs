namespace ndp_proje
{
    partial class Form1Oyun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Oyun));
            this.top_hareket = new System.Windows.Forms.Timer(this.components);
            this.yenioyunyazi = new System.Windows.Forms.Label();
            this.skor = new System.Windows.Forms.Label();
            this.skorlar = new System.Windows.Forms.Button();
            this.raket = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hizAyari = new System.Windows.Forms.GroupBox();
            this.hizHayir = new System.Windows.Forms.RadioButton();
            this.hizEvet = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.hizAyari.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_hareket
            // 
            this.top_hareket.Interval = 1;
            this.top_hareket.Tick += new System.EventHandler(this.top_Tick);
            // 
            // yenioyunyazi
            // 
            this.yenioyunyazi.AutoSize = true;
            this.yenioyunyazi.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yenioyunyazi.ForeColor = System.Drawing.Color.Aqua;
            this.yenioyunyazi.Location = new System.Drawing.Point(481, 28);
            this.yenioyunyazi.Name = "yenioyunyazi";
            this.yenioyunyazi.Size = new System.Drawing.Size(300, 19);
            this.yenioyunyazi.TabIndex = 9;
            this.yenioyunyazi.Text = "Yeni oyun için ekrana tıklayınız...";
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.Font = new System.Drawing.Font("Myriad Pro", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skor.ForeColor = System.Drawing.Color.Teal;
            this.skor.Location = new System.Drawing.Point(12, 9);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(0, 43);
            this.skor.TabIndex = 11;
            // 
            // skorlar
            // 
            this.skorlar.BackColor = System.Drawing.Color.Teal;
            this.skorlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skorlar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skorlar.Location = new System.Drawing.Point(195, 19);
            this.skorlar.Name = "skorlar";
            this.skorlar.Size = new System.Drawing.Size(130, 28);
            this.skorlar.TabIndex = 12;
            this.skorlar.Text = "Yüksek Skorlar";
            this.skorlar.UseVisualStyleBackColor = false;
            this.skorlar.Click += new System.EventHandler(this.skorlar_Click);
            // 
            // raket
            // 
            this.raket.Enabled = false;
            this.raket.Location = new System.Drawing.Point(315, 425);
            this.raket.Name = "raket";
            this.raket.Size = new System.Drawing.Size(140, 14);
            this.raket.TabIndex = 0;
            this.raket.TabStop = false;
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(224, 369);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(22, 20);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 7;
            this.top.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(797, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 13;
            // 
            // hizAyari
            // 
            this.hizAyari.BackColor = System.Drawing.Color.Transparent;
            this.hizAyari.Controls.Add(this.hizHayir);
            this.hizAyari.Controls.Add(this.hizEvet);
            this.hizAyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hizAyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hizAyari.Location = new System.Drawing.Point(341, 19);
            this.hizAyari.Name = "hizAyari";
            this.hizAyari.Size = new System.Drawing.Size(123, 67);
            this.hizAyari.TabIndex = 14;
            this.hizAyari.TabStop = false;
            this.hizAyari.Text = "Top hızlansın mı?";
            // 
            // hizHayir
            // 
            this.hizHayir.AutoSize = true;
            this.hizHayir.Checked = true;
            this.hizHayir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hizHayir.Location = new System.Drawing.Point(7, 44);
            this.hizHayir.Name = "hizHayir";
            this.hizHayir.Size = new System.Drawing.Size(54, 17);
            this.hizHayir.TabIndex = 1;
            this.hizHayir.TabStop = true;
            this.hizHayir.Text = "Hayır";
            this.hizHayir.UseVisualStyleBackColor = true;
            // 
            // hizEvet
            // 
            this.hizEvet.AutoSize = true;
            this.hizEvet.BackColor = System.Drawing.Color.Transparent;
            this.hizEvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hizEvet.Location = new System.Drawing.Point(7, 20);
            this.hizEvet.Name = "hizEvet";
            this.hizEvet.Size = new System.Drawing.Size(51, 17);
            this.hizEvet.TabIndex = 0;
            this.hizEvet.Text = "Evet";
            this.hizEvet.UseVisualStyleBackColor = false;
            // 
            // Form1Oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(801, 480);
            this.Controls.Add(this.hizAyari);
            this.Controls.Add(this.skorlar);
            this.Controls.Add(this.yenioyunyazi);
            this.Controls.Add(this.raket);
            this.Controls.Add(this.top);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.skor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1Oyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durmayan Top";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.raket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.hizAyari.ResumeLayout(false);
            this.hizAyari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox raket;
        public System.Windows.Forms.PictureBox top;
        public System.Windows.Forms.Timer top_hareket;
        public System.Windows.Forms.Label yenioyunyazi;
        public System.Windows.Forms.Label skor;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button skorlar;
        public System.Windows.Forms.RadioButton hizEvet;
        public System.Windows.Forms.GroupBox hizAyari;
        public System.Windows.Forms.RadioButton hizHayir;
    }
}

