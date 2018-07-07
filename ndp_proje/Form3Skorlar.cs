using System;
using System.Windows.Forms;


namespace ndp_proje
{
    public partial class Form3Skorlar : Form
    {
        public Form3Skorlar()
        {
            InitializeComponent();
        }
        private string ad, zaman;

        public void veriAl(string ad,string zaman) //form2 den verileri alan ve değiskenlere atayan fonksiyon
        {
           this.ad = ad;        
           this.zaman = zaman.Trim().Replace(":", string.Empty);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SkorKayit sure = new SkorKayit(this);
             //önce datagridview de görüntülenir.sonra eklenir. en küçüğü bulunup silinir ve 5 skor büyükten küçüğe sıralanır
            sure.Buyukten_Sirala();
            sure.Skor_Ekle(this.ad,this.zaman);
            sure.Kucukten_Sirala();
            sure.Satir_Sil();
            sure.Buyukten_Sirala();
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            SkorKayit sure = new SkorKayit(this);
            sure.Buyukten_Sirala();
            sure.Skor_Sifirla();
            sure.Buyukten_Sirala();
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
