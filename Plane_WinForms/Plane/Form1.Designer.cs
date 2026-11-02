namespace Plane
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // panel1 - airplane screen
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 419);
            // pictureBox1
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(33, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // pictureBox2 - light overlay
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // buttons, as in example screenshot
            this.button1.Location = new System.Drawing.Point(242, 8);
            this.button1.Size = new System.Drawing.Size(320, 42);
            this.button1.Text = "Eniş hazırlığı";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Location = new System.Drawing.Point(242, 59);
            this.button2.Size = new System.Drawing.Size(320, 42);
            this.button2.Text = "Turbulans";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Location = new System.Drawing.Point(242, 110);
            this.button3.Size = new System.Drawing.Size(320, 47);
            this.button3.Text = "Kəmərlər";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button4.Location = new System.Drawing.Point(242, 165);
            this.button4.Size = new System.Drawing.Size(320, 47);
            this.button4.Text = "Təşəkkürlər";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button5.Location = new System.Drawing.Point(242, 220);
            this.button5.Size = new System.Drawing.Size(320, 43);
            this.button5.Text = "Beep";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            System.Windows.Forms.Button[] narinci = { button1, button2, button3, button4, button5 };
            foreach (System.Windows.Forms.Button b in narinci)
            {
                b.BackColor = System.Drawing.Color.DarkOrange;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
                b.FlatAppearance.BorderSize = 2;
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                b.UseVisualStyleBackColor = false;
            }
            this.button6.Location = new System.Drawing.Point(249, 294);
            this.button6.Size = new System.Drawing.Size(122, 66);
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Text = "GAS";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button7.Location = new System.Drawing.Point(420, 294);
            this.button7.Size = new System.Drawing.Size(125, 66);
            this.button7.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Text = "Break";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button8.Location = new System.Drawing.Point(231, 375);
            this.button8.Size = new System.Drawing.Size(339, 43);
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Text = "ON/OFF";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            System.Windows.Forms.Button[] diger = { button6, button7, button8 };
            foreach (System.Windows.Forms.Button b in diger)
            {
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                b.FlatAppearance.BorderSize = 2;
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                b.UseVisualStyleBackColor = false;
            }
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.ClientSize = new System.Drawing.Size(572, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plane";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
