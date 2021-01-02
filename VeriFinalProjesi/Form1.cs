using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriFinalProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class node
        {
            public int sayi;
            public node sonraki;
        }

        node p1_On = null;
        node p1_Arka = null;
        bool p1_Basladi = false;

        node p2_On = null;
        node p2_Arka = null;
        bool p2_Basladi = false;

        node p3_On = null;
        node p3_Arka = null;
        bool p3_Basladi = false;

        public int cpuspeed;
        public int p1Speed;
        public int p2Speed;
        public int p3Speed;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_FormGuncelle.Enabled = true;
        }

        private void timer_FormGuncelle_Tick(object sender, EventArgs e)
        {
            textBox_CpuSpeed.Text = trackBar_islemci.Value.ToString();
            textBox_P1Speed.Text = trackBar_p1.Value.ToString();
            textBox_P2Speed.Text = trackBar_p2.Value.ToString();
            textBox_P3Speed.Text = trackBar_p3.Value.ToString();

            cpuspeed = trackBar_islemci.Value;
            p1Speed = trackBar_p1.Value;
            p2Speed = trackBar_p2.Value;
            p3Speed = trackBar_p3.Value;

            if (p1Speed > 0 && p1_Basladi == false)
            {
                timer_P1.Interval = 1000;
                timer_P1.Enabled = true;
                p1_Basladi = true;
            }

            if (p2Speed > 0 && p2_Basladi == false)
            {
                timer_P2.Interval = 1000;
                timer_P2.Enabled = true;
                p2_Basladi = true;
            }

            if (p3Speed > 0 && p3_Basladi == false)
            {
                timer_P3.Interval = 1000;
                timer_P3.Enabled = true;
                p3_Basladi = true;
            }
        }

        private void timer_P1_Tick(object sender, EventArgs e)
        {
            p1ProcessEkle();
            p1KuyrukGoster();
        }

        public void p1ProcessEkle()
        {
            Random rnd = new Random();
            for (int i = 0; i < p1Speed; i++)
            {
                node p1kuyruk = new node();
                p1kuyruk.sayi = rnd.Next(0, 5);

                if (p1_On == null)
                {
                    p1_On = p1_Arka = p1kuyruk;
                    return;
                }

                p1_Arka.sonraki = p1kuyruk;
                p1_Arka = p1kuyruk;
            }
        }
        public void p1KuyrukGoster()
        {
            node gecici = p1_On;
            textBox_p1.Text = null;
            if (gecici == null)
            {
                return;
            }

            else
            {
                while (gecici != null)
                {
                    textBox_p1.Text += "P1-" + gecici.sayi + "\n ";
                    gecici = gecici.sonraki;
                }
            }
        }

        private void timer_P2_Tick(object sender, EventArgs e)
        {
            p2ProcessEkle();
            p2KuyrukGoster();
        }

        public void p2ProcessEkle()
        {
            Random rnd = new Random();
            for (int i = 0; i < p2Speed; i++)
            {
                node p2kuyruk = new node();
                p2kuyruk.sayi = rnd.Next(0, 5);

                if (p2_On == null)
                {
                    p2_On = p2_Arka = p2kuyruk;
                    return;
                }

                p2_Arka.sonraki = p2kuyruk;
                p2_Arka = p2kuyruk;
            }
        }
        public void p2KuyrukGoster()
        {
            node gecici = p2_On;
            textBox_p2.Text = null;
            if (gecici == null)
            {
                return;
            }

            else
            {
                while (gecici != null)
                {
                    textBox_p2.Text += "P2-" + gecici.sayi + "\n ";
                    gecici = gecici.sonraki;
                }
            }
        }

        private void timer_P3_Tick(object sender, EventArgs e)
        {
            p3ProcessEkle();
            p3KuyrukGoster();
        }

        public void p3ProcessEkle()
        {
            Random rnd = new Random();
            for (int i = 0; i < p3Speed; i++)
            {
                node p3kuyruk = new node();
                p3kuyruk.sayi = rnd.Next(0, 5);

                if (p3_On == null)
                {
                    p3_On = p3_Arka = p3kuyruk;
                    return;
                }

                p3_Arka.sonraki = p3kuyruk;
                p3_Arka = p3kuyruk;
            }
        }
        public void p3KuyrukGoster()
        {
            node gecici = p3_On;
            textBox_p3.Text = null;
            if (gecici == null)
            {
                return;
            }

            else
            {
                while (gecici != null)
                {
                    textBox_p3.Text += "P3-" + gecici.sayi + "\n ";
                    gecici = gecici.sonraki;
                }
            }
        }
    }
}