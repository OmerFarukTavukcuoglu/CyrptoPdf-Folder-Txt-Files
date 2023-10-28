using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppV1
{
    public partial class TextCryptoForm : Form
    {

        /*İzlenecek Adımlar
         * 
         * ------METİN ŞİFRELERKEN-----
         * Şifrelenmesi istenilen Metin Girilmeli
         * Anahtar Oluşturulmalı
         * Şifrele Butonuna basıp Kaydedilmesi Gereken konumu Seçip Kaydedilmeli
         * 
         * -------ŞİFRELİ METİNİ AÇARKEN-----
         * Şifrelenmiş Metini Sürükleyip Veyahut Metin Aç Butonu Yardımıyla Şifrelenmiş Metin ,text alanında açılmalı
         * Şifrelenmiş Metinin Deşifre olabilmesi için Metini Şifrelerken kullanılan anahtar girilmeli
         * Şifrelenmiş Metin Ve Şifreli Metine Ait Anahtar girildiği taktirde Şifre Çöz Butonu ile Metin Başarıyla Deşifre Edilir
         * */
        OpenFileDialog openFile = new OpenFileDialog();

        public TextCryptoForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
          
            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);
            richTextBox1.DragEnter += new DragEventHandler(richTextBox1_DragEnter);
         
            pictureBox2.Image = MyAppV1.Properties.Resources.SecurityMan;

            pictureBox3.Image = MyAppV1.Properties.Resources.SecurityMan;
           

            MetinAcBtn.Image = MyAppV1.Properties.Resources.KlasörPic;
            MetinAcBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AnahtarOlstrBtn.Image = MyAppV1.Properties.Resources.KeyPicture;
            AnahtarOlstrBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SifreleBtn.Image = MyAppV1.Properties.Resources.Locked;
            SifreleBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SifreCözBtn.Image = MyAppV1.Properties.Resources.Unlocked;
            SifreCözBtn.ImageAlign = ContentAlignment.MiddleLeft;
        }



        private const int cGrip = 12;
        private const int cCaption = 28;

        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Rectangle rc = new System.Drawing.Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new System.Drawing.Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkRed, rc);
        }

        /*  protected override void WndProc(ref Message m)
          {
              if (m.Msg == 0x84)
              {  // Trap WM_NCHITTEST
                  Point pos = new Point(m.LParam.ToInt32());
                  pos = this.PointToClient(pos);
                  if (pos.Y < cCaption)
                  {
                      m.Result = (IntPtr)2;  // HTCAPTION
                      return;
                  }
                  if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                  {
                      m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                      return;
                  }
              }
              base.WndProc(ref m);
          }*/

        private string getFileName(string file)
        {
            return Path.GetFileNameWithoutExtension(file);
        }

        public void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = e.Data.GetData(DataFormats.FileDrop) as string[];

 

            if (fileName != null)
            {
                foreach (string name in fileName)
                {
                    try
                    {
                        string filename = getFileName(name);
                        richTextBox1.Text = null;
                        richTextBox1.AppendText(File.ReadAllText(name));
                        MetinTxtBox.Text = filename;
                        mail.dosyaAdi = MetinTxtBox.Text;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Geçersiz Dosya", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void richTextBox1_DragEnter(object sender, DragEventArgs e)
        {
          if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
        }



        internal const string Inputkey = "560A18CD-6346-4CF0-A2E8-671F9B6B9EA9";

        #region Rijndael Encryption


        /// <param name="text" />The text to encrypt
        /// <param name="salt" />The pasword salt

        public static string EncryptRijndael(string text, string salt)
        {
            if (string.IsNullOrEmpty(text))
                MessageBox.Show("Metin Boş Olamaz.Lütfen Doldurup Tekrar Deneyin");

            var aesAlg = NewRijndaelManaged(salt);

            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            var msEncrypt = new MemoryStream();
            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(text);
            }

            return Convert.ToBase64String(msEncrypt.ToArray());
        }
        #endregion

        #region Rijndael Dycryption

        /// <param name="base64String" />The base64 encoded string

        public static bool IsBase64String(string base64String)
        {
            base64String = base64String.Trim();
            return (base64String.Length % 4 == 0) &&
                   Regex.IsMatch(base64String, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

        }


        /// <param name="cipherText" />The encrypted BASE64 text
        /// <param name="salt" />The pasword salt

        public string DecryptRijndael(string cipherText, string salt)
        {

            if (string.IsNullOrEmpty(cipherText))
                MessageBox.Show("Şifrelenmiş Metin Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!IsBase64String(cipherText))
                throw new Exception("Şifreli Metin girdi parametresi base64 kodlanmış değil!");

            string text;

            var aesAlg = NewRijndaelManaged(salt);
            var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            var cipher = Convert.FromBase64String(cipherText);

            using (var msDecrypt = new MemoryStream(cipher))
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        text = srDecrypt.ReadToEnd();
                    }
                }
            }
            return text;
        }
        #endregion

        #region NewRijndaelManaged
        /// <param name="salt" />The pasword salt

        private static RijndaelManaged NewRijndaelManaged(string salt)
        {
            if (salt == null) throw new ArgumentNullException("salt");
            var saltBytes = Encoding.ASCII.GetBytes(salt);
            var key = new Rfc2898DeriveBytes(Inputkey, saltBytes);

            var aesAlg = new RijndaelManaged();
            aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
            aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

            return aesAlg;
        }

        #endregion
        private static Random random = new Random();

        #region Region Deneme
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
          
        } 
