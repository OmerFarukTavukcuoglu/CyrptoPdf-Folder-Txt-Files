using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppV1
{
    public partial class TxtForm : Form
    {
        public TxtForm()
        {
            InitializeComponent();
            var skin = MaterialSkinManager.Instance;
            //   skin.AddFormToManage(this);
            /*skin.Theme = MaterialSkinManager.Themes.;*/
            skin.ColorScheme = new ColorScheme(Primary.Brown300, Primary.Brown200, Primary.Amber300, Accent.Red700, TextShade.BLACK);

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);


            //  PdfOlustur_Btn.ImageAlign = ContentAlignment.MiddleRight;
            // PdfOlustur_Btn.BackgroundImage = MyAppV1.Properties.Resources.FolderPic;
            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);
        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e )
        {
            string[] fileName = e.Data.GetData(DataFormats.FileDrop) as string[];

            if (fileName != null)
            {
                foreach (string name in fileName)
                {
                    try
                    {
                        richTextBox1.Text = null;
                        richTextBox1.AppendText(File.ReadAllText(name));
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Geçersiz Dosya", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
        private const int cGrip = 12;      // Grip size
        private const int cCaption = 28;   // Caption bar height;

        public FormBorderStyle FormBorderStyle { get; }

        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Rectangle rc = new System.Drawing.Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new System.Drawing.Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkRed, rc);
        }

        protected override void WndProc(ref Message m)
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
        }

        public enum SifrelemeYöntemleri
        {
            BasicCrpyto, MD5, SHA1, SHA256, SHA384, SHA512, DES, Triple_DES, RC2, Rijndael //10 Sifre
        }

        public enum HashSifrelemeYöntem
        {
            MD5, SHA1, SHA256, SHA384, SHA512
        }

        public enum SimetrikSifrelemeYöntem
        {
            BasicCrypto, DES, Triple_DES, RC2, Rijndael
        }

        public enum AsimetrikSifrelemeYöntem
        {
            DSA, RSA
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // secimlabel.Visible = false;
            AllMethodCombobox();
        }
        public void BasicCrypto()
        {
             BasicCryptoMethod bcm = new BasicCryptoMethod();  
            string x = bcm.BasicEnCryp(this.richTextBox1.Text);
            MessageBox.Show(x);
        }
        public void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //secimlabel.Visible = true;
      //      secimlabel.Text = "Seçilen Yöntem : " + this.SifreYontemComboBox.SelectedItem.ToString();
        }

        public enum Operator
        {
            PLUS, MINUS, MULTIPLY, DIVIDE
        }

        protected void HashMetodSecim()
        {
            int val = SifreYontemComboBox.SelectedIndex;
            switch (val)
            {
                case 0://MD5
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;

                case 1://SHA1
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;
                case 2://SHA256
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;

                case 3://SHA384
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;
                case 4://SHA512
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;
            }

        }


        protected void SimetrikMethodSecim()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyası|*.txt";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;


            int val = SifreYontemComboBox.SelectedIndex;
            switch (val)
            {
                case 0://Basic Crypt
                        BasicCryptoMethod BCM = new BasicCryptoMethod();
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                      var x = BCM.BasicEnCryp(richTextBox1.Text+"ppr");
                        MessageBox.Show(x);
                        StreamWriter Kayit = new StreamWriter(save.FileName);
                       Kayit.WriteLine(x);
                        Kayit.Close();
                    }
                    break;
                case 1://DES
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;

                case 2://Triple_DES
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;

                case 3://RC2
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;

                case 4://Rijndael
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;
            }

        }

        protected void DeSimetrikMethodSecim()
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Metin Dosyası|*.txt";

            string filePath;
            int val = SifreYontemComboBox.SelectedIndex;
            switch (val)
            {

                case 0://Basic Crypt
                   BasicCryptoMethod BCM = new BasicCryptoMethod();
                    if (openfile.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.Text = null;
                        filePath = openfile.FileName;
                        StreamReader sr = new StreamReader(openfile.FileName);
                        richTextBox1.Text = sr.ReadToEnd();
                        string desifreli = BCM.BasicDeCryp(richTextBox1.Text);
                        richTextBox1.Text = desifreli;
                        string deger = desifreli[desifreli.Length-1].ToString();
                        MessageBox.Show(desifreli);
                        if(deger =="ssu")
                        {
                            MessageBox.Show("OLDU");
                        }
                       
                        MessageBox.Show("Dönüşüm Başarılı!");
                    }
                    break; 
            }
        }

        protected void AsimetrikMethodSecim()
        {
            int val = SifreYontemComboBox.SelectedIndex;
            switch (val)
            {
                case 0://DSA
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;

                case 1://RSA
                    MessageBox.Show(SifreYontemComboBox.Text);
                    break;
            }

        }

        private void SifreleButon_Click(object sender, EventArgs e)
        {
            if (HashCheckBox.Checked == true)
            {
                HashMetodSecim();

            }
            else if (SimetrikCheckbox.Checked == true)
            {
                SimetrikMethodSecim();
            }
            else if (AsimetrikCheckbox.Checked == true)
            {
                AsimetrikMethodSecim();
            }
        }

        private void AllMethodCombobox()
        {
            foreach (var item in Enum.GetValues(typeof(SifrelemeYöntemleri)))
            {
                SifreYontemComboBox.Items.Add(item);
            }
        }

        private void ComboboxAllFalse()
        {
            if (HashCheckBox.Checked == false && SimetrikCheckbox.Checked == false && AsimetrikCheckbox.Checked == false)
            {
                AllMethodCombobox();
            }
        }
     

        private void DosyaAcBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Açılmak İstenen Dosya Yöntemi";

            DeSimetrikMethodSecim();
        }

        private void TxtForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(SifrelemeYöntemleri)))
            {
                SifreYontemComboBox.Items.Add(item);
            }
        }

        private void HashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HashCheckBox.Checked == true)
            {
                SimetrikCheckbox.Checked = false;
                AsimetrikCheckbox.Checked = false;
            }

            SifreYontemComboBox.Items.Clear();
            SifreYontemComboBox.Text = null;
            //  secimlabel.Text = "";
            foreach (var item in Enum.GetValues(typeof(HashSifrelemeYöntem)))
            {
                SifreYontemComboBox.Items.Add(item);
            }
            ComboboxAllFalse();
        }

        private void SimetrikCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SimetrikCheckbox.Checked == true)
            {
                HashCheckBox.Checked = false;
                AsimetrikCheckbox.Checked = false;
            }

            SifreYontemComboBox.Items.Clear();
            SifreYontemComboBox.Text = null;
            // secimlabel.Text = "";
            foreach (var item in Enum.GetValues(typeof(SimetrikSifrelemeYöntem)))
            {
                SifreYontemComboBox.Items.Add(item);
            }
            ComboboxAllFalse();
        }

        private void AsimetrikCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AsimetrikCheckbox.Checked == true)
            {
                HashCheckBox.Checked = false;
                SimetrikCheckbox.Checked = false;
            }

            SifreYontemComboBox.Items.Clear();
            SifreYontemComboBox.Text = null;
            //  secimlabel.Text = "";
            foreach (var item in Enum.GetValues(typeof(AsimetrikSifrelemeYöntem)))
            {
                SifreYontemComboBox.Items.Add(item);
            }
            ComboboxAllFalse();
        }

        private void PdfOlustur_Btn_Click(object sender, EventArgs e)
        {
            DeSimetrikMethodSecim();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
        }
    }
}
