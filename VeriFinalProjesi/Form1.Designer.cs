
namespace VeriFinalProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Processkuyrugu = new System.Windows.Forms.TextBox();
            this.bttn_islemcibaslat = new System.Windows.Forms.Button();
            this.bttn_islemcidurdur = new System.Windows.Forms.Button();
            this.textBox_p1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_p2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_p3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_P3Speed = new System.Windows.Forms.TextBox();
            this.textBox_P2Speed = new System.Windows.Forms.TextBox();
            this.textBox_P1Speed = new System.Windows.Forms.TextBox();
            this.textBox_CpuSpeed = new System.Windows.Forms.TextBox();
            this.trackBar_p3 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar_p2 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar_p1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_islemci = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Processliste = new System.Windows.Forms.TextBox();
            this.bttn_processlistele = new System.Windows.Forms.Button();
            this.checkBox_p3 = new System.Windows.Forms.CheckBox();
            this.checkBox_p2 = new System.Windows.Forms.CheckBox();
            this.checkBox_p1 = new System.Windows.Forms.CheckBox();
            this.timer_Islemci = new System.Windows.Forms.Timer(this.components);
            this.timer_FormGuncelle = new System.Windows.Forms.Timer(this.components);
            this.timer_P1 = new System.Windows.Forms.Timer(this.components);
            this.timer_P2 = new System.Windows.Forms.Timer(this.components);
            this.timer_P3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_islemci)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process kuyruğu";
            // 
            // textBox_Processkuyrugu
            // 
            this.textBox_Processkuyrugu.Location = new System.Drawing.Point(54, 65);
            this.textBox_Processkuyrugu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Processkuyrugu.Multiline = true;
            this.textBox_Processkuyrugu.Name = "textBox_Processkuyrugu";
            this.textBox_Processkuyrugu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Processkuyrugu.Size = new System.Drawing.Size(441, 53);
            this.textBox_Processkuyrugu.TabIndex = 1;
            // 
            // bttn_islemcibaslat
            // 
            this.bttn_islemcibaslat.Location = new System.Drawing.Point(520, 42);
            this.bttn_islemcibaslat.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_islemcibaslat.Name = "bttn_islemcibaslat";
            this.bttn_islemcibaslat.Size = new System.Drawing.Size(144, 46);
            this.bttn_islemcibaslat.TabIndex = 2;
            this.bttn_islemcibaslat.Text = "İşlemci Başlat";
            this.bttn_islemcibaslat.UseVisualStyleBackColor = true;
            this.bttn_islemcibaslat.Click += new System.EventHandler(this.bttn_islemcibaslat_Click);
            // 
            // bttn_islemcidurdur
            // 
            this.bttn_islemcidurdur.Location = new System.Drawing.Point(520, 108);
            this.bttn_islemcidurdur.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_islemcidurdur.Name = "bttn_islemcidurdur";
            this.bttn_islemcidurdur.Size = new System.Drawing.Size(144, 46);
            this.bttn_islemcidurdur.TabIndex = 3;
            this.bttn_islemcidurdur.Text = "İşlemci Durdur";
            this.bttn_islemcidurdur.UseVisualStyleBackColor = true;
            this.bttn_islemcidurdur.Click += new System.EventHandler(this.bttn_islemcidurdur_Click);
            // 
            // textBox_p1
            // 
            this.textBox_p1.BackColor = System.Drawing.Color.OldLace;
            this.textBox_p1.Location = new System.Drawing.Point(54, 157);
            this.textBox_p1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_p1.Multiline = true;
            this.textBox_p1.Name = "textBox_p1";
            this.textBox_p1.Size = new System.Drawing.Size(60, 240);
            this.textBox_p1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 403);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Process 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "İşlemci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 403);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Process 2";
            // 
            // textBox_p2
            // 
            this.textBox_p2.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox_p2.Location = new System.Drawing.Point(158, 157);
            this.textBox_p2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_p2.Multiline = true;
            this.textBox_p2.Name = "textBox_p2";
            this.textBox_p2.Size = new System.Drawing.Size(60, 240);
            this.textBox_p2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 403);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Process 3";
            // 
            // textBox_p3
            // 
            this.textBox_p3.BackColor = System.Drawing.Color.Bisque;
            this.textBox_p3.Location = new System.Drawing.Point(263, 157);
            this.textBox_p3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_p3.Multiline = true;
            this.textBox_p3.Name = "textBox_p3";
            this.textBox_p3.Size = new System.Drawing.Size(60, 240);
            this.textBox_p3.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.textBox_P3Speed);
            this.groupBox1.Controls.Add(this.textBox_P2Speed);
            this.groupBox1.Controls.Add(this.textBox_P1Speed);
            this.groupBox1.Controls.Add(this.textBox_CpuSpeed);
            this.groupBox1.Controls.Add(this.trackBar_p3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trackBar_p2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.trackBar_p1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackBar_islemci);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 168);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hız ayarları ( 1 saniyede yapılan işlem sayısı)";
            // 
            // textBox_P3Speed
            // 
            this.textBox_P3Speed.Location = new System.Drawing.Point(824, 115);
            this.textBox_P3Speed.Name = "textBox_P3Speed";
            this.textBox_P3Speed.ReadOnly = true;
            this.textBox_P3Speed.Size = new System.Drawing.Size(30, 24);
            this.textBox_P3Speed.TabIndex = 18;
            // 
            // textBox_P2Speed
            // 
            this.textBox_P2Speed.Location = new System.Drawing.Point(577, 115);
            this.textBox_P2Speed.Name = "textBox_P2Speed";
            this.textBox_P2Speed.ReadOnly = true;
            this.textBox_P2Speed.Size = new System.Drawing.Size(30, 24);
            this.textBox_P2Speed.TabIndex = 17;
            // 
            // textBox_P1Speed
            // 
            this.textBox_P1Speed.Location = new System.Drawing.Point(355, 115);
            this.textBox_P1Speed.Name = "textBox_P1Speed";
            this.textBox_P1Speed.ReadOnly = true;
            this.textBox_P1Speed.Size = new System.Drawing.Size(30, 24);
            this.textBox_P1Speed.TabIndex = 16;
            // 
            // textBox_CpuSpeed
            // 
            this.textBox_CpuSpeed.Location = new System.Drawing.Point(120, 115);
            this.textBox_CpuSpeed.Name = "textBox_CpuSpeed";
            this.textBox_CpuSpeed.ReadOnly = true;
            this.textBox_CpuSpeed.Size = new System.Drawing.Size(30, 24);
            this.textBox_CpuSpeed.TabIndex = 15;
            // 
            // trackBar_p3
            // 
            this.trackBar_p3.Location = new System.Drawing.Point(759, 79);
            this.trackBar_p3.Name = "trackBar_p3";
            this.trackBar_p3.Size = new System.Drawing.Size(167, 45);
            this.trackBar_p3.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(806, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Process 3";
            // 
            // trackBar_p2
            // 
            this.trackBar_p2.Location = new System.Drawing.Point(513, 79);
            this.trackBar_p2.Name = "trackBar_p2";
            this.trackBar_p2.Size = new System.Drawing.Size(167, 45);
            this.trackBar_p2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Process 2";
            // 
            // trackBar_p1
            // 
            this.trackBar_p1.Location = new System.Drawing.Point(285, 79);
            this.trackBar_p1.Name = "trackBar_p1";
            this.trackBar_p1.Size = new System.Drawing.Size(167, 45);
            this.trackBar_p1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Process 1";
            // 
            // trackBar_islemci
            // 
            this.trackBar_islemci.Location = new System.Drawing.Point(54, 79);
            this.trackBar_islemci.Name = "trackBar_islemci";
            this.trackBar_islemci.Size = new System.Drawing.Size(167, 45);
            this.trackBar_islemci.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Processliste);
            this.groupBox2.Controls.Add(this.bttn_processlistele);
            this.groupBox2.Controls.Add(this.checkBox_p3);
            this.groupBox2.Controls.Add(this.checkBox_p2);
            this.groupBox2.Controls.Add(this.checkBox_p1);
            this.groupBox2.Location = new System.Drawing.Point(687, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 390);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // textBox_Processliste
            // 
            this.textBox_Processliste.Location = new System.Drawing.Point(7, 93);
            this.textBox_Processliste.Multiline = true;
            this.textBox_Processliste.Name = "textBox_Processliste";
            this.textBox_Processliste.Size = new System.Drawing.Size(308, 291);
            this.textBox_Processliste.TabIndex = 4;
            // 
            // bttn_processlistele
            // 
            this.bttn_processlistele.Location = new System.Drawing.Point(6, 52);
            this.bttn_processlistele.Name = "bttn_processlistele";
            this.bttn_processlistele.Size = new System.Drawing.Size(309, 35);
            this.bttn_processlistele.TabIndex = 3;
            this.bttn_processlistele.Text = "Bitirilen process\'leri göster";
            this.bttn_processlistele.UseVisualStyleBackColor = true;
            // 
            // checkBox_p3
            // 
            this.checkBox_p3.AutoSize = true;
            this.checkBox_p3.Location = new System.Drawing.Point(221, 24);
            this.checkBox_p3.Name = "checkBox_p3";
            this.checkBox_p3.Size = new System.Drawing.Size(95, 22);
            this.checkBox_p3.TabIndex = 2;
            this.checkBox_p3.Text = "Process 3";
            this.checkBox_p3.UseVisualStyleBackColor = true;
            // 
            // checkBox_p2
            // 
            this.checkBox_p2.AutoSize = true;
            this.checkBox_p2.Location = new System.Drawing.Point(114, 24);
            this.checkBox_p2.Name = "checkBox_p2";
            this.checkBox_p2.Size = new System.Drawing.Size(95, 22);
            this.checkBox_p2.TabIndex = 1;
            this.checkBox_p2.Text = "Process 2";
            this.checkBox_p2.UseVisualStyleBackColor = true;
            // 
            // checkBox_p1
            // 
            this.checkBox_p1.AutoSize = true;
            this.checkBox_p1.Location = new System.Drawing.Point(7, 24);
            this.checkBox_p1.Name = "checkBox_p1";
            this.checkBox_p1.Size = new System.Drawing.Size(95, 22);
            this.checkBox_p1.TabIndex = 0;
            this.checkBox_p1.Text = "Process 1";
            this.checkBox_p1.UseVisualStyleBackColor = true;
            // 
            // timer_Islemci
            // 
            this.timer_Islemci.Interval = 1000;
            this.timer_Islemci.Tick += new System.EventHandler(this.timer_Islemci_Tick);
            // 
            // timer_FormGuncelle
            // 
            this.timer_FormGuncelle.Interval = 10;
            this.timer_FormGuncelle.Tick += new System.EventHandler(this.timer_FormGuncelle_Tick);
            // 
            // timer_P1
            // 
            this.timer_P1.Tick += new System.EventHandler(this.timer_P1_Tick);
            // 
            // timer_P2
            // 
            this.timer_P2.Tick += new System.EventHandler(this.timer_P2_Tick);
            // 
            // timer_P3
            // 
            this.timer_P3.Tick += new System.EventHandler(this.timer_P3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_p3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_p2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_p1);
            this.Controls.Add(this.bttn_islemcidurdur);
            this.Controls.Add(this.bttn_islemcibaslat);
            this.Controls.Add(this.textBox_Processkuyrugu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_islemci)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Processkuyrugu;
        private System.Windows.Forms.Button bttn_islemcibaslat;
        private System.Windows.Forms.Button bttn_islemcidurdur;
        private System.Windows.Forms.TextBox textBox_p1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_p2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_p3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar_p3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar_p2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar_p1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_islemci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Processliste;
        private System.Windows.Forms.Button bttn_processlistele;
        private System.Windows.Forms.CheckBox checkBox_p3;
        private System.Windows.Forms.CheckBox checkBox_p2;
        private System.Windows.Forms.CheckBox checkBox_p1;
        private System.Windows.Forms.Timer timer_Islemci;
        private System.Windows.Forms.TextBox textBox_P3Speed;
        private System.Windows.Forms.TextBox textBox_P2Speed;
        private System.Windows.Forms.TextBox textBox_P1Speed;
        private System.Windows.Forms.TextBox textBox_CpuSpeed;
        private System.Windows.Forms.Timer timer_FormGuncelle;
        private System.Windows.Forms.Timer timer_P1;
        private System.Windows.Forms.Timer timer_P2;
        private System.Windows.Forms.Timer timer_P3;
    }
}

