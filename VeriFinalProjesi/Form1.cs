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

        node p1_On;
        node p1_Arka;

        public int cpuspeed;
        public int p1Speed;
        public int p2Speed;
        public int p3Speed;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_FormGuncelle.Enabled = true;
            timer_Islemci.Enabled = true;
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
        }

        private void timer_Islemci_Tick(object sender, EventArgs e)
        {
            p1ProcessEkle();
            //p2ProcessEkle();
            //p3ProcessEkle();
        }

        public void p1ProcessEkle()
        {
            node p1kuyruk = new node();
            Random rnd = new Random();
            for (int i = 0; i < p1Speed; i++)
            {
                p1kuyruk.sayi = rnd.Next(0, 5);

                if (p1_On == null)
                {
                    p1_On = p1_Arka = p1kuyruk;
                }
                else
                {
                    p1_Arka.sonraki = p1kuyruk;
                    p1_Arka = p1kuyruk;
                }
            }
            p1KuyrukGoster();
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
                    textBox_p1.Text += "P1-" + gecici.sayi;
                    gecici = gecici.sonraki;
                }
            }
        }
    }
}