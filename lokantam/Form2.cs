using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_baslangic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
 

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TahaKeskin");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox3.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
        } 
       
         

        private void button3_Click(object sender, EventArgs e)
        {
            admin_paneli ekran = new admin_paneli();
            ekran.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {                                          
                string arama = yemeklersearch.Text;
                baglati.baglan.Open();
                SqlCommand ara = new SqlCommand("select * from ders1 where ad like '%" + arama + "%'", baglati.baglan);
                SqlDataReader dr = ara.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                baglati.baglan.Close(); 
            }
            catch (Exception)
            {
                MessageBox.Show("hata çikti", "!!hata!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int idverisi = int.Parse(textBox4.Text);

            baglati.baglan.Open();

            SqlCommand sifreguncelle = new SqlCommand("update ders1 set ad=@ad, soyad=@soyad, sifre=@sifre, maas=@maas where kullanici_id="+idverisi, baglati.baglan);

            sifreguncelle.Parameters.AddWithValue("@ad", textBox1.Text);
            sifreguncelle.Parameters.AddWithValue("@soyad", textBox3.Text);
            sifreguncelle.Parameters.AddWithValue("@sifre", textBox5.Text);
            sifreguncelle.Parameters.AddWithValue("@maas", textBox6.Text);

            sifreguncelle.ExecuteNonQuery();

            baglati.baglan.Close();

            MessageBox.Show("kullanici güncellendi");


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı Seçilmedi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.Filter = "Resim Dosyası |*.jpeg;*.png;*.jpg;*.JPG | Tüm Dosyalar |*.*";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
           baglati.baglan.Open();
                SqlCommand uyeol = new SqlCommand("insert into ders1 (ad,soyad,sifre,fotograf, maas) values (@ad,@soyad,@sifre,@foto,@maas) " , baglati.baglan);
                uyeol.Parameters.AddWithValue("@ad", textBox1.Text);
                uyeol.Parameters.AddWithValue("@soyad", textBox3.Text);
                uyeol.Parameters.AddWithValue("@sifre", textBox5.Text);
                uyeol.Parameters.AddWithValue("@foto", openFileDialog1.FileName);
                uyeol.Parameters.AddWithValue("@maas", textBox6.Text); 

                uyeol.ExecuteNonQuery();

                baglati.baglan.Close();

                MessageBox.Show("kullanıcı eklendi");



            }
            catch (Exception) {
                MessageBox.Show("hata");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sil_id = int.Parse(textBox4.Text);

            var result = MessageBox.Show("Bak emin misin","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {

                var result2 = MessageBox.Show("Bak emin misin", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes) { 
                
                baglati.baglan.Open();
                    SqlCommand sil = new SqlCommand("delete from ders1 where kullanici_id="+ sil_id , baglati.baglan);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("kullanici silindi");

                   baglati.baglan.Close() ; 

                }
            }
            

        }
    }
}
