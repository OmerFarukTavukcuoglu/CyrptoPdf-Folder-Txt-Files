using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
             pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = MyAppV1.Properties.Resources.TXT;
            pictureBox2.Image = MyAppV1.Properties.Resources.PDF;
            pictureBox3.Image = MyAppV1.Properties.Resources.FOLDER;

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
        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // Baslik
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // sag alt
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
         ExitLabel.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#1e1f26");

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TextCryptoForm txtCryp = new TextCryptoForm();
            txtCryp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PdfForm pdfrm = new PdfForm();
            pdfrm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FolderForm ff = new FolderForm();
            ff.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SolAltRenkPictureBox.BackColor = Color.DarkRed;
            // this.Cursor = new Cursor(GetType(), "MyCursor.cur");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SolAltRenkPictureBox.BackColor = col;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            OrtaAltRenkPictureBox.BackColor = Color.DarkRed;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            OrtaAltRenkPictureBox.BackColor = col;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SağAltRenkPictureBox.BackColor = Color.DarkRed;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SağAltRenkPictureBox.BackColor = col;
        }

        private void label4_Click(object sender, EventArgs e)
        {
           if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void MinimizeLabel_MouseEnter(object sender, EventArgs e)
        {
            MinimizeLabel.ForeColor = Color.White;
        }

        private void MinimizeLabel_MouseLeave(object sender, EventArgs e)
        {
            MinimizeLabel.ForeColor = Color.Black;
        }
    }
}
