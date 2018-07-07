using System.Drawing;

namespace ndp_proje
{
    public class Raket:Form1Oyun
    {
        private Form1Oyun frm;                  //kalıtım aldığımız Form1Oyun'daki nesneleri kurucu fonksiyon ile alıyoruz
        public Raket(Form1Oyun form)            //kurucu fonksiyon
        {
            this.frm = form;
        }

        public void Olustur()                   //raketi oluşturan fonksiyon
        {
            Bitmap resim;
            resim = new Bitmap("raket.png");
            frm.raket.Image = resim;
        }

        public void Hareket()               //raketin hareketini sağlayan fonksiyon
        {
            
            frm.raket.Top = frm.ClientSize.Height-frm.raket.Height;         //raketin konumu ekranın en altı yapıyoruz

            if (MousePosition.X > frm.Left + frm.ClientSize.Width-70)   //bu if komutlarıyla raket ekrandan cıkmıyor
            {
                frm.raket.Left = frm.ClientSize.Width - 140;
            }
            else if (MousePosition.X < frm.Left + 70)
            {
                frm.raket.Left = 0;

            }
            else //mouse oyun platformundayken raketi ortalar
            {
               frm.raket.Left = MousePosition.X - frm.Left - 70;
            }
        }
    }
}
