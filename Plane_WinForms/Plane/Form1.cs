using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Plane
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        Timer timer1 = new Timer();
        bool isiqYanir = false;
        int hereket = 0;
        int teyyareY = 265;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(FaylYolu("teyyare.png"));
            pictureBox2.Image = Image.FromFile(FaylYolu("isiq.png"));
            pictureBox2.Parent = pictureBox1;
            pictureBox2.Location = new Point(-5, -20);
            pictureBox2.Visible = false;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
        }

        private string FaylYolu(string fayl)
        {
            return Path.Combine(Application.StartupPath, "Assets", fayl);
        }

        private void SesCal(string fayl)
        {
            try
            {
                player.Stop();
                player.SoundLocation = FaylYolu(fayl);
                player.Load();
                player.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("Səs faylı tapılmadı: " + fayl, "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SesCal("inishazirliklari.wav");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SesCal("turbulans.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SesCal("kemerler.wav");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SesCal("tesekkurler.wav");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SesCal("beep.wav");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // GAS: təyyarə yuxarı hərəkət edir.
            hereket = -2;
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Break: təyyarə aşağı hərəkət edir.
            hereket = 2;
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isiqYanir = !isiqYanir;
            pictureBox2.Visible = isiqYanir;
            SesCal("isikacmakapamasesi.wav");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            teyyareY += hereket;
            if (teyyareY < 40) teyyareY = 40;
            if (teyyareY > 265) teyyareY = 265;
            pictureBox1.Top = teyyareY;
            if (teyyareY == 40 || teyyareY == 265)
                timer1.Stop();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
            player.Stop();
            player.Dispose();
            pictureBox1.Image.Dispose();
            pictureBox2.Image.Dispose();
            base.OnFormClosed(e);
        }
    }
}
