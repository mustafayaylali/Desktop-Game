using System;
using System.Windows.Forms;

namespace ndp_proje
{
    public partial class Form1Oyun : Form
    {
        public int xSpeed = 10; //topun hızı belirleniyor
        public int ySpeed = -10;

        public double hizArtis = 10; //topun yeni hizi bu değişkende tutulur

        public DateTime baslangic,son; //oyun basladıgında ve bittigindeki zamanaları alıp
        public TimeSpan fark;           // timespan ile oyun süresini hesaplıyoruz
        public int dakika, saniye,salise;

        public Form1Oyun()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

            Raket raket = new Raket(this); //raket oluşturuluyor
            raket.Olustur();
            skor.Text = "00:00";

            Form2YuksekSkor f = new Form2YuksekSkor(this);  // Form2'ye Form1 in nesneleri kurucu fonksiyon ile gönderiliyor
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Raket raket = new Raket(this);   //raketin hareketi aktif oluyor
            raket.Hareket();

            yenioyunyazi.Left = Width - 340; // Bilgi yazısının konumu belirleniyor     
        }

        private void skorlar_Click(object sender, EventArgs e)
        {
            Form3Skorlar skorlar = new Form3Skorlar();  //Form3Skorlar gösteriliyor
            skorlar.ShowDialog();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (yenioyunyazi.Visible == true) //oyun başlamamış ise başlat. (Oyun oynanırken ekrana tıklansada bir şey olmuyor)
            {
                Top top = new Top(this);  
                top.Olustur();               //fareyi tıkladığımızda top olusturuluyor

                top_hareket.Enabled = true;  //top hareket Timer ı aktif oluyor

                baslangic = DateTime.Now;   //oyunun başlangıc zamanını alıyoruz
                skorlar.Visible = false;
                hizAyari.Visible = false;
                Cursor.Hide();
            }

        }
        private void top_Tick(object sender, EventArgs e) //TİMER
        {
            Top top = new Top(this);
            top.Hareket(xSpeed,ySpeed);        //top hareket ediyor

            son = DateTime.Now;                 //OYUN ANINDAKİ SÜREYİ TUTMASI VE HESAPLAMASI
            Skor s = new Skor(this);
            s.Hesapla();

            
        }

       

       
    }
}