#endregion
        private void AnahtarOlstrBtn_Click(object sender, EventArgs e)
        {
           AnahtarTextBox.Text = RandomString(8);
           AnahtarTextBox.Text += "-";
            AnahtarTextBox.Text += RandomString(4);
            AnahtarTextBox.Text += "-";
            AnahtarTextBox.Text += RandomString(4);
            AnahtarTextBox.Text += "-";
            AnahtarTextBox.Text += RandomString(4);
            AnahtarTextBox.Text += "-";
            AnahtarTextBox.Text += RandomString(12);
       

            // textBox3.Text = Inputkey;

        }
   
        SaveFileDialog save = new SaveFileDialog();
        MailForm mail = new MailForm();
        public void SifreleBtn_Click(object sender, EventArgs e)
        {
            save.Filter = "Text Files | *.txt";
            save.DefaultExt = "txt";
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Metin Boş Olamaz.Lütfen Doldurup Tekrar Deneyin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(richTextBox1.Text != "" && AnahtarTextBox.Text =="")
            { MessageBox.Show("Anahtar Boş Bırakılamaz! Yeni Bir Anahtar Oluşturmayı Deneyin.","Anahtar Oluşturma",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            else if(richTextBox1.Text != "" && AnahtarTextBox.Text != "")
            {
                if (MetinTxtBox.Text == "") MessageBox.Show("İsim Boş Geçilemez");
                else
                {
                    save.FileName = MetinTxtBox.Text;
                    if(save.ShowDialog()==DialogResult.OK)
                    {
                        StreamWriter Kayit = new StreamWriter(save.FileName);
                        var x = EncryptRijndael(richTextBox1.Text, AnahtarTextBox.Text);
                        Kayit.WriteLine(x);
                        Kayit.Dispose();
                        Kayit.Close();
                        mail.sifreliİcerik = x.ToString();
                        mail.anahtar = AnahtarTextBox.Text;
                        mail.dosyaAdi = MetinTxtBox.Text;
                        richTextBox1.Text = "";
                        AnahtarTextBox.Text = "";
                        MetinTxtBox.Text = "";
                        mail.Show();

         //               MessageBox.Show("  Dosya Başarıyla Kaydedildi.\n \n(Unutma bu şifreli dosyayı açabilmen için Dosyanın şifreli halini ve Anahtarını Girmelisin!)", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                       
                     else
                     {
                            MessageBox.Show("Dosya Kayıt İşlemi Başarısız!", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                    /*
                    catch (Exception)
                    {
                        MessageBox.Show("Kayıt İşlemi Başarısız!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        richTextBox1.Clear();
                        textBox3.Clear();
                    }*/
                }                              
            }
        }
        string filePath;
         private void SifreCözBtn_Click(object sender, EventArgs e)
        {
            /*if (richTextBox1.Text == "")
            {
                MessageBox.Show("Metin Boş Olamaz.Lütfen Doldurup Tekrar Deneyin");
            }
            else if (richTextBox1.Text != "" && textBox3.Text == "")
            { MessageBox.Show("Anahtar Boş Bırakılamaz! Yeni Bir Anahtar Oluşturmayı Deneyin"); }
            else if (richTextBox1.Text != "" && textBox3.Text != "")
            {                             
            }*/
            if(AnahtarTextBox.Text == "") { MessageBox.Show(" Anahtar Boş Bırakılamaz! \n Şifrelenmiş Metine Ait Anahtarı Girin.","Boş Anahtar",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            else
            {
                try
                {
                    if (richTextBox1.Text=="")
                    {
                        openFile.ShowDialog();
                        filePath = openFile.FileName;
                        StreamReader sr = new StreamReader(openFile.FileName);
                        richTextBox1.Text = sr.ReadToEnd();
                        richTextBox1.Text = DecryptRijndael(richTextBox1.Text, AnahtarTextBox.Text);
                    }
                    
                    richTextBox1.Text = DecryptRijndael(richTextBox1.Text, AnahtarTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya Açma İşlemi Başarısız!","Dosya Açma",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    richTextBox1.Clear();
                   // textBox3.Clear();
                }
            }
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Anaform = new Form1();
            Anaform.Show();
            this.Hide();
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

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
          //  label2.Visible = false;
        }

        private void MetinAcBtn_Click(object sender, EventArgs e)
        {

            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                label2.Visible = false;
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            using (StreamReader sr = new StreamReader(myStream))
                            {
                                // Stream oku ve okunan string'i yaz
                                string line = sr.ReadToEnd();
                              this.richTextBox1.Text=  line.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        int x = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            timer1.Interval = 300;
            if(x==10)
            {
                label2.Visible = false;
                label2.Enabled = false;
            }
        }

        private void TextCryptoForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}