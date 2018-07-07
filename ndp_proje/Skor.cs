
namespace ndp_proje
{
    class Skor:Form1Oyun
    {

        private Form1Oyun frm;          // kalıtım aldıgımız Form1Oyun un nesnelerene ulaşmamızı sağlayan kurucu fonksiyon
        public Skor(Form1Oyun form)
        {
            this.frm = form;
        }


        public void Hesapla()
        {
            frm.fark = frm.son - frm.baslangic; //oyunun süresi hesaplanır
         #pragma warning disable CS1690 
            frm.dakika = frm.fark.Minutes;
            frm.saniye = frm.fark.Seconds;
            frm.salise = frm.fark.Milliseconds;

            if (frm.top_hareket.Enabled == true) //oyun alanında gösterilen skor.Text e süreyi atıyoruz
            {
                if (frm.dakika < 10)
                {
                    if (frm.saniye < 10)
                    {
                        frm.skor.Text = "0" + frm.dakika.ToString() + ":0" + frm.saniye.ToString();
                    }
                    else
                    {
                        frm.skor.Text = "0" + frm.dakika.ToString() + ":" + frm.saniye.ToString(); ;
                    }
                }
                else
                {
                    frm.skor.Text = frm.dakika.ToString() + ":0" + frm.saniye.ToString();
                }                   
            }
        }
    
    }
}
