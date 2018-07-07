using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;   // Access bağlantısı kurabilmek için.
using System.Media;


namespace ndp_proje
{
    class Top:Form1Oyun
    {
        SoundPlayer ses = new SoundPlayer();
        private Form1Oyun frm;          //kalıtım aldığımız Form1Oyun'daki nesneleri kurucu fonksiyon ile alıyoruz
        public Top(Form1Oyun form)       //kurucu fonksiyon
        {
            this.frm = form;
        }

        public void Olustur()   //topu oluşturan ve konumunu raketin ortası yapan fonksiyon
        {

            Bitmap top_resmi;
            top_resmi = new Bitmap("top.png");
            frm.top.Image = top_resmi;

            frm.top.Top = frm.ClientSize.Height - 32;
            frm.top.Left = frm.raket.Left +60;
            frm.yenioyunyazi.Visible = false; // oyun başladıği için yazi gorunmez oluyor
        }

        private string yeni_salise; // timespan ile hesaplanan saliseyi 3 basamak yapmak için  '001' 023' '456'
        private string sonuncu_skor,yapilan_skor;
        private int top_x,top_y,hiz;

        public void Hareket(int xhiz,int yhiz)           //topun hareketi için x ve y hizları alınır
        {
            this.top_x = frm.top.Location.X; //topun x ve y kordinatı değişkenlere atanır
            this.top_y = frm.top.Location.Y;

            this.hiz = Convert.ToInt32(frm.hizArtis); // top ondalıklı pikselde gidemeyecegi için tam sayıya çeviyoruz

            frm.top.Location = new Point(top_x + xhiz, top_y + yhiz); //topun yeni konumu

            if (top_x >= frm.ClientSize.Width - 35)  //oyun alanınım sağ sınırına geldiyse ters yön
            {
                ses.SoundLocation = "efekt.wav";
                ses.Play();
                frm.xSpeed = -hiz;
            }

            else if (top_x <= 13)                   //oyun alanınım sol sınırına geldiyse ters yön
            {
                ses.SoundLocation = "efekt.wav";
                ses.Play();
                frm.xSpeed = +hiz;
            }
           

            else if (top_y < 20)                        //oyun alanının üst sınırına geldiyse ters yön
            {
                ses.SoundLocation = "efekt.wav";
                ses.Play();
                frm.ySpeed = +hiz;                   
            }
            else if (top_y >= frm.Height - 85)      // ekranın altına geldiyse
            {
                   
                if (frm.top.Left >= frm.raket.Left - 30 && frm.top.Left <= frm.raket.Left + 120) //rakete carptıysa yukari git
                {
                    ses.SoundLocation = "efekt.wav";
                    ses.Play();

                    frm.ySpeed = -hiz;
                    if (frm.hizEvet.Checked == true)
                    {
                        frm.hizArtis = frm.hizArtis + 0.3;          //hızını arttırıyoruz (sonra int çevirip topun konumuna ekliyoruz)
                    }
                   
                }
                else //GAME OVER kısmı
                {
                    ses.SoundLocation = "bitis.wav";
                    ses.Play();

                    frm.top_hareket.Enabled = false;

                    frm.yenioyunyazi.Left = frm.Width - 340;
                    frm.yenioyunyazi.Visible = true; // yeni oyun tıklayınız yazısı
                    frm.skorlar.Visible = true;
                    frm.hizAyari.Visible = true;
                    Cursor.Show();
                    
                    frm.xSpeed = 10; // başlangıc hızlarına geri döndürüyor
                    frm.ySpeed = 10;
                    frm.hizArtis = 10;

                    if (frm.salise < 100) //saliseyi uygun görünüme getiriyoruz
                    {
                        if (frm.salise < 10)
                        {
                            yeni_salise = "00" + frm.salise;
                        }
                        else { yeni_salise = "0" + frm.salise; }
                    }

#pragma warning disable CS1690
                    else { yeni_salise = frm.salise.ToString(); }

                    
                    ///////////////////////// YÜKSEK SKOR OLUP OLMADIGINI ANLAMA KISMI
                    OleDbConnection con;
                    OleDbDataAdapter da; 
                    DataSet ds;

                    // KÜÇÜKTEN BÜYÜĞE SIRALAMA
                    frm.dataGridView1.Visible = true;

                    con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Yuksek_Skor.accdb");
                    da = new OleDbDataAdapter("Select * From Skorlar order by Sure asc", con); //küçükten büyüğe sıralama
                    ds = new DataSet();
                    con.Open();
                    da.Fill(ds, "Skorlar");  //Skorlar tablosu
                    frm.dataGridView1.DataSource = ds.Tables["Skorlar"]; //dataGridView1 de görüntüleme
                    con.Close();
                    ///

                    this.sonuncu_skor = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString(); //küçüğü ilk satırda oldu ve değişkene atadık
                    this.yapilan_skor = frm.skor.Text.Trim().Replace(":", string.Empty) + yeni_salise.ToString();


                    if (Convert.ToInt32(sonuncu_skor) <= Convert.ToInt32(yapilan_skor)) //eğer sonuncu skoru geçtiyse yüksek skordur
                    {
                        Form2YuksekSkor skorlar = new Form2YuksekSkor(this);
                        skorlar.yazdir(frm.skor.Text, yeni_salise); //Form2YuksekSkor da saniyeyi yazdır
                        skorlar.ShowDialog(); //Formlar arasında geçiş yapılmaz
                    }

                    frm.dataGridView1.Visible = false;
                    //////////////////////////
                }
            }
                   
        }   
    }
}
