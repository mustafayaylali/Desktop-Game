using System.Data;
using System.Data.OleDb;   // Access bağlantısı kurabilmek için.

namespace ndp_proje
{
    class SkorKayit:Form3Skorlar
    {
        private Form3Skorlar frm;          // kalıtım aldıgımız Form3Skorlar ın nesnelerene ulaşmamızı sağlayan kurucu fonksiyon
        public SkorKayit(Form3Skorlar form)
        {
            this.frm = form;
        }

        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        public void Skor_Sifirla()
        {
            
            // önce tüm veriler silincek sonra defaultlar yazılcak
            
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "DELETE from Skorlar";
            cmd.ExecuteNonQuery();
            con.Close();
           
            
            for (int i = 5; i > 0; i--) //VARSAYILAN DEĞERLERİ ATIYOR BAŞLANGIC
                {
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into Skorlar (Ad,Sure) values ('İSİMSİZ-"+(i)+"','0000000')";
                    cmd.ExecuteNonQuery(); //Yazdığımız Sorguyu Çalıştırır İşleve Sokar
                    con.Close();
                }
             
        }

        public void Skor_Ekle(string Ad,string Skor) //veritabanına isimi ve skoru kaydeder
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            
            cmd.CommandText = "insert into Skorlar (Ad,Sure) values ('" + Ad + "','" + Skor + "')";

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Kucukten_Sirala()  // SÜRELERE GORE SIRALIYOR küçükten küçüge
        {

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Yuksek_Skor.accdb");
            da = new OleDbDataAdapter("Select * From Skorlar order by Sure asc", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Skorlar");
            frm.Skorlar_vt.DataSource = ds.Tables["Skorlar"]; // Skorlar_vt =datagriview
            con.Close();

        }

        public void Satir_Sil()  // EN BAŞTAKİ EN KÜÇÜK SATIRI SİLİYOR (Küçükten büyüğe sıraladıktan sonra Çağrılıyor)
        {
            string sonuncu_isim = frm.Skorlar_vt.CurrentRow.Cells[0].Value.ToString();
            string sonuncu_skor= frm.Skorlar_vt.CurrentRow.Cells[1].Value.ToString();

            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;


            cmd.CommandText = "DELETE from Skorlar where Ad='" + sonuncu_isim + "' AND Sure='"+sonuncu_skor+"'";

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Buyukten_Sirala()   // SÜRELERE GORE SIRALIYOR büyükten küçüge
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Yuksek_Skor.accdb");
            da = new OleDbDataAdapter("Select * From Skorlar order by Sure desc", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Skorlar");
            frm.Skorlar_vt.DataSource = ds.Tables["Skorlar"];
            con.Close();
  
        }
    }
}
