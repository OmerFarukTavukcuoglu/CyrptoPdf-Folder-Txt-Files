using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppV1
{
    public partial class MailForm : Form
    {
        public string dosyaAdi;
        public string sifreliİcerik;
        public string anahtar;
        public bool gönderim = false;

        public MailForm()
        {
           
            InitializeComponent();
            
            this.Height = 170;
            MailImageBox.Image = MyAppV1.Properties.Resources.Mail_black;
            SuccessImageBox.Image = MyAppV1.Properties.Resources.Complete;

            var skin = MaterialSkinManager.Instance;
            //skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(Primary.Brown300, Primary.Brown200, Primary.Amber300, Accent.DeepPurple400, TextShade.BLACK);

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

  //          MessageBox.Show("  Dosya Başarıyla Kaydedildi.\n \n(Unutma bu şifreli dosyayı açabilmen için Dosyanın şifreli halini ve Anahtarını Girmelisin!)", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BilgiLabel.Text = " Unutma bu şifreli dosyayı açabilmen için \n Dosyanın şifreli halini ve Anahtarını Girmelisin!";
         }

        private void MailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(MailCheckBox.Checked)
            { this.Height = 280; }
            else
            {
                this.Height = 170;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#7E57C2");
            GönderBtn.ForeColor = color;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            GönderBtn.ForeColor = Color.Black;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#7E57C2");

            MailTextBox.BackColor = color;
        }

        bool mailtext;
        private void MailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            int sonuc = MailTextBox.Text.IndexOf("@");
           /* string deger = x.Substring(Convert.ToInt32(sonuc)).ToString();
            string metin = textBox1.Text;*/
           if(sonuc != -1)
            {
                textBox1.Visible = false;
                MailTextBox.Width = 320;
                mailtext = true;
            }
            else 
            {
                textBox1.Visible = true;
                MailTextBox.Width = 244;
                mailtext = false;
            }

        }

        ToolTip Aciklama = new ToolTip();
        private void GönderBtn_Click(object sender, EventArgs e)
        {
            TextCryptoForm TextCryptoForm = new TextCryptoForm();

            if (MailTextBox.Text != "")
            {
                try
                {
                      MailMessage message = new MailMessage();
                      SmtpClient istemci = new SmtpClient();
                      istemci.DeliveryMethod = SmtpDeliveryMethod.Network;
                      istemci.UseDefaultCredentials = false;
                      istemci.Credentials = new System.Net.NetworkCredential("CryptographyApplication@gmail.com", "MyPassword.=**C");
                      istemci.Port = 587;
                      istemci.Host = "smtp.gmail.com";
                      istemci.EnableSsl = true;
                    if (mailtext == true)
                    {
                        message.To.Add(MailTextBox.Text ); //Hangi Mail Adresine Gönderileceği
                    }
                    else
                    {
                        message.To.Add(MailTextBox.Text + textBox1.Text);
                    }
                   



                     message.From = new MailAddress("CryptographyApplication@gmail.com"); //Mesajın Kimden Gittiği
                      message.Subject = "AppCrypto";
                      message.Body = "Dosya Adı:   " + dosyaAdi + "\nŞifreli İcerik:   " + sifreliİcerik + "\n" + "Anahtar:   " + anahtar;
                      istemci.Send(message);
                      MessageBox.Show("Mail Gönderim İşlemi Başarıyla Gerçekleştirildi!","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MessageBox.Show(mailtext.ToString());
                     
                    gönderim = true;                  
                   this.Hide();

                }
                catch (Exception)
                {
                    MessageBox.Show("Geçersiz Mail Adresi  \nLütfen Tekrar Deneyin.");
                }
            }
            else { MessageBox.Show("Lütfen Gerekli Mail Adresinizi Giriniz.","Boş Geçilemez",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            
            /*

            catch (ArgumentException x) when (x.ParamName == "…")
            {
              
            }
            catch (FileNotFoundException)
            {
                // FileNotFoundExceptions are handled here.  
                MessageBox.Show("FileNotFoundException");
            }
            catch (InvalidCastException x)
            {
                if (x.Data == null)
                {
                    MessageBox.Show("InvalidCastException");
                }
                else
                {
                    // Take some action.  
                }
            }*/

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            
        }
        bool uyarı = false;
        public void MailCheckBox_MouseHover(object sender, EventArgs e)
        {
 
            if (uyarı == false)
            {
                Aciklama.ToolTipTitle = "Önerilir ";
                Aciklama.ToolTipIcon = ToolTipIcon.Warning;
                Aciklama.IsBalloon = true;

                Aciklama.SetToolTip(MailCheckBox, " ");
                uyarı = true;
            }
            else if(uyarı == true)
            {
                Aciklama.Dispose();
            }
          


        }

        public void MailForm_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
