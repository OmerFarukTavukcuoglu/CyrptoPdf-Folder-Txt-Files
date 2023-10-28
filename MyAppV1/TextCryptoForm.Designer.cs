namespace MyAppV1
{
    partial class TextCryptoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextCryptoForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SifreCözBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AnahtarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SifreleBtn = new System.Windows.Forms.Button();
            this.AnahtarOlstrBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MetinTxtBox = new System.Windows.Forms.TextBox();
            this.MetinAcBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(989, 482);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // SifreCözBtn
            // 
            this.SifreCözBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.SifreCözBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SifreCözBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SifreCözBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreCözBtn.Location = new System.Drawing.Point(780, 10);
            this.SifreCözBtn.Name = "SifreCözBtn";
            this.SifreCözBtn.Size = new System.Drawing.Size(199, 59);
            this.SifreCözBtn.TabIndex = 3;
            this.SifreCözBtn.Text = "     Şifre Çöz";
            this.SifreCözBtn.UseVisualStyleBackColor = false;
            this.SifreCözBtn.Click += new System.EventHandler(this.SifreCözBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(585, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Anahtar:";
            // 
            // AnahtarTextBox
            // 
            this.AnahtarTextBox.Location = new System.Drawing.Point(685, 588);
            this.AnahtarTextBox.Multiline = true;
            this.AnahtarTextBox.Name = "AnahtarTextBox";
            this.AnahtarTextBox.Size = new System.Drawing.Size(327, 23);
            this.AnahtarTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(347, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Şifrelenecek Metin";
            // 
            // SifreleBtn
            // 
            this.SifreleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.SifreleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SifreleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SifreleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreleBtn.Location = new System.Drawing.Point(566, 10);
            this.SifreleBtn.Name = "SifreleBtn";
            this.SifreleBtn.Size = new System.Drawing.Size(199, 59);
            this.SifreleBtn.TabIndex = 2;
            this.SifreleBtn.Text = "     Şifrele";
            this.SifreleBtn.UseVisualStyleBackColor = false;
            this.SifreleBtn.Click += new System.EventHandler(this.SifreleBtn_Click);
            // 
            // AnahtarOlstrBtn
            // 
            this.AnahtarOlstrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.AnahtarOlstrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AnahtarOlstrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnahtarOlstrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnahtarOlstrBtn.Location = new System.Drawing.Point(336, 10);
            this.AnahtarOlstrBtn.Name = "AnahtarOlstrBtn";
            this.AnahtarOlstrBtn.Size = new System.Drawing.Size(213, 59);
            this.AnahtarOlstrBtn.TabIndex = 1;
            this.AnahtarOlstrBtn.Text = "         Anahtar Oluştur";
            this.AnahtarOlstrBtn.UseVisualStyleBackColor = false;
            this.AnahtarOlstrBtn.Click += new System.EventHandler(this.AnahtarOlstrBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(997, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 31);
            this.label7.TabIndex = 35;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            this.label7.MouseHover += new System.EventHandler(this.label7_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.label9.Location = new System.Drawing.Point(410, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 29);
            this.label9.TabIndex = 37;
            this.label9.Text = "METİN ŞİFRELE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(62, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(901, 69);
            this.label2.TabIndex = 38;
            this.label2.Text = "Açmak İstediğin Dosyayı Sürükle";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(182, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "Metin Adı:";
            // 
            // MetinTxtBox
            // 
            this.MetinTxtBox.Location = new System.Drawing.Point(302, 588);
            this.MetinTxtBox.Multiline = true;
            this.MetinTxtBox.Name = "MetinTxtBox";
            this.MetinTxtBox.Size = new System.Drawing.Size(271, 23);
            this.MetinTxtBox.TabIndex = 1;
            // 
            // MetinAcBtn
            // 
            this.MetinAcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.MetinAcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MetinAcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MetinAcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MetinAcBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MetinAcBtn.Location = new System.Drawing.Point(24, 10);
            this.MetinAcBtn.Name = "MetinAcBtn";
            this.MetinAcBtn.Size = new System.Drawing.Size(228, 59);
            this.MetinAcBtn.TabIndex = 0;
            this.MetinAcBtn.Text = "       Metin Dosyası Aç";
            this.MetinAcBtn.UseVisualStyleBackColor = false;
            this.MetinAcBtn.Click += new System.EventHandler(this.MetinAcBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.SifreCözBtn);
            this.panel2.Controls.Add(this.MetinAcBtn);
            this.panel2.Controls.Add(this.AnahtarOlstrBtn);
            this.panel2.Controls.Add(this.SifreleBtn);
            this.panel2.Location = new System.Drawing.Point(23, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 79);
            this.panel2.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(284, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 82);
            this.label5.TabIndex = 42;
            this.label5.Text = "label5";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(671, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 63);
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(255, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 63);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyAppV1.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 32);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1031, 719);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MetinTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnahtarTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextCryptoForm";
            this.Text = "TextCryptoForm";
            this.Load += new System.EventHandler(this.TextCryptoForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SifreCözBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SifreleBtn;
        private System.Windows.Forms.Button AnahtarOlstrBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MetinAcBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.TextBox AnahtarTextBox;
        public System.Windows.Forms.TextBox MetinTxtBox;
        private System.Windows.Forms.Timer timer1;
    }
}