namespace MyAppV1
{
    partial class TxtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TxtForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SifreYontemComboBox = new System.Windows.Forms.ComboBox();
            this.HashCheckBox = new MaterialSkin.Controls.MaterialRadioButton();
            this.SimetrikCheckbox = new MaterialSkin.Controls.MaterialRadioButton();
            this.AsimetrikCheckbox = new MaterialSkin.Controls.MaterialRadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PdfOlustur_Btn = new System.Windows.Forms.Button();
            this.SifreleButon = new System.Windows.Forms.Button();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(44)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifreleme Yöntemleri";
            // 
            // SifreYontemComboBox
            // 
            this.SifreYontemComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.SifreYontemComboBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.SifreYontemComboBox.FormattingEnabled = true;
            this.SifreYontemComboBox.Location = new System.Drawing.Point(12, 88);
            this.SifreYontemComboBox.Name = "SifreYontemComboBox";
            this.SifreYontemComboBox.Size = new System.Drawing.Size(194, 24);
            this.SifreYontemComboBox.TabIndex = 11;
            // 
            // HashCheckBox
            // 
            this.HashCheckBox.AutoSize = true;
            this.HashCheckBox.Depth = 0;
            this.HashCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.HashCheckBox.Location = new System.Drawing.Point(245, 88);
            this.HashCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.HashCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HashCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.HashCheckBox.Name = "HashCheckBox";
            this.HashCheckBox.Ripple = true;
            this.HashCheckBox.Size = new System.Drawing.Size(123, 30);
            this.HashCheckBox.TabIndex = 12;
            this.HashCheckBox.TabStop = true;
            this.HashCheckBox.Text = "Hash Şifreleme";
            this.HashCheckBox.UseVisualStyleBackColor = true;
            this.HashCheckBox.CheckedChanged += new System.EventHandler(this.HashCheckBox_CheckedChanged);
            // 
            // SimetrikCheckbox
            // 
            this.SimetrikCheckbox.AutoSize = true;
            this.SimetrikCheckbox.Depth = 0;
            this.SimetrikCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.SimetrikCheckbox.Location = new System.Drawing.Point(400, 88);
            this.SimetrikCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.SimetrikCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SimetrikCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SimetrikCheckbox.Name = "SimetrikCheckbox";
            this.SimetrikCheckbox.Ripple = true;
            this.SimetrikCheckbox.Size = new System.Drawing.Size(143, 30);
            this.SimetrikCheckbox.TabIndex = 13;
            this.SimetrikCheckbox.TabStop = true;
            this.SimetrikCheckbox.Text = "Simetrik Şifreleme";
            this.SimetrikCheckbox.UseVisualStyleBackColor = true;
            this.SimetrikCheckbox.CheckedChanged += new System.EventHandler(this.SimetrikCheckbox_CheckedChanged);
            // 
            // AsimetrikCheckbox
            // 
            this.AsimetrikCheckbox.AutoSize = true;
            this.AsimetrikCheckbox.Depth = 0;
            this.AsimetrikCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.AsimetrikCheckbox.Location = new System.Drawing.Point(562, 88);
            this.AsimetrikCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.AsimetrikCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AsimetrikCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AsimetrikCheckbox.Name = "AsimetrikCheckbox";
            this.AsimetrikCheckbox.Ripple = true;
            this.AsimetrikCheckbox.Size = new System.Drawing.Size(151, 30);
            this.AsimetrikCheckbox.TabIndex = 14;
            this.AsimetrikCheckbox.TabStop = true;
            this.AsimetrikCheckbox.Text = "Asimetrik Şifreleme";
            this.AsimetrikCheckbox.UseVisualStyleBackColor = true;
            this.AsimetrikCheckbox.CheckedChanged += new System.EventHandler(this.AsimetrikCheckbox_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(6, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(999, 434);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PdfOlustur_Btn
            // 
            this.PdfOlustur_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.PdfOlustur_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PdfOlustur_Btn.BackgroundImage")));
            this.PdfOlustur_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PdfOlustur_Btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.PdfOlustur_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PdfOlustur_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PdfOlustur_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PdfOlustur_Btn.ImageKey = "(none)";
            this.PdfOlustur_Btn.Location = new System.Drawing.Point(649, 590);
            this.PdfOlustur_Btn.Name = "PdfOlustur_Btn";
            this.PdfOlustur_Btn.Size = new System.Drawing.Size(163, 48);
            this.PdfOlustur_Btn.TabIndex = 25;
            this.PdfOlustur_Btn.Text = "    Dosya Aç";
            this.PdfOlustur_Btn.UseVisualStyleBackColor = false;
            this.PdfOlustur_Btn.Click += new System.EventHandler(this.PdfOlustur_Btn_Click);
            // 
            // SifreleButon
            // 
            this.SifreleButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.SifreleButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SifreleButon.BackgroundImage")));
            this.SifreleButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SifreleButon.Cursor = System.Windows.Forms.Cursors.Default;
            this.SifreleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SifreleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreleButon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SifreleButon.ImageKey = "(none)";
            this.SifreleButon.Location = new System.Drawing.Point(842, 589);
            this.SifreleButon.Name = "SifreleButon";
            this.SifreleButon.Size = new System.Drawing.Size(163, 48);
            this.SifreleButon.TabIndex = 26;
            this.SifreleButon.Text = "        Metin Şifrele";
            this.SifreleButon.UseVisualStyleBackColor = false;
            this.SifreleButon.Click += new System.EventHandler(this.SifreleButon_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(44)))), ((int)(((byte)(22)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 144);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1021, 8);
            this.materialDivider1.TabIndex = 27;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(44)))), ((int)(((byte)(22)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-2, 574);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1021, 8);
            this.materialDivider2.TabIndex = 28;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(44)))), ((int)(((byte)(22)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(0, 147);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(8, 434);
            this.materialDivider3.TabIndex = 29;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(44)))), ((int)(((byte)(22)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(1005, 147);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(8, 434);
            this.materialDivider4.TabIndex = 30;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(901, 69);
            this.label2.TabIndex = 31;
            this.label2.Text = "Açmak İstediğin Dosyayı Sürükle";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // TxtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1013, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialDivider4);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.SifreleButon);
            this.Controls.Add(this.PdfOlustur_Btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AsimetrikCheckbox);
            this.Controls.Add(this.SimetrikCheckbox);
            this.Controls.Add(this.HashCheckBox);
            this.Controls.Add(this.SifreYontemComboBox);
            this.Controls.Add(this.label1);
            this.Name = "TxtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TxtForm";
            this.Load += new System.EventHandler(this.TxtForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SifreYontemComboBox;
        private MaterialSkin.Controls.MaterialRadioButton HashCheckBox;
        private MaterialSkin.Controls.MaterialRadioButton SimetrikCheckbox;
        private MaterialSkin.Controls.MaterialRadioButton AsimetrikCheckbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button PdfOlustur_Btn;
        private System.Windows.Forms.Button SifreleButon;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private System.Windows.Forms.Label label2;
    }
}