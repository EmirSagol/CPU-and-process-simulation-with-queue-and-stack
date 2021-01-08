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

        public class kuyruk
        {
            public int sayi;
            public int hangip;
            public kuyruk sonraki;
        }

        kuyruk p1_On = null;
        kuyruk p1_Arka = null;
        bool p1_Basladi = false;

        kuyruk p2_On = null;
        kuyruk p2_Arka = null;
        bool p2_Basladi = false;

        kuyruk p3_On = null;
        kuyruk p3_Arka = null;
        bool p3_Basladi = false;

        kuyruk cpu_On = null;
        kuyruk cpu_Arka = null;
        bool cpu_Basladi = false;

        kuyruk yigin_top = null;

        public int p1Speed;
        public int p2Speed;
        public int p3Speed;
        public int cpuspeed;

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

            if (p1Speed == 0)
            {
                timer_P1.Enabled = false;
                p1_Basladi = false;
            }

            if (p2Speed == 0)
            {
                timer_P2.Enabled = false;
                p2_Basladi = false;
            }

            if (p3Speed == 0)
            {
                timer_P3.Enabled = false;
                p3_Basladi = false;
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
                kuyruk p1kuyruk = new kuyruk();
                p1kuyruk.sayi = rnd.Next(0, 5);
                p1kuyruk.hangip = 1;

                if (p1_On == null)
                {
                    p1_On = p1_Arka = p1kuyruk;
                }
                else if (p1_On != null)
                {
                    p1_Arka.sonraki = p1kuyruk;
                    p1_Arka = p1kuyruk;
                }
            }
        }

        public void p1KuyrukGoster()
        {
            kuyruk gecici = p1_On;
            textBox_p1.Text = null;
            if (gecici == null)
            {
                return;
            }

            else
            {
                while (gecici != null)
                {
                    textBox_p1.Text += "P" + gecici.hangip + "-" + gecici.sayi + "\n ";
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
                kuyruk p2kuyruk = new kuyruk();
                p2kuyruk.sayi = rnd.Next(0, 5);
                p2kuyruk.hangip = 2;

                if (p2_On == null)
                {
                    p2_On = p2_Arka = p2kuyruk;
                }
                else if (p2_On != null)
                {
                    p2_Arka.sonraki = p2kuyruk;
                    p2_Arka = p2kuyruk;
                }
            }
        }

        public void p2KuyrukGoster()
        {
            kuyruk gecici = p2_On;
            textBox_p2.Text = null;
            if (gecici == null)
            {
                return;
            }

            else
            {
                while (gecici != null)
                {
                    textBox_p2.Text += "P" + gecici.hangip + "-" + gecici.sayi + "\n ";
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
                kuyruk p3kuyruk = new kuyruk();
                p3kuyruk.sayi = rnd.Next(0, 5);
                p3kuyruk.hangip = 3;

                if (p3_On == null)
                {
                    p3_On = p3_Arka = p3kuyruk;
                }
                else if (p3_On != null)
                {
                    p3_Arka.sonraki = p3kuyruk;
                    p3_Arka = p3kuyruk;
                }
            }
        }

        public void p3KuyrukGoster()
        {
            kuyruk gecici = p3_On;
            textBox_p3.Text = null;
            if (gecici == null)
            {
                return;
            }

            else
            {
                while (gecici != null)
                {
                    textBox_p3.Text += "P" + gecici.hangip + "-" + gecici.sayi + "\n ";
                    gecici = gecici.sonraki;
                }
            }
        }

        private void bttn_islemcibaslat_Click(object sender, EventArgs e)
        {
            timer_Islemci.Interval = 1000;
            timer_Islemci.Enabled = true;
            cpu_Basladi = true;
        }

        private void bttn_islemcidurdur_Click(object sender, EventArgs e)
        {
            timer_Islemci.Enabled = false;
            cpu_Basladi = false;
        }

        private void timer_Islemci_Tick(object sender, EventArgs e)
        {
            if (p1_On != null && p2_On != null && p3_On != null)
            {
                cpuKuyrukEkle();
            }
            
            cpuKuyrukGoster();

            if (cpuspeed != 0)
            {
                yiginaAktar();
            }
        }

        int[] processArray = new int[3];

        public void cpuKuyrukEkle()
        {
            if (p1_On != null)
            {
                processArray[0] = p1_On.sayi;
            }
            if (p2_On != null)
            {
                processArray[1] = p2_On.sayi;
            }
            if (p3_On != null)
            {
                processArray[2] = p3_On.sayi;
            }

            
            Array.Sort(processArray);

            int sıra = 2;
            for (int i = 0; i < processArray.Length; i++)
            {
                kuyruk cpukuyruk = new kuyruk();

                cpukuyruk.sayi = processArray[sıra];
                sıra--;

                if (cpu_On == null)
                {
                    cpu_On = cpu_Arka = cpukuyruk;
                }
                else if (cpu_On != null)
                {
                    cpu_Arka.sonraki = cpukuyruk;
                    cpu_Arka = cpukuyruk;
                }
            }

            sıra = 2;

            if (p1_On != null)
            {
                if (p1_On.sonraki == null)
                {
                    p1_On = null;
                }
                else
                {
                    p1_On = p1_On.sonraki;
                }
                
                p1KuyrukGoster();
            }

            if (p2_On != null)
            {
                if (p2_On.sonraki == null)
                {
                    p2_On = null;
                }
                else
                {
                    p2_On = p2_On.sonraki;
                }
               
                p2KuyrukGoster();
            }

            if (p3_On != null)
            {
                if (p3_On.sonraki == null)
                {
                    p3_On = null;
                }
                else
                {
                    p3_On = p3_On.sonraki;
                }
               
                p3KuyrukGoster();
            }
        }

        public void cpuKuyrukGoster()
        {
            kuyruk gecici = cpu_On;
            textBox_Processkuyrugu.Text = null;

            if (gecici == null)
            {
                return;
            }

            else
            {
                while (gecici != null)
                {
                    textBox_Processkuyrugu.Text += gecici.sayi + "-->";
                    gecici = gecici.sonraki;
                }
            }
        }
        public void yiginaAktar()//Kuyruk olmayacak
        {

        }
    }
}