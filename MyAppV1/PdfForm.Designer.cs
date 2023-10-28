namespace MyAppV1
{
    partial class PdfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfForm));
            this.PdfListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.KullaniciSifreTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.YöneticiSifreTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SifreleTurleriPictureBox = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AESEncrypt128Checkbox = new MaterialSkin.Controls.MaterialRadioButton();
            this.StandardEncryp128CheckBox = new MaterialSkin.Controls.MaterialRadioButton();
            this.StandardEncryp40CheckBox = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BelgeBirlestirCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.ErisebilirİCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.FormDoldurCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.EkAcıklamaECheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.İcerikDegistirCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.İcerikKopyalaCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.BelgeYazdırCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CikisYolRadioBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.CikisYolTextBox = new System.Windows.Forms.TextBox();
            this.Arastır_Btn = new System.Windows.Forms.Button();
            this.VarsayılanCikisYolRadioBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.AyarlarBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qwewqeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.YöneticiSifrePictureBox = new System.Windows.Forms.PictureBox();
            this.KullaniciSifrePictureBox = new System.Windows.Forms.PictureBox();
            this.PdfAdTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BelgeAdPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.CikisYolPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.HepsiniSil_Btn = new System.Windows.Forms.Button();
            this.Sil_Btn = new System.Windows.Forms.Button();
            this.KlasörEkle_Btn = new System.Windows.Forms.Button();
            this.PdfOlustur_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SifreleTurleriPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YöneticiSifrePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciSifrePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelgeAdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CikisYolPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PdfListView
            // 
            this.PdfListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PdfListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.PdfListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.PdfListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PdfListView.GridLines = true;
            this.PdfListView.Location = new System.Drawing.Point(23, 103);
            this.PdfListView.Name = "PdfListView";
            this.PdfListView.Size = new System.Drawing.Size(989, 215);
            this.PdfListView.TabIndex = 6;
            this.PdfListView.UseCompatibleStateImageBehavior = false;
            this.PdfListView.View = System.Windows.Forms.View.Details;
            this.PdfListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PdfListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dosya Adı";
            this.columnHeader1.Width = 224;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sayfa Sayısı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dosya Boyutu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dosya Yolu";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 531;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(346, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Şifresi:";
            // 
            // KullaniciSifreTextBox
            // 
            this.KullaniciSifreTextBox.Depth = 0;
            this.KullaniciSifreTextBox.Hint = "";
            this.KullaniciSifreTextBox.Location = new System.Drawing.Point(483, 13);
            this.KullaniciSifreTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.KullaniciSifreTextBox.Name = "KullaniciSifreTextBox";
            this.KullaniciSifreTextBox.PasswordChar = '\0';
            this.KullaniciSifreTextBox.SelectedText = "";
            this.KullaniciSifreTextBox.SelectionLength = 0;
            this.KullaniciSifreTextBox.SelectionStart = 0;
            this.KullaniciSifreTextBox.Size = new System.Drawing.Size(143, 23);
            this.KullaniciSifreTextBox.TabIndex = 1;
            this.KullaniciSifreTextBox.Text = "Şifreyi Gir";
            this.KullaniciSifreTextBox.UseSystemPasswordChar = true;
            this.KullaniciSifreTextBox.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            this.KullaniciSifreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KullaniciSifreTextBox_KeyDown);
            this.KullaniciSifreTextBox.Leave += new System.EventHandler(this.KullaniciSifreTextBox_Leave);
            // 
            // YöneticiSifreTextBox
            // 
            this.YöneticiSifreTextBox.Depth = 0;
            this.YöneticiSifreTextBox.Hint = "";
            this.YöneticiSifreTextBox.Location = new System.Drawing.Point(803, 12);
            this.YöneticiSifreTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.YöneticiSifreTextBox.Name = "YöneticiSifreTextBox";
            this.YöneticiSifreTextBox.PasswordChar = '\0';
            this.YöneticiSifreTextBox.SelectedText = "";
            this.YöneticiSifreTextBox.SelectionLength = 0;
            this.YöneticiSifreTextBox.SelectionStart = 0;
            this.YöneticiSifreTextBox.Size = new System.Drawing.Size(143, 23);
            this.YöneticiSifreTextBox.TabIndex = 2;
            this.YöneticiSifreTextBox.Text = "Sifreyi Gir";
            this.YöneticiSifreTextBox.UseSystemPasswordChar = true;
            this.YöneticiSifreTextBox.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            this.YöneticiSifreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YöneticiSifreTextBox_KeyDown);
            this.YöneticiSifreTextBox.Leave += new System.EventHandler(this.YöneticiSifreTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(667, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yönetici Şifresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pdf İzinleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Şifreleme Türleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SifreleTurleriPictureBox);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.AESEncrypt128Checkbox);
            this.panel1.Controls.Add(this.StandardEncryp128CheckBox);
            this.panel1.Controls.Add(this.StandardEncryp40CheckBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(23, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 177);
            this.panel1.TabIndex = 15;
            // 
            // SifreleTurleriPictureBox
            // 
            this.SifreleTurleriPictureBox.Location = new System.Drawing.Point(338, 3);
            this.SifreleTurleriPictureBox.Name = "SifreleTurleriPictureBox";
            this.SifreleTurleriPictureBox.Size = new System.Drawing.Size(42, 42);
            this.SifreleTurleriPictureBox.TabIndex = 38;
            this.SifreleTurleriPictureBox.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(320, 157);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Dahası...";
            // 
            // AESEncrypt128Checkbox
            // 
            this.AESEncrypt128Checkbox.AutoSize = true;
            this.AESEncrypt128Checkbox.Depth = 0;
            this.AESEncrypt128Checkbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.AESEncrypt128Checkbox.Location = new System.Drawing.Point(21, 134);
            this.AESEncrypt128Checkbox.Margin = new System.Windows.Forms.Padding(0);
            this.AESEncrypt128Checkbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AESEncrypt128Checkbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AESEncrypt128Checkbox.Name = "AESEncrypt128Checkbox";
            this.AESEncrypt128Checkbox.Ripple = true;
            this.AESEncrypt128Checkbox.Size = new System.Drawing.Size(177, 30);
            this.AESEncrypt128Checkbox.TabIndex = 2;
            this.AESEncrypt128Checkbox.TabStop = true;
            this.AESEncrypt128Checkbox.Text = "AES Encryption 128 Bits";
            this.AESEncrypt128Checkbox.UseVisualStyleBackColor = true;
            this.AESEncrypt128Checkbox.CheckedChanged += new System.EventHandler(this.AESEncrypt128Checkbox_CheckedChanged);
            // 
            // StandardEncryp128CheckBox
            // 
            this.StandardEncryp128CheckBox.AutoSize = true;
            this.StandardEncryp128CheckBox.Depth = 0;
            this.StandardEncryp128CheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.StandardEncryp128CheckBox.Location = new System.Drawing.Point(21, 86);
            this.StandardEncryp128CheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.StandardEncryp128CheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StandardEncryp128CheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.StandardEncryp128CheckBox.Name = "StandardEncryp128CheckBox";
            this.StandardEncryp128CheckBox.Ripple = true;
            this.StandardEncryp128CheckBox.Size = new System.Drawing.Size(207, 30);
            this.StandardEncryp128CheckBox.TabIndex = 1;
            this.StandardEncryp128CheckBox.TabStop = true;
            this.StandardEncryp128CheckBox.Text = "Standard Encryption 128 Bits";
            this.StandardEncryp128CheckBox.UseVisualStyleBackColor = true;
            this.StandardEncryp128CheckBox.CheckedChanged += new System.EventHandler(this.StandardEncryp128CheckBox_CheckedChanged);
            // 
            // StandardEncryp40CheckBox
            // 
            this.StandardEncryp40CheckBox.AutoSize = true;
            this.StandardEncryp40CheckBox.Depth = 0;
            this.StandardEncryp40CheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.StandardEncryp40CheckBox.Location = new System.Drawing.Point(21, 36);
            this.StandardEncryp40CheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.StandardEncryp40CheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StandardEncryp40CheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.StandardEncryp40CheckBox.Name = "StandardEncryp40CheckBox";
            this.StandardEncryp40CheckBox.Ripple = true;
            this.StandardEncryp40CheckBox.Size = new System.Drawing.Size(200, 30);
            this.StandardEncryp40CheckBox.TabIndex = 0;
            this.StandardEncryp40CheckBox.TabStop = true;
            this.StandardEncryp40CheckBox.Text = "Standard Encryption 40 Bits";
            this.StandardEncryp40CheckBox.UseVisualStyleBackColor = true;
            this.StandardEncryp40CheckBox.CheckedChanged += new System.EventHandler(this.StandardEncryp40CheckBox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BelgeBirlestirCheckBox);
            this.panel2.Controls.Add(this.ErisebilirİCheckBox);
            this.panel2.Controls.Add(this.FormDoldurCheckBox);
            this.panel2.Controls.Add(this.EkAcıklamaECheckBox);
            this.panel2.Controls.Add(this.İcerikDegistirCheckBox);
            this.panel2.Controls.Add(this.İcerikKopyalaCheckBox);
            this.panel2.Controls.Add(this.BelgeYazdırCheckBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(469, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 177);
            this.panel2.TabIndex = 16;
            // 
            // BelgeBirlestirCheckBox
            // 
            this.BelgeBirlestirCheckBox.AutoSize = true;
            this.BelgeBirlestirCheckBox.Depth = 0;
            this.BelgeBirlestirCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.BelgeBirlestirCheckBox.Location = new System.Drawing.Point(215, 68);
            this.BelgeBirlestirCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.BelgeBirlestirCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BelgeBirlestirCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.BelgeBirlestirCheckBox.Name = "BelgeBirlestirCheckBox";
            this.BelgeBirlestirCheckBox.Ripple = true;
            this.BelgeBirlestirCheckBox.Size = new System.Drawing.Size(135, 30);
            this.BelgeBirlestirCheckBox.TabIndex = 5;
            this.BelgeBirlestirCheckBox.Text = "Belge Birleştirme";
            this.BelgeBirlestirCheckBox.UseVisualStyleBackColor = true;
            // 
            // ErisebilirİCheckBox
            // 
            this.ErisebilirİCheckBox.AutoSize = true;
            this.ErisebilirİCheckBox.Depth = 0;
            this.ErisebilirİCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ErisebilirİCheckBox.Location = new System.Drawing.Point(215, 101);
            this.ErisebilirİCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ErisebilirİCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ErisebilirİCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ErisebilirİCheckBox.Name = "ErisebilirİCheckBox";
            this.ErisebilirİCheckBox.Ripple = true;
            this.ErisebilirİCheckBox.Size = new System.Drawing.Size(238, 30);
            this.ErisebilirİCheckBox.TabIndex = 6;
            this.ErisebilirİCheckBox.Text = "Erişilebilirlik için içerik kopyalama";
            this.ErisebilirİCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormDoldurCheckBox
            // 
            this.FormDoldurCheckBox.AutoSize = true;
            this.FormDoldurCheckBox.Depth = 0;
            this.FormDoldurCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.FormDoldurCheckBox.Location = new System.Drawing.Point(215, 36);
            this.FormDoldurCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.FormDoldurCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FormDoldurCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.FormDoldurCheckBox.Name = "FormDoldurCheckBox";
            this.FormDoldurCheckBox.Ripple = true;
            this.FormDoldurCheckBox.Size = new System.Drawing.Size(125, 30);
            this.FormDoldurCheckBox.TabIndex = 4;
            this.FormDoldurCheckBox.Text = "Form Doldurma";
            this.FormDoldurCheckBox.UseVisualStyleBackColor = true;
            // 
            // EkAcıklamaECheckBox
            // 
            this.EkAcıklamaECheckBox.AutoSize = true;
            this.EkAcıklamaECheckBox.Depth = 0;
            this.EkAcıklamaECheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.EkAcıklamaECheckBox.Location = new System.Drawing.Point(17, 135);
            this.EkAcıklamaECheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.EkAcıklamaECheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EkAcıklamaECheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.EkAcıklamaECheckBox.Name = "EkAcıklamaECheckBox";
            this.EkAcıklamaECheckBox.Ripple = true;
            this.EkAcıklamaECheckBox.Size = new System.Drawing.Size(170, 30);
            this.EkAcıklamaECheckBox.TabIndex = 3;
            this.EkAcıklamaECheckBox.Text = "Ek Açıklamalar Ekleme";
            this.EkAcıklamaECheckBox.UseVisualStyleBackColor = true;
            // 
            // İcerikDegistirCheckBox
            // 
            this.İcerikDegistirCheckBox.AutoSize = true;
            this.İcerikDegistirCheckBox.Depth = 0;
            this.İcerikDegistirCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.İcerikDegistirCheckBox.Location = new System.Drawing.Point(17, 101);
            this.İcerikDegistirCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.İcerikDegistirCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.İcerikDegistirCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.İcerikDegistirCheckBox.Name = "İcerikDegistirCheckBox";
            this.İcerikDegistirCheckBox.Ripple = true;
            this.İcerikDegistirCheckBox.Size = new System.Drawing.Size(138, 30);
            this.İcerikDegistirCheckBox.TabIndex = 2;
            this.İcerikDegistirCheckBox.Text = "İçeriği Değiştirme";
            this.İcerikDegistirCheckBox.UseVisualStyleBackColor = true;
            // 
            // İcerikKopyalaCheckBox
            // 
            this.İcerikKopyalaCheckBox.AutoSize = true;
            this.İcerikKopyalaCheckBox.Depth = 0;
            this.İcerikKopyalaCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.İcerikKopyalaCheckBox.Location = new System.Drawing.Point(17, 68);
            this.İcerikKopyalaCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.İcerikKopyalaCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.İcerikKopyalaCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.İcerikKopyalaCheckBox.Name = "İcerikKopyalaCheckBox";
            this.İcerikKopyalaCheckBox.Ripple = true;
            this.İcerikKopyalaCheckBox.Size = new System.Drawing.Size(136, 30);
            this.İcerikKopyalaCheckBox.TabIndex = 1;
            this.İcerikKopyalaCheckBox.Text = "İçerik Kopyalama";
            this.İcerikKopyalaCheckBox.UseVisualStyleBackColor = true;
            // 
            // BelgeYazdırCheckBox
            // 
            this.BelgeYazdırCheckBox.AutoSize = true;
            this.BelgeYazdırCheckBox.Depth = 0;
            this.BelgeYazdırCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.BelgeYazdırCheckBox.Location = new System.Drawing.Point(17, 36);
            this.BelgeYazdırCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.BelgeYazdırCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BelgeYazdırCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.BelgeYazdırCheckBox.Name = "BelgeYazdırCheckBox";
            this.BelgeYazdırCheckBox.Ripple = true;
            this.BelgeYazdırCheckBox.Size = new System.Drawing.Size(126, 30);
            this.BelgeYazdırCheckBox.TabIndex = 0;
            this.BelgeYazdırCheckBox.Text = "Belge Yazdırma";
            this.BelgeYazdırCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Çıkış Yolu Seçiniz";
            // 
            // CikisYolRadioBtn
            // 
            this.CikisYolRadioBtn.AutoSize = true;
            this.CikisYolRadioBtn.Depth = 0;
            this.CikisYolRadioBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.CikisYolRadioBtn.Location = new System.Drawing.Point(34, 632);
            this.CikisYolRadioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CikisYolRadioBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CikisYolRadioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CikisYolRadioBtn.Name = "CikisYolRadioBtn";
            this.CikisYolRadioBtn.Ripple = true;
            this.CikisYolRadioBtn.Size = new System.Drawing.Size(25, 30);
            this.CikisYolRadioBtn.TabIndex = 7;
            this.CikisYolRadioBtn.TabStop = true;
            this.CikisYolRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CikisYolTextBox
            // 
            this.CikisYolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CikisYolTextBox.Location = new System.Drawing.Point(69, 634);
            this.CikisYolTextBox.Multiline = true;
            this.CikisYolTextBox.Name = "CikisYolTextBox";
            this.CikisYolTextBox.Size = new System.Drawing.Size(345, 24);
            this.CikisYolTextBox.TabIndex = 1;
            // 
            // Arastır_Btn
            // 
            this.Arastır_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arastır_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Arastır_Btn.Location = new System.Drawing.Point(429, 631);
            this.Arastır_Btn.Name = "Arastır_Btn";
            this.Arastır_Btn.Size = new System.Drawing.Size(120, 30);
            this.Arastır_Btn.TabIndex = 6;
            this.Arastır_Btn.Text = "Araştır";
            this.Arastır_Btn.UseVisualStyleBackColor = true;
            this.Arastır_Btn.Click += new System.EventHandler(this.Arastır_Btn_Click);
            // 
            // VarsayılanCikisYolRadioBtn
            // 
            this.VarsayılanCikisYolRadioBtn.AutoSize = true;
            this.VarsayılanCikisYolRadioBtn.Depth = 0;
            this.VarsayılanCikisYolRadioBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.VarsayılanCikisYolRadioBtn.Location = new System.Drawing.Point(34, 673);
            this.VarsayılanCikisYolRadioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.VarsayılanCikisYolRadioBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.VarsayılanCikisYolRadioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.VarsayılanCikisYolRadioBtn.Name = "VarsayılanCikisYolRadioBtn";
            this.VarsayılanCikisYolRadioBtn.Ripple = true;
            this.VarsayılanCikisYolRadioBtn.Size = new System.Drawing.Size(25, 30);
            this.VarsayılanCikisYolRadioBtn.TabIndex = 8;
            this.VarsayılanCikisYolRadioBtn.TabStop = true;
            this.VarsayılanCikisYolRadioBtn.UseVisualStyleBackColor = true;
            this.VarsayılanCikisYolRadioBtn.CheckedChanged += new System.EventHandler(this.VarsayılanCikisYolRadioBtn_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(65, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Varsayılan Kayıt Yolu";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(559, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Aç";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.ImageKey = "(none)";
            this.button7.Location = new System.Drawing.Point(851, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 48);
            this.button7.TabIndex = 5;
            this.button7.Text = "Yardım";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // AyarlarBtn
            // 
            this.AyarlarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.AyarlarBtn.BackgroundImage = global::MyAppV1.Properties.Resources.Settings;
            this.AyarlarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AyarlarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AyarlarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AyarlarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AyarlarBtn.ImageKey = "(none)";
            this.AyarlarBtn.Location = new System.Drawing.Point(687, 47);
            this.AyarlarBtn.Name = "AyarlarBtn";
            this.AyarlarBtn.Size = new System.Drawing.Size(158, 48);
            this.AyarlarBtn.TabIndex = 4;
            this.AyarlarBtn.Text = "Ayarlar";
            this.AyarlarBtn.UseVisualStyleBackColor = false;
            this.AyarlarBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qwewqeToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 48);
            // 
            // qwewqeToolStripMenuItem
            // 
            this.qwewqeToolStripMenuItem.Name = "qwewqeToolStripMenuItem";
            this.qwewqeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.qwewqeToolStripMenuItem.Text = "Dosya Yolunu Aç";
            this.qwewqeToolStripMenuItem.Click += new System.EventHandler(this.qwewqeToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(997, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            this.label7.MouseHover += new System.EventHandler(this.label7_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.YöneticiSifrePictureBox);
            this.panel3.Controls.Add(this.KullaniciSifrePictureBox);
            this.panel3.Controls.Add(this.PdfAdTextBox);
            this.panel3.Controls.Add(this.BelgeAdPictureBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.KullaniciSifreTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.YöneticiSifreTextBox);
            this.panel3.Location = new System.Drawing.Point(23, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 50);
            this.panel3.TabIndex = 32;
            // 
            // YöneticiSifrePictureBox
            // 
            this.YöneticiSifrePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("YöneticiSifrePictureBox.Image")));
            this.YöneticiSifrePictureBox.Location = new System.Drawing.Point(943, -4);
            this.YöneticiSifrePictureBox.Name = "YöneticiSifrePictureBox";
            this.YöneticiSifrePictureBox.Size = new System.Drawing.Size(42, 40);
            this.YöneticiSifrePictureBox.TabIndex = 37;
            this.YöneticiSifrePictureBox.TabStop = false;
            // 
            // KullaniciSifrePictureBox
            // 
            this.KullaniciSifrePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciSifrePictureBox.Image")));
            this.KullaniciSifrePictureBox.Location = new System.Drawing.Point(625, -4);
            this.KullaniciSifrePictureBox.Name = "KullaniciSifrePictureBox";
            this.KullaniciSifrePictureBox.Size = new System.Drawing.Size(42, 40);
            this.KullaniciSifrePictureBox.TabIndex = 36;
            this.KullaniciSifrePictureBox.TabStop = false;
            // 
            // PdfAdTextBox
            // 
            this.PdfAdTextBox.Depth = 0;
            this.PdfAdTextBox.Hint = "";
            this.PdfAdTextBox.Location = new System.Drawing.Point(135, 13);
            this.PdfAdTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PdfAdTextBox.Name = "PdfAdTextBox";
            this.PdfAdTextBox.PasswordChar = '\0';
            this.PdfAdTextBox.SelectedText = "";
            this.PdfAdTextBox.SelectionLength = 0;
            this.PdfAdTextBox.SelectionStart = 0;
            this.PdfAdTextBox.Size = new System.Drawing.Size(160, 23);
            this.PdfAdTextBox.TabIndex = 0;
            this.PdfAdTextBox.Text = "Belge Ad";
            this.PdfAdTextBox.UseSystemPasswordChar = false;
            this.PdfAdTextBox.Click += new System.EventHandler(this.PdfAdTextBox_Click);
            this.PdfAdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PdfAdTextBox_KeyDown);
            this.PdfAdTextBox.Leave += new System.EventHandler(this.PdfAdTextBox_Leave);
            // 
            // BelgeAdPictureBox
            // 
            this.BelgeAdPictureBox.Location = new System.Drawing.Point(296, -2);
            this.BelgeAdPictureBox.Name = "BelgeAdPictureBox";
            this.BelgeAdPictureBox.Size = new System.Drawing.Size(42, 40);
            this.BelgeAdPictureBox.TabIndex = 35;
            this.BelgeAdPictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(2, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Yeni Belge Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.label9.Location = new System.Drawing.Point(434, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "PDF ŞİFRELE";
            // 
            // CikisYolPictureBox
            // 
            this.CikisYolPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CikisYolPictureBox.Image")));
            this.CikisYolPictureBox.Location = new System.Drawing.Point(185, 581);
            this.CikisYolPictureBox.Name = "CikisYolPictureBox";
            this.CikisYolPictureBox.Size = new System.Drawing.Size(42, 40);
            this.CikisYolPictureBox.TabIndex = 38;
            this.CikisYolPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyAppV1.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 32);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.ImageKey = "(none)";
            this.button9.Location = new System.Drawing.Point(715, 628);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(297, 71);
            this.button9.TabIndex = 8;
            this.button9.Text = "          PDF DOSYASINI ŞİFRELE";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // HepsiniSil_Btn
            // 
            this.HepsiniSil_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.HepsiniSil_Btn.BackgroundImage = global::MyAppV1.Properties.Resources.DeleteIcon;
            this.HepsiniSil_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HepsiniSil_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HepsiniSil_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HepsiniSil_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HepsiniSil_Btn.ImageKey = "(none)";
            this.HepsiniSil_Btn.Location = new System.Drawing.Point(523, 47);
            this.HepsiniSil_Btn.Name = "HepsiniSil_Btn";
            this.HepsiniSil_Btn.Size = new System.Drawing.Size(158, 48);
            this.HepsiniSil_Btn.TabIndex = 3;
            this.HepsiniSil_Btn.Text = "      Hepsini Sil";
            this.HepsiniSil_Btn.UseVisualStyleBackColor = false;
            this.HepsiniSil_Btn.Click += new System.EventHandler(this.HepsiniSil_Btn_Click);
            // 
            // Sil_Btn
            // 
            this.Sil_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.Sil_Btn.BackgroundImage = global::MyAppV1.Properties.Resources.DeleteIcon;
            this.Sil_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sil_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sil_Btn.ImageKey = "(none)";
            this.Sil_Btn.Location = new System.Drawing.Point(358, 47);
            this.Sil_Btn.Name = "Sil_Btn";
            this.Sil_Btn.Size = new System.Drawing.Size(158, 48);
            this.Sil_Btn.TabIndex = 2;
            this.Sil_Btn.Text = "Sil";
            this.Sil_Btn.UseVisualStyleBackColor = false;
            this.Sil_Btn.Click += new System.EventHandler(this.Sil_Btn_Click);
            // 
            // KlasörEkle_Btn
            // 
            this.KlasörEkle_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.KlasörEkle_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KlasörEkle_Btn.BackgroundImage")));
            this.KlasörEkle_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KlasörEkle_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KlasörEkle_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KlasörEkle_Btn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.KlasörEkle_Btn.ImageKey = "(none)";
            this.KlasörEkle_Btn.Location = new System.Drawing.Point(193, 47);
            this.KlasörEkle_Btn.Name = "KlasörEkle_Btn";
            this.KlasörEkle_Btn.Size = new System.Drawing.Size(158, 48);
            this.KlasörEkle_Btn.TabIndex = 1;
            this.KlasörEkle_Btn.Text = "        Klasör Ekle";
            this.KlasörEkle_Btn.UseVisualStyleBackColor = false;
            this.KlasörEkle_Btn.Click += new System.EventHandler(this.KlasörEkle_Btn_Click);
            // 
            // PdfOlustur_Btn
            // 
            this.PdfOlustur_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.PdfOlustur_Btn.BackgroundImage = global::MyAppV1.Properties.Resources.PdfIcon;
            this.PdfOlustur_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PdfOlustur_Btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.PdfOlustur_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PdfOlustur_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PdfOlustur_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PdfOlustur_Btn.ImageKey = "(none)";
            this.PdfOlustur_Btn.Location = new System.Drawing.Point(23, 47);
            this.PdfOlustur_Btn.Name = "PdfOlustur_Btn";
            this.PdfOlustur_Btn.Size = new System.Drawing.Size(163, 48);
            this.PdfOlustur_Btn.TabIndex = 0;
            this.PdfOlustur_Btn.Text = "    Pdf Oluştur";
            this.PdfOlustur_Btn.UseVisualStyleBackColor = false;
            this.PdfOlustur_Btn.Click += new System.EventHandler(this.PdfOlustur_Btn_Click);
            // 
            // PdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1031, 719);
            this.Controls.Add(this.CikisYolPictureBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.AyarlarBtn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.HepsiniSil_Btn);
            this.Controls.Add(this.Sil_Btn);
            this.Controls.Add(this.KlasörEkle_Btn);
            this.Controls.Add(this.PdfOlustur_Btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VarsayılanCikisYolRadioBtn);
            this.Controls.Add(this.Arastır_Btn);
            this.Controls.Add(this.CikisYolTextBox);
            this.Controls.Add(this.CikisYolRadioBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PdfListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PdfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PdfForm";
            this.Load += new System.EventHandler(this.PdfForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SifreleTurleriPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YöneticiSifrePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciSifrePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelgeAdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CikisYolPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView PdfListView;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField KullaniciSifreTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField YöneticiSifreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRadioButton CikisYolRadioBtn;
        private System.Windows.Forms.Button Arastır_Btn;
        private MaterialSkin.Controls.MaterialRadioButton VarsayılanCikisYolRadioBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PdfOlustur_Btn;
        private System.Windows.Forms.Button KlasörEkle_Btn;
        private System.Windows.Forms.Button Sil_Btn;
        private System.Windows.Forms.Button HepsiniSil_Btn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button AyarlarBtn;
        private System.Windows.Forms.Button button9;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton AESEncrypt128Checkbox;
        private MaterialSkin.Controls.MaterialRadioButton StandardEncryp128CheckBox;
        private MaterialSkin.Controls.MaterialRadioButton StandardEncryp40CheckBox;
        private MaterialSkin.Controls.MaterialCheckBox BelgeBirlestirCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox ErisebilirİCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox FormDoldurCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox EkAcıklamaECheckBox;
        private MaterialSkin.Controls.MaterialCheckBox İcerikDegistirCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox İcerikKopyalaCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox BelgeYazdırCheckBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qwewqeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField PdfAdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox BelgeAdPictureBox;
        private System.Windows.Forms.PictureBox YöneticiSifrePictureBox;
        private System.Windows.Forms.PictureBox KullaniciSifrePictureBox;
        private System.Windows.Forms.PictureBox SifreleTurleriPictureBox;
        private System.Windows.Forms.PictureBox CikisYolPictureBox;
        public System.Windows.Forms.TextBox CikisYolTextBox;
    }
}