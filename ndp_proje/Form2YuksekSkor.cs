using System;
using System.Windows.Forms;


namespace ndp_proje
{
    public partial class Form2YuksekSkor : Form
    {
        private Form1Oyun frm;          // form1 in nesnelerene ulaşmamızı sağlayan kurucu fonksiyon
     
        public Form2YuksekSkor(Form1Oyun form)
        {
            InitializeComponent();
            frm = form;

        }
        public void yazdir(string sure,string salise)  //Top.cs de çağrılıyor
        {

            yuksekskor.Text = sure + ":" + salise ;

        }

        private void tamam_Click(object sender, EventArgs e)
        {           
            this.Close();

            Form3Skorlar skorlar = new Form3Skorlar();
            skorlar.veriAl(isim.Text, yuksekskor.Text); //kayıt için Form3Skorlar a isim ve skoru yolluyoruz
            skorlar.ShowDialog();                       //Form3Skorlar ı göster

        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
