using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppV1
{
    public partial class FolderForm : Form
    {
        public FolderForm()
        {
            InitializeComponent();
            label3.Visible = false;
        }
        private const int cGrip = 16;      // boyut
        private const int cCaption = 32;   // baslik üst bar 

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkRed, rc);
        }

      

        private void Arastır_Btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderB = new FolderBrowserDialog();
            if (FolderB.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = FolderB.SelectedPath;
            }
        }
        string hata = null;
        private void KilitAcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = textBox1.Text;
                string adminUserName = Environment.UserName;
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                ds.RemoveAccessRule(fsa);
                Directory.SetAccessControl(folderPath, ds);
                label3.Visible = true;
                DurumPictureBox.Visible = true;

                label3.Text = "";
                label3.Text += "Kilit Açma İşlemi Başarılı!";
                DurumPictureBox.BackgroundImageLayout = ImageLayout.Center;

                DurumPictureBox.BackgroundImage = Properties.Resources.Unlocked;
                timer1.Start();
            }
            catch (Exception ex)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Öncelikle Klasörü Seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                hata = ex.ToString();
            }
        }

        private void KilitleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = textBox1.Text;
                string adminUserName = Environment.UserName;
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                ds.AddAccessRule(fsa);
                Directory.SetAccessControl(folderPath, ds);
                label3.Visible = true;
                DurumPictureBox.Visible = true;
                label3.Text = "";
                label3.Text += "Kilitleme İşlemi Başarılı!";
                DurumPictureBox.BackgroundImageLayout = ImageLayout.Center;

                DurumPictureBox.BackgroundImage = Properties.Resources.Locked;
                timer1.Start();

            }
            catch (Exception ex)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Öncelikle Klasörü Seçin!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                hata = ex.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Anaform = new Form1();
            Anaform.Show();
            this.Hide();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int deger = 0;
            for(int x =0; x<5000; x++)
            {
                deger = x;
            }
            if(deger ==4999)
            {
                label3.Visible = false;
                DurumPictureBox.Visible = false;
            }
        }
    }
}
