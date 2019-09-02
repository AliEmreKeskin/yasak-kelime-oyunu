using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            //süre
            //
            timer1.Start();
            //
            //rastgele kart verme
            //
            Random rast = new Random();
            int sayı = rast.Next(1,201);
            string konum = "C:/Users/Emre/Tabu/El Yapımı Kelimeler/Mor/" + sayı.ToString() + ".jpg";
            pictureBox1.Image = Image.FromFile(konum);
            //
            //buttonları aktifleştirme
            //
            if (button_dA.Enabled == false)
            {
                button_dA.Enabled = true;
                button_tA.Enabled = true;
                button_dB.Enabled = false;
                button_tB.Enabled = false;

            }
            else { 
                button_dB.Enabled = true;
                button_tB.Enabled = true;
                button_dA.Enabled = false;
                button_tA.Enabled = false;
            }
            //
            //Kazanan
            //
            if (button_dA.Enabled == true) 
            {
                if (a >= 30 && b >= 30 && a == b) { MessageBox.Show("Tebrikler Berabere!"); }
                else if (a >= 30 && b >= 30 && a > b) { MessageBox.Show("Tebrikler 'A Grubu' Kazandı!"); }
                else if (a >= 30 && b >= 30 && b > a) { MessageBox.Show("Tebrikler 'B Grubu' Kazandı!"); }
                else if (a >= 30) { MessageBox.Show("Tebrikler 'A Grubu' Kazandı!"); }
                else if (b >= 30) { MessageBox.Show("Tebrikler 'B Grubu' Kazandı!"); }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //
        //değişkenler
        //
        int a = 0, b = 0,sayaç=0;
        private void button_dA_Click(object sender, EventArgs e)
        {
            //
            //rastgele kart verme
            //
            Random rast = new Random();
            int sayı = rast.Next(1, 201);
            string konum = "C:/Users/Emre/Tabu/El Yapımı Kelimeler/Mor/" + sayı.ToString() + ".jpg";
            pictureBox1.Image = Image.FromFile(konum);
            //
            //puan artırma-azaltma
            //
            a = ++a;
            label1.Text = "Puan:" + a.ToString();
        }

        private void button_tA_Click(object sender, EventArgs e)
        {
            //
            //rastgele kart verme
            //
            Random rast = new Random();
            int sayı = rast.Next(1, 201);
            string konum = "C:/Users/Emre/Tabu/El Yapımı Kelimeler/Mor/" + sayı.ToString() + ".jpg";
            pictureBox1.Image = Image.FromFile(konum);
            //
            //puan artırma-azaltma
            //
            a = --a;
            label1.Text = "Puan:" + a.ToString();
        }

        private void button_dB_Click(object sender, EventArgs e)
        {
            //
            //rastgele kart verme
            //
            Random rast = new Random();
            int sayı = rast.Next(1, 201);
            string konum = "C:/Users/Emre/Tabu/El Yapımı Kelimeler/Mor/" + sayı.ToString() + ".jpg";
            pictureBox1.Image = Image.FromFile(konum);
            //
            //puan artırma-azaltma
            //
            b = ++b;
            label2.Text = "Puan:" + b.ToString();
        }

        private void button_tB_Click(object sender, EventArgs e)
        {
            //
            //rastgele kart verme
            //
            Random rast = new Random();
            int sayı = rast.Next(1, 201);
            string konum = "C:/Users/Emre/Tabu/El Yapımı Kelimeler/Mor/" + sayı.ToString() + ".jpg";
            pictureBox1.Image = Image.FromFile(konum);
            //
            //puan artırma-azaltma
            //
            b = --b;
            label2.Text = "Puan:" + b.ToString();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/aliemre.keskin.3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Karttaki altı çizili kelime altındaki $safeprojectname$ kelimeleri kullanılmadan anlatılır. Tabu kelimesi kullanılması durumunda rakip bir oyuncu 'Tabu' butonuna tıklar. Kalime bilinmesi durumunda 'Doğru' butonuna tıklanır.");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = sayaç;
            label3.Text =sayaç.ToString();
            if (sayaç < 100) { sayaç += 1; }
            else { timer1.Stop();
            sayaç = 0;
            }
            if (sayaç == 100) { MessageBox.Show("Süre Bitti!"); }
        }
    }
}
