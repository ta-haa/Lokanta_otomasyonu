namespace ders_baslangic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.form2gecis = new System.Windows.Forms.Button();
            this.sure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formuAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuKapatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnqr = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form2gecis
            // 
            this.form2gecis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form2gecis.ForeColor = System.Drawing.Color.IndianRed;
            this.form2gecis.Location = new System.Drawing.Point(81, 411);
            this.form2gecis.Name = "form2gecis";
            this.form2gecis.Size = new System.Drawing.Size(224, 49);
            this.form2gecis.TabIndex = 0;
            this.form2gecis.Text = "Giriş";
            this.form2gecis.UseVisualStyleBackColor = true;
            this.form2gecis.Click += new System.EventHandler(this.form2gecis_Click);
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.Location = new System.Drawing.Point(155, 127);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(73, 32);
            this.sure.TabIndex = 6;
            this.sure.Text = "Şifre";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 279);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 38);
            this.textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 32);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 162);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 37);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(139, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Zaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(139, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Captcha";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Lokantam";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuAçToolStripMenuItem,
            this.formuKapatToolStripMenuItem,
            this.formuKapatToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 76);
            // 
            // formuAçToolStripMenuItem
            // 
            this.formuAçToolStripMenuItem.Name = "formuAçToolStripMenuItem";
            this.formuAçToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.formuAçToolStripMenuItem.Text = "Formu Aç";
            this.formuAçToolStripMenuItem.Click += new System.EventHandler(this.formuAçToolStripMenuItem_Click);
            // 
            // formuKapatToolStripMenuItem
            // 
            this.formuKapatToolStripMenuItem.Name = "formuKapatToolStripMenuItem";
            this.formuKapatToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.formuKapatToolStripMenuItem.Text = "Formu Gizle";
            this.formuKapatToolStripMenuItem.Click += new System.EventHandler(this.formuKapatToolStripMenuItem_Click);
            // 
            // formuKapatToolStripMenuItem1
            // 
            this.formuKapatToolStripMenuItem1.Name = "formuKapatToolStripMenuItem1";
            this.formuKapatToolStripMenuItem1.Size = new System.Drawing.Size(163, 24);
            this.formuKapatToolStripMenuItem1.Text = "Formu Kapat";
            this.formuKapatToolStripMenuItem1.Click += new System.EventHandler(this.formuKapatToolStripMenuItem1_Click);
            // 
            // btnqr
            // 
            this.btnqr.BackColor = System.Drawing.Color.Red;
            this.btnqr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnqr.Font = new System.Drawing.Font("Hobo Std", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqr.ForeColor = System.Drawing.Color.Transparent;
            this.btnqr.Image = ((System.Drawing.Image)(resources.GetObject("btnqr.Image")));
            this.btnqr.Location = new System.Drawing.Point(357, 60);
            this.btnqr.Name = "btnqr";
            this.btnqr.Size = new System.Drawing.Size(263, 295);
            this.btnqr.TabIndex = 49;
            this.btnqr.UseVisualStyleBackColor = false;
            this.btnqr.Click += new System.EventHandler(this.btnqr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 28);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(677, 566);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnqr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.form2gecis);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hesap Makinem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button form2gecis;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnqr;
        private System.Windows.Forms.ToolStripMenuItem formuAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuKapatToolStripMenuItem1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
    }
}

