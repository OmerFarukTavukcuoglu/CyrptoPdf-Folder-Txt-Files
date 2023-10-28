using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading;

namespace MyAppV1
{
    public partial class PdfForm : Form
    {
        public PdfForm()
        {
            InitializeComponent();
            var skin = MaterialSkinManager.Instance;
            //skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(Primary.Brown300, Primary.Brown200, Primary.Amber300, Accent.DeepOrange700, TextShade.BLACK);

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            BelgeAdPictureBox.Image = null;
            KullaniciSifrePictureBox.Image = null;
            YöneticiSifrePictureBox.Image = null;
            CikisYolPictureBox.Image = null;
            //  PdfOlustur_Btn.ImageAlign = ContentAlignment.MiddleRight;
            // PdfOlustur_Btn.BackgroundImage = MyAppV1.Properties.Resources.FolderPic;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
       


        }
        bool basari = false;

        private const int cGrip = 12;
        private const int cCaption = 28;

        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Rectangle rc = new System.Drawing.Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new System.Drawing.Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkRed, rc);
        }

        /* protected override void WndProc(ref Message m)
         {
             if (m.Msg == 0x84)
             {  
                 Point pos = new Point(m.LParam.ToInt32());
                 pos = this.PointToClient(pos);
                 if (pos.Y < cCaption)
                 {
                     m.Result = (IntPtr)2; 
                     return;
                 }
                 if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                 {
                     m.Result = (IntPtr)17; 
                     return;
                 }
             }
             base.WndProc(ref m);
         }*/



        bool userpwd = false;
        bool ownerpwd = false;
        bool PdfName = false;
        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            if (userpwd == false) KullaniciSifreTextBox.Text = null;
            userpwd = true;
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            if (ownerpwd == false) YöneticiSifreTextBox.Text = null;
            ownerpwd = true;
        }
        private void PdfAdTextBox_Click(object sender, EventArgs e)
        {
            if (PdfName == false) PdfAdTextBox.Text = null;
            PdfName = true;

        }


        string dosyaYolu;
        string path = "";
        string filePath;
        int numberOfPages = 0;
        private string PdfAc()
        {

            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "Pdf Dosyası|*.pdf";
                // Dosya Yolu Kontrol.
                if (Directory.Exists(path))
                {
                    openfile.InitialDirectory = path;
                }
                else
                {
                    openfile.InitialDirectory = @"C:\";
                }

                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    filePath = openfile.FileName;
                    dosyaYolu = Path.GetFileName(filePath);
                    FileInfo info = new FileInfo(filePath);
                    long dosyaBoyutu = info.Length;
                    FormatBytes(dosyaBoyutu);
                    PdfReader pdfReader = new PdfReader(filePath);
                    numberOfPages = pdfReader.NumberOfPages;

                    string[] arr = new string[4];
                    ListViewItem itm;
                    //add items to ListView
                    arr[0] = dosyaYolu;
                    arr[1] = numberOfPages.ToString();
                    arr[2] = FormatBytes(dosyaBoyutu);
                    arr[3] = filePath;
                    itm = new ListViewItem(arr);
                    PdfListView.FullRowSelect = true; //bütün satırı seç
                    PdfListView.MultiSelect = false; //çoklu secim kaldır
                    PdfListView.GridLines = true; //tablola(çizgi çek)
                    PdfListView.HideSelection = false; //Item seçtikten sonra seçim satırından ayrıldıktan sonra bile seçim olayını devam ettir
                    PdfListView.Items.Add(itm);



                }
            }

            catch (Exception e) when (e.Message == "Bad user password")
            {
                MessageBox.Show("Bu Dosya Zaten Şifrelenmiş");
                if (e.Message == "PDF header signature not found" || e is PdfException)
                {
                    MessageBox.Show("Bozuk Dosya");
                    throw;
                }
            }
            return dosyaYolu;
        }

        bool kontrol;

        //1 Tık Geçersiz ! Giderilmesi Gereken Hata VAR -> Koşul sağlandıktan sonra hata var ------------------------------------------
        /*  private void CheckBoxControls()
          {
              if (StandardEncryp40CheckBox.Checked == false && StandardEncryp128CheckBox.Checked == false && AESEncrypt128Checkbox.Checked == false)
              {
                 SifreleTurleriPictureBox.Image = MyAppV1.Properties.Resources.Warning;
              }
              if(CikisYolTextBox.Text == "")
              {
                  CikisYolPictureBox.Image = MyAppV1.Properties.Resources.Warning;
              }
          }*/



        private bool InputControls(string PdfAd, string KullaniciSifre, string YöneticiSifre, string Cikisyol)
        {
            if (StandardEncryp40CheckBox.Checked == false && StandardEncryp128CheckBox.Checked == false && AESEncrypt128Checkbox.Checked == false)
                SifreleTurleriPictureBox.Image = MyAppV1.Properties.Resources.Warning;

            if (CikisYolTextBox.Text == "")
                CikisYolPictureBox.Image = MyAppV1.Properties.Resources.Warning;

            PdfAd = PdfAdTextBox.Text;
            KullaniciSifre = KullaniciSifreTextBox.Text;
            YöneticiSifre = YöneticiSifreTextBox.Text;
            CikisYol = CikisYolTextBox.Text;

            if (PdfAd == "Belge Ad" || KullaniciSifre == "Şifreyi Gir" || YöneticiSifre == "Şifreyi Gir" || PdfAd == "" || KullaniciSifre == "" || YöneticiSifre == "" ||
                StandardEncryp128CheckBox.Checked == false && StandardEncryp40CheckBox.Checked == false && AESEncrypt128Checkbox.Checked == false)
            {
                if (PdfAd == "Belge Ad" || PdfAd == "")
                    BelgeAdPictureBox.Image = MyAppV1.Properties.Resources.Warning;
                else
                    BelgeAdPictureBox.Image = null;

                if (KullaniciSifre == "Şifreyi Gir" || KullaniciSifre == "")
                    KullaniciSifrePictureBox.Image = MyAppV1.Properties.Resources.Warning;
                else
                    KullaniciSifrePictureBox.Image = null;

                if (YöneticiSifre == "Sifreyi Gir" || YöneticiSifre == "")
                    YöneticiSifrePictureBox.Image = MyAppV1.Properties.Resources.Warning;
                else
                    YöneticiSifrePictureBox.Image = null;

                if (CikisYol == "")
                    CikisYolPictureBox.Image = MyAppV1.Properties.Resources.Warning;
                else
                    CikisYolPictureBox.Image = null;

                kontrol = false;
                return kontrol;
            }
            else
            {
                BelgeAdPictureBox.Image = null;
                KullaniciSifrePictureBox.Image = null;
                YöneticiSifrePictureBox.Image = null;
                kontrol = true;
                return kontrol;
            }

        }

        private void Pdf_Cikis_Yol()
        {
            if (kontrol == false)
            {
                InputControls(PdfAdTextBox.Text, KullaniciSifreTextBox.Text, YöneticiSifreTextBox.Text, CikisYolTextBox.Text);
                //       CheckBoxControls();
            }
            if (kontrol == true)
            {
                saveFileDialog1.Filter = "Pdf Dosyası|*.pdf";
                saveFileDialog1.Title = "Save an Image File";


                saveFileDialog1.DefaultExt = "pdf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {



                    if (Directory.Exists(path))
                    {
                        saveFileDialog1.InitialDirectory = path;
                    }
                    else
                    {
                        saveFileDialog1.InitialDirectory = @"C:\";
                    }
                    CikisYolTextBox.Clear();
                    saveFileDialog1.OverwritePrompt = true;
                    saveFileDialog1.CreatePrompt = true;
                    CikisYolTextBox.Text = saveFileDialog1.FileName;
                    if (CikisYolTextBox.Text != "")
                        CikisYolPictureBox.Image = null;
                }
            }

        }

        public enum SifrelemeYöntemleri
        {
            BasicBitsRC4, bitsRC4, bitsAes //10 Sifre
        }
        string[] stringArray = new string[3];

        String text = "";


        string CikisYol;
        private void BelgeizinleriVeSifreleme()
        {
            if (PdfListView.SelectedIndices.Count > 0)
            {
                foreach (ListViewItem items in PdfListView.Items)
                {
                    text = PdfListView.SelectedItems[0].SubItems[3].Text;
                }

                InputControls(PdfAdTextBox.Text, KullaniciSifreTextBox.Text, YöneticiSifreTextBox.Text, CikisYolTextBox.Text);

            }

            else { MessageBox.Show("Şifrelemek İstediğiniz Pdf Dosyasını Seçiniz!", "Dosya Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Dictionary<SifrelemeYöntemleri, string> values = new Dictionary<SifrelemeYöntemleri, string>();

            values.Add(SifrelemeYöntemleri.BasicBitsRC4, İcerikDegistirCheckBox.Text);

            stringArray[0] = "Standard Encryption 40 Bits";
            stringArray[1] = "Standard Encryption 128 Bits";
            stringArray[2] = "AES Encryption 128 Bits";
            try
            {

                byte[] USER = Encoding.ASCII.GetBytes(KullaniciSifreTextBox.Text);
                byte[] OWNER = Encoding.ASCII.GetBytes(YöneticiSifreTextBox.Text);
                if (KullaniciSifreTextBox.Text != YöneticiSifreTextBox.Text)
                {
                    PdfReader reader = new PdfReader(text);
                    if (CikisYolRadioBtn.Checked)
                    {
                        PdfStamper stamper = new PdfStamper(reader, new FileStream(CikisYolTextBox.Text, FileMode.Create));
                        CikisYol = "CikisYol";
                        //Secili Cikisyol STANDARD ENCRYPTO 40 BİTS
                        if (StandardEncryp40CheckBox.Checked && StandardEncryp40CheckBox.Text == stringArray[0] && CikisYolRadioBtn.Checked)
                        {

                            if (BelgeYazdırCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowPrinting, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (İcerikKopyalaCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowCopy, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (İcerikDegistirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyContents, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (EkAcıklamaECheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyAnnotations, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (FormDoldurCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowFillIn, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (BelgeBirlestirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowAssembly, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (ErisebilirİCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            else
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            MessageBox.Show("Pdf Dosyası Başarıyla Şifrelendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            basari = true;
                            stamper.Close();
                        }

                        //Secili Cikisyol STANDARD ENCRYPTO 128 BİTS
                        else if (StandardEncryp128CheckBox.Checked && StandardEncryp128CheckBox.Text == stringArray[1] && CikisYolRadioBtn.Checked)
                        {
                            if (BelgeYazdırCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowPrinting, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (İcerikKopyalaCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowCopy, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (İcerikDegistirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyContents, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (EkAcıklamaECheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyAnnotations, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (FormDoldurCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowFillIn, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (BelgeBirlestirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowAssembly, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (ErisebilirİCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            else
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            stamper.Close();
                            basari = true;

                            MessageBox.Show("Pdf Dosyası Başarıyla Şifrelendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        //Secili Cikisyol AES ENCRYPTO 128 BİTS
                        else if (AESEncrypt128Checkbox.Checked && AESEncrypt128Checkbox.Text == stringArray[2] && CikisYolRadioBtn.Checked)
                        {
                            if (BelgeYazdırCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowPrinting, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (İcerikKopyalaCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowCopy, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (İcerikDegistirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyContents, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (EkAcıklamaECheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyAnnotations, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (FormDoldurCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowFillIn, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (BelgeBirlestirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowAssembly, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (ErisebilirİCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.ENCRYPTION_AES_128);
                            }
                            else
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.ENCRYPTION_AES_128);
                            }
                            stamper.Close();
                            basari = true;

                            MessageBox.Show("Pdf Dosyası Başarıyla Şifrelendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    //Varsayilan Cikisyol STANDARD ENCRYPTO 40 BİTS               
                    else if (VarsayılanCikisYolRadioBtn.Checked)
                    {
                        PdfStamper stamper = new PdfStamper(reader, new FileStream(PdfAdTextBox.Text + ".pdf", FileMode.Create));

                        if (StandardEncryp40CheckBox.Checked && VarsayılanCikisYolRadioBtn.Checked)
                        {

                            if (BelgeYazdırCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowPrinting, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (İcerikKopyalaCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowCopy, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (İcerikDegistirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyContents, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (EkAcıklamaECheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyAnnotations, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (FormDoldurCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowFillIn, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (BelgeBirlestirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowAssembly, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            if (ErisebilirİCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            else
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.STANDARD_ENCRYPTION_40);
                            }
                            basari = true;

                            stamper.Close();
                            MessageBox.Show("Pdf Dosyası Başarıyla Şifrelendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                        //Varsayilan Cikisyol STANDARD ENCRYPTO 128 BİTS
                        else if (StandardEncryp128CheckBox.Checked && VarsayılanCikisYolRadioBtn.Checked)
                        {
                            if (BelgeYazdırCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowPrinting, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (İcerikKopyalaCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowCopy, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (İcerikDegistirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyContents, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (EkAcıklamaECheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyAnnotations, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (FormDoldurCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowFillIn, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (BelgeBirlestirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowAssembly, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (ErisebilirİCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            else
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            basari = true;

                            stamper.Close();
                            MessageBox.Show("Pdf Dosyası Başarıyla Şifrelendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        //Varsayilan Cikisyol AES ENCRYPTO 128 BİTS
                        else if (AESEncrypt128Checkbox.Checked && VarsayılanCikisYolRadioBtn.Checked)
                        {
                            if (BelgeYazdırCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowPrinting, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (İcerikKopyalaCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowCopy, PdfWriter.STANDARD_ENCRYPTION_128);
                            }
                            if (İcerikDegistirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyContents, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (EkAcıklamaECheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowModifyAnnotations, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (FormDoldurCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowFillIn, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (BelgeBirlestirCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowAssembly, PdfWriter.ENCRYPTION_AES_128);
                            }
                            if (ErisebilirİCheckBox.Checked == true)
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.ENCRYPTION_AES_128);
                            }
                            else
                            {
                                stamper.SetEncryption(USER, OWNER, PdfWriter.AllowScreenReaders, PdfWriter.ENCRYPTION_AES_128);
                            }
                            basari = true;

                            stamper.Close();
                            MessageBox.Show("Pdf Dosyası Başarıyla Şifrelendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı ile Yöneticinin Şifreleri Aynı Olamaz!", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
            }

        }

        #region PDFSİFRELEMESİ
        private void PdfSifrele()
         {

             BelgeizinleriVeSifreleme();

            

         }
        #endregion


        private static string FormatBytes(Int64 bytes)
        {
            if (bytes >= 0x1000000000000000) { return ((double)(bytes >> 50) / 1024).ToString("0.### EB"); }
            if (bytes >= 0x4000000000000) { return ((double)(bytes >> 40) / 1024).ToString("0.### PB"); }
            if (bytes >= 0x10000000000) { return ((double)(bytes >> 30) / 1024).ToString("0.### TB"); }
            if (bytes >= 0x40000000) { return ((double)(bytes >> 20) / 1024).ToString("0.### GB"); }
            if (bytes >= 0x100000) { return ((double)(bytes >> 10) / 1024).ToString("0.### MB"); }
            if (bytes >= 0x400) { return ((double)(bytes) / 1024).ToString("0.###") + " KB"; }
            return bytes.ToString("0 Bytes");
        }

        private static long GetDirectorySize(string folderPath)
        {
            DirectoryInfo DInfo = new DirectoryInfo(folderPath);
            return DInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(x => x.Length);
        }


        private void PdfOlustur_Btn_Click(object sender, EventArgs e)
        {
            PdfAc();
        }

        private void IfCryptedSuccess()
        {
            if (basari == true)
            {
                PdfAdTextBox.Text = "";
                KullaniciSifreTextBox.Text = "";
                YöneticiSifreTextBox.Text = "";
                StandardEncryp40CheckBox.Checked = false;
                StandardEncryp128CheckBox.Checked = false;
                AESEncrypt128Checkbox.Checked = false;
                CikisYolTextBox.Clear();
                BelgeYazdırCheckBox.Checked = false;
                İcerikKopyalaCheckBox.Checked = false;
                İcerikDegistirCheckBox.Checked = false;
                EkAcıklamaECheckBox.Checked = false;
                FormDoldurCheckBox.Checked = false;
                BelgeBirlestirCheckBox.Checked = false;
                ErisebilirİCheckBox.Checked = false;
            }
        }

        int n, i, j, cnt;
        private void button9_Click(object sender, EventArgs e)
        {



            /* 
               var item = this.PdfListView.Items.Cast<ListViewItem>()
                .Where(x => (x.Text == "Some Text" ||
                       x.SubItems[1].Text == "Some Text") &&
                       x.Group.Name == "group1")
                .FirstOrDefault();
            MessageBox.Show(item.ToString());
            List<string> liste = new List<string>();
            string[] ar = new string[] { };
            ListViewItem lvi = new ListViewItem();
            
            foreach (ListViewItem item in PdfListView.Items)
                {
                    bool subItemEqualFlag = true;
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        string sub1 = item.SubItems[i].Text;
                        string sub2 = lvi.SubItems[i].Text;
                        if (sub1 != sub2)
                        {
                            subItemEqualFlag = false;
                        }
                    }
                    if (subItemEqualFlag)
                        MessageBox.Show("true");
                }
                MessageBox.Show("false");
                 for (int y = 0; y < PdfListView.Items.Count; y++)
            {

            }
            int[] arr = new int[44];
            int[] dup = new int[] { 2, 6, 8,2 };

            for(i=0; i<n;i++)
            {
                dup[i] = -1;
            }

            for  (i = 0; i<n; i++)
            {
                cnt = 1;
                for (j = i + 1; j < n; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        cnt++;
                        dup[j] = 0;
                    }
                }
                if (dup[i] != 0)
                {
                    dup[i] = cnt;
                }
            }

            for(i=0;i<n;i++)
            {
                if (dup[i] == 1)
                    MessageBox.Show("x");
            }
            */


            /* ListViewItem item1 = PdfListView.FindItemWithText("Rapor3");
            if (item1 != null)
                MessageBox.Show("Calling FindItemWithText passing 'brack': "
                          + item1.ToString());
            else
                MessageBox.Show("Calling FindItemWithText passing 'brack': null");*/



            //Throw error message*/

            /*        for (int i = 0; i < PdfListView.Items.Count; i++)
            {

                liste.Add(PdfListView.Items[i].ToString());

                string d = liste.Select(p => p.ToString()).ToString();
                MessageBox.Show(d);

            }*/











            if (PdfListView.Items.Count > 0)
            {
                InputControls(PdfAdTextBox.Text, KullaniciSifreTextBox.Text, YöneticiSifreTextBox.Text, CikisYolTextBox.Text);
                //  CheckBoxControls();

                if (VarsayılanCikisYolRadioBtn.Checked)
                {
                    InputControls(PdfAdTextBox.Text, KullaniciSifreTextBox.Text, YöneticiSifreTextBox.Text, CikisYolTextBox.Text);
                    {
                        //         CheckBoxControls();
                        BelgeizinleriVeSifreleme();
                        IfCryptedSuccess();
                    }

                }
                else if (CikisYolRadioBtn.Checked)
                {
                    if (InputControls(PdfAdTextBox.Text, KullaniciSifreTextBox.Text, YöneticiSifreTextBox.Text, CikisYolTextBox.Text)
  && kontrol == true)
                    {
                        //     CheckBoxControls();
                        BelgeizinleriVeSifreleme();
                        IfCryptedSuccess();

                    }
                }

                else if (CikisYolRadioBtn.Checked && CikisYolTextBox.Text == "")
                {
                    CikisYolPictureBox.Image = MyAppV1.Properties.Resources.Warning;
                }
                else if (VarsayılanCikisYolRadioBtn.Checked)
                {
                    CikisYolPictureBox.Image = null;
                }
                else
                {
                    PdfSifrele();
                    if (basari == true)
                    {
                        PdfAdTextBox.Text = "Belge Ad";
                        KullaniciSifreTextBox.Text = "Şifreyi Gir";
                        YöneticiSifreTextBox.Text = "Şifreyi Gir";
                        StandardEncryp40CheckBox.Checked = false;
                        StandardEncryp128CheckBox.Checked = false;
                        AESEncrypt128Checkbox.Checked = false;
                        CikisYolTextBox.Clear();
                    }

                }
            }
            else { MessageBox.Show("Öncelikle Pdf Dosyası Oluşturmalısınız.", "Pdf Dosyası", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        


        }

        private void Sil_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                PdfListView.Items.RemoveAt(PdfListView.SelectedItems[0].Index);
            }
            catch (Exception)
            {

                MessageBox.Show("Silinmesini İstediğiniz Dosyayı Seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Arastır_Btn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = PdfAdTextBox.Text;
           

            Pdf_Cikis_Yol();

        }

        private void PdfForm_Load(object sender, EventArgs e)
        {
            CikisYolRadioBtn.Checked = true;
            
        }

        private void HepsiniSil_Btn_Click(object sender, EventArgs e)
        {
            if (PdfListView.Items.Count > 0)
            {
                PdfListView.Items.Clear();
            }
            else
            {
                MessageBox.Show("Dosya Bulunamadı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void PdfListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (PdfListView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }


        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfListView.Items.RemoveAt(PdfListView.SelectedItems[0].Index);
        }

        private void qwewqeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            string DosyaYol = PdfListView.SelectedItems[0].SubItems[3].Text;
            prc.StartInfo.FileName = Path.GetDirectoryName(DosyaYol);
            prc.Start();
        }

        private void KlasörEkle_Btn_Click(object sender, EventArgs e)
        {       
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();          
            folderBrowserDialog1.Description =
            "Varsayılan olarak kullanmak istediğin dizini seç.";


            //this.listView1.View = View.LargeIcon;
            // this.listView1.LargeImageList = new ImageList() { ImageSize = new Size(64, 64) };
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var PdfFiles = from file in Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath)
                                 let extension = Path.GetExtension(file)                              
                                 where extension.Equals(".pdf") || extension.Equals(".pdf")
                                 select file;
                // string dosyaAdi = Path.GetFileName(imageFiles.ToString());
                string dosyaAdi = null;
               // int imageIndex = 0;
                long dosyaBoyutu = 0;
                try
                {
                    foreach (string PdfFile in PdfFiles)
                    {
                        dosyaAdi = Path.GetFileName(PdfFile);

                        //    PdfListView.Items.Add(null, imageIndex++);
                        FileInfo info = new FileInfo(PdfFile);
                        dosyaBoyutu = info.Length;
                        FormatBytes(dosyaBoyutu);

                        PdfReader pdfReader = new PdfReader(PdfFile);
                        numberOfPages = pdfReader.NumberOfPages;


                        string[] arr = new string[4];
                        ListViewItem itm;
                        //Listview 'e item ekleme
                        arr[0] = dosyaAdi;
                        arr[1] = numberOfPages.ToString();
                        arr[2] = FormatBytes(dosyaBoyutu);
                        arr[3] = PdfFile.ToString();
                        itm = new ListViewItem(arr);
                        PdfListView.Items.Add(itm);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Klasör İçerisinde Şifreli Dosya Olmaması Gerekiyor!","Klasör Açma Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);                 
                }
             }
                

            }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();           
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.left_arroWhite;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.left_arrow;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versiyon: 1.5.1.4");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Anaform = new Form1();
            Anaform.Show();
            this.Hide();
        }

        private void StandardEncryp40CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SifreleTurleriPictureBox.Image = null;
        }

        private void StandardEncryp128CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SifreleTurleriPictureBox.Image = null;
        }

        private void AESEncrypt128Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            SifreleTurleriPictureBox.Image = null;
        }

        private void PdfAdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (PdfAdTextBox.Text == "Belge Ad" || PdfAdTextBox.Text == " ")
                BelgeAdPictureBox.Image = MyAppV1.Properties.Resources.Warning;
            else
                BelgeAdPictureBox.Image = null;
        }

        private void KullaniciSifreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (KullaniciSifreTextBox.Text == "Belge Ad" || KullaniciSifreTextBox.Text == " ")
                KullaniciSifrePictureBox.Image = MyAppV1.Properties.Resources.Warning;
            else
                KullaniciSifrePictureBox.Image = null;
        }

        private void YöneticiSifreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (YöneticiSifreTextBox.Text == "Belge Ad" || YöneticiSifreTextBox.Text == "")
                YöneticiSifrePictureBox.Image = MyAppV1.Properties.Resources.Warning;
            else
                YöneticiSifrePictureBox.Image = null;
         
        }

        private void VarsayılanCikisYolRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            CikisYolPictureBox.Image = null;
        }

        private void KullaniciSifreTextBox_Leave(object sender, EventArgs e)
        {
            if (KullaniciSifreTextBox.Text == "Belge Ad" || KullaniciSifreTextBox.Text == "")
                KullaniciSifrePictureBox.Image = MyAppV1.Properties.Resources.Warning;
            else
                KullaniciSifrePictureBox.Image = null;
        
        }

        private void YöneticiSifreTextBox_Leave(object sender, EventArgs e)
        {
            if (YöneticiSifreTextBox.Text == "Belge Ad" || YöneticiSifreTextBox.Text == "")
                YöneticiSifrePictureBox.Image = MyAppV1.Properties.Resources.Warning;
            else
                YöneticiSifrePictureBox.Image = null;
        }

        private void PdfAdTextBox_Leave(object sender, EventArgs e)
        {
            //       InputControls(PdfAdTextBox.Text, KullaniciSifreTextBox.Text, YöneticiSifreTextBox.Text, CikisYolTextBox.Text);
            if (PdfAdTextBox.Text == "Belge Ad" || PdfAdTextBox.Text == "")
                BelgeAdPictureBox.Image = MyAppV1.Properties.Resources.Warning;
            else
                BelgeAdPictureBox.Image = null;
        }
    }
    }
 
