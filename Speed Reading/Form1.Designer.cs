namespace Speed_Reading
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
            this.Btn_Next = new System.Windows.Forms.PictureBox();
            this.Btn_Pause = new System.Windows.Forms.PictureBox();
            this.Btn_Play = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Back)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Next
            // 
            this.Btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Next.Image")));
            this.Btn_Next.Location = new System.Drawing.Point(738, 678);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(39, 34);
            this.Btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Next.TabIndex = 7;
            this.Btn_Next.TabStop = false;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            this.Btn_Next.MouseLeave += new System.EventHandler(this.Btn_Next_MouseLeave);
            this.Btn_Next.MouseHover += new System.EventHandler(this.Btn_Next_MouseHover);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Pause.Image")));
            this.Btn_Pause.Location = new System.Drawing.Point(693, 678);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(39, 34);
            this.Btn_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Pause.TabIndex = 6;
            this.Btn_Pause.TabStop = false;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            this.Btn_Pause.MouseLeave += new System.EventHandler(this.Btn_Pause_MouseLeave);
            this.Btn_Pause.MouseHover += new System.EventHandler(this.Btn_Pause_MouseHover);
            // 
            // Btn_Play
            // 
            this.Btn_Play.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Play.Image")));
            this.Btn_Play.Location = new System.Drawing.Point(648, 678);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(39, 34);
            this.Btn_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Play.TabIndex = 5;
            this.Btn_Play.TabStop = false;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            this.Btn_Play.MouseLeave += new System.EventHandler(this.Btn_Play_MouseLeave);
            this.Btn_Play.MouseHover += new System.EventHandler(this.Btn_Play_MouseHover);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Enabled = false;
            this.Btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Back.Image")));
            this.Btn_Back.Location = new System.Drawing.Point(603, 678);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(39, 34);
            this.Btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.TabStop = false;
            this.Btn_Back.Visible = false;
            this.Btn_Back.MouseLeave += new System.EventHandler(this.Btn_Back_MouseLeave);
            this.Btn_Back.MouseHover += new System.EventHandler(this.Btn_Back_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bu eğitimdeki alıştırmaları 21 gün boyunca yapınız.";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alıştırmaları her gün yapmalısınız.";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(598, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Uygulamaları içinizden yapınız, sesli yapmayınız.";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(166, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(751, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hızlı Okuma Teknikleri Eğitimine Hoşgeldiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(110, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(580, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Her gün 30 dakikanızı bu uygulamalara ayırınız.";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(110, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(563, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gözünüzü adeta fotoğraf çeker gibi kullanınız.";
            this.label7.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(110, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(699, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bu çalışmalara devam edildikçe hızınızın yanı sıra anlama";
            this.label5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(110, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(440, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "ve kavrama düzeyiniz de artacaktır.";
            this.label8.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem1.Text = "1";
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem23.Text = "1";
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem24.Text = "2";
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem25.Text = "3";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem26,
            this.toolStripMenuItem27,
            this.toolStripMenuItem28});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem2.Text = "2";
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem26.Text = "1";
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem27.Text = "2";
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem28.Text = "3";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem3.Text = "3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem4.Text = "4";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.AutoSize = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem5.Text = "5";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.AutoSize = false;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem6.Text = "6";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.AutoSize = false;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem7.Text = "7";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.AutoSize = false;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem8.Text = "8";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.AutoSize = false;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem9.Text = "9";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.AutoSize = false;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem10.Text = "10";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.AutoSize = false;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem11.Text = "11";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.AutoSize = false;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem12.Text = "12";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.AutoSize = false;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem13.Text = "13";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.AutoSize = false;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem14.Text = "14";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.AutoSize = false;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem15.Text = "15";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.AutoSize = false;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem16.Text = "16";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.AutoSize = false;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem17.Text = "17";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.AutoSize = false;
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem18.Text = "18";
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.AutoSize = false;
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem19.Text = "19";
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.AutoSize = false;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem20.Text = "20";
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.AutoSize = false;
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(60, 25);
            this.toolStripMenuItem21.Text = "21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.Btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Back)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Btn_Next;
        private System.Windows.Forms.PictureBox Btn_Pause;
        private System.Windows.Forms.PictureBox Btn_Play;
        private System.Windows.Forms.PictureBox Btn_Back;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
    }
}

