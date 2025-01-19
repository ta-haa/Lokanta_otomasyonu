using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Timers;
using System.Windows.Forms; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ders_baslangic
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         

        int sayac = 10;
         
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TabIndex = 0;
            textBox2.TabIndex = 1;
            textBox3.TabIndex = 2;
            form2gecis.TabIndex = 3;
            btnqr.TabIndex = 4; 

             

            timer1.Start();
           timer1.Interval = 1000;

            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 10;

            textBox1.TabIndex = 0;
            textBox2.TabIndex = 1;
            textBox3.TabIndex = 2; 


            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(gradient_rectangle, Color.Red, Color.Black, 45f);
            Graphics.ReferenceEquals(brush, gradient_rectangle);
            this.Paint += new PaintEventHandler(set_background);
        }
        private void set_background(Object sender, PaintEventArgs e)
        {

            if (sayac == 1)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(255, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 2)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(255, 0, 0), Color.FromArgb(0, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 3)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(0, 255, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 4)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 255, 0), Color.FromArgb(0, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 5)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(255, 69, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 6)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(255, 69, 0), Color.FromArgb(0, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 7)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(128, 0, 128), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 8)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(128, 0, 128), Color.FromArgb(0, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 9)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 10)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(255, 255, 0), Color.FromArgb(0, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text = sayac.ToString();

            if (sayac == 0) {
                sayac = 10;

                string[] buyukharfler = {"A","B","C", "D", "E", "F", "G", "H", "I" };
                string[] kucukharfler = { "q", "w", "e", "r", "f", "r", "t", "a", "h" };
                string[] semboller = { "+", "-", "*", "/", "?", ".", "=" };

                Random rasgele = new Random();

                int sembol1, sembol2, sembol3, sembol4;

                sembol1 = rasgele.Next(0 ,buyukharfler.Length);
                sembol2 = rasgele.Next(0, kucukharfler.Length);
                sembol3 = rasgele.Next(0, semboller.Length);
                sembol4 = rasgele.Next(0, 10);

                label3.Text = buyukharfler[sembol1] + kucukharfler[sembol2] + semboller[sembol3] + sembol4.ToString();




            }



        }


        
        

         

        private void formuAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void formuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        } 
        private void formuKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yardımToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TahaKeskin");
        }

        private void btnqr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TahaKeskin");
        }

        private void form2gecis_Click(object sender, EventArgs e)
        {
            try
            {
                string yazi1 = label3.Text;
                string yazi2 = textBox3.Text;

                if (yazi1 == yazi2)
                { 

                    baglati.baglan.Open();
                    SqlCommand uyegiris = new SqlCommand("select * from ders1 where ad=@adim and sifre=@sife",baglati.baglan);
                    uyegiris.Parameters.AddWithValue("@adim",textBox1.Text);
                    uyegiris.Parameters.AddWithValue("@sife",textBox2.Text);
                    SqlDataAdapter da = new SqlDataAdapter(uyegiris);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        Form2 ekran = new Form2();
                        ekran.Show();
                        MessageBox.Show("hoşgeldiniz");
                    }
                    else
                    {
                        MessageBox.Show("eposta veya şifre hatalı");
                    }
                    baglati.baglan.Close();

                }
                else
                { 
                    MessageBox.Show("beklenmedik hata");
                    Close();
                }




            }
            catch (Exception ) {

                MessageBox.Show("beklenmedik hata lütfen daha sonra tekrar deneyin.", "!! hata !! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
