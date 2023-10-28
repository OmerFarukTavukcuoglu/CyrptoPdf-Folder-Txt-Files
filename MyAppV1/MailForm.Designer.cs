namespace MyAppV1
{
    partial class MailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.GönderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DurumLabel = new System.Windows.Forms.Label();
            this.BilgiLabel = new System.Windows.Forms.Label();
            this.MailCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.MailImageBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuccessImageBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MailImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MailTextBox
            // 
            this.MailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailTextBox.Location = new System.Drawing.Point(111, 184);
            this.MailTextBox.Multiline = true;
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(244, 24);
            this.MailTextBox.TabIndex = 1;
            this.MailTextBox.Click += new System.EventHandler(this.textBox1_Click);
            this.MailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MailTextBox_KeyPress);
            // 
            // GönderBtn
            // 
            this.GönderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GönderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GönderBtn.ForeColor = System.Drawing.Color.Black;
            this.GönderBtn.Location = new System.Drawing.Point(308, 236);
            this.GönderBtn.Name = "GönderBtn";
            this.GönderBtn.Size = new System.Drawing.Size(120, 30);
            this.GönderBtn.TabIndex = 8;
            this.GönderBtn.Text = "Gönder";
            this.GönderBtn.UseVisualStyleBackColor = true;
            this.GönderBtn.Click += new System.EventHandler(this.GönderBtn_Click);
            this.GönderBtn.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.GönderBtn.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mail Adresi:";
            // 
            // DurumLabel
            // 
            this.DurumLabel.AutoSize = true;
            this.DurumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumLabel.Location = new System.Drawing.Point(11, 22);
            this.DurumLabel.Name = "DurumLabel";
            this.DurumLabel.Size = new System.Drawing.Size(233, 22);
            this.DurumLabel.TabIndex = 10;
            this.DurumLabel.Text = "Dosya Başarıyla Kaydedildi!";
            // 
            // BilgiLabel
            // 
            this.BilgiLabel.AutoSize = true;
            this.BilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiLabel.Location = new System.Drawing.Point(8, 69);
            this.BilgiLabel.Name = "BilgiLabel";
            this.BilgiLabel.Size = new System.Drawing.Size(42, 20);
            this.BilgiLabel.TabIndex = 11;
            this.BilgiLabel.Text = "label";
            // 
            // MailCheckBox
            // 
            this.MailCheckBox.AutoSize = true;
            this.MailCheckBox.Depth = 0;
            this.MailCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.MailCheckBox.Location = new System.Drawing.Point(359, 134);
            this.MailCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.MailCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MailCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.MailCheckBox.Name = "MailCheckBox";
            this.MailCheckBox.Ripple = true;
            this.MailCheckBox.Size = new System.Drawing.Size(105, 30);
            this.MailCheckBox.TabIndex = 12;
            this.MailCheckBox.Text = "Mail Gönder";
            this.MailCheckBox.UseVisualStyleBackColor = true;
            this.MailCheckBox.CheckedChanged += new System.EventHandler(this.MailCheckBox_CheckedChanged);
            this.MailCheckBox.MouseHover += new System.EventHandler(this.MailCheckBox_MouseHover);
            // 
            // MailImageBox
            // 
            this.MailImageBox.Location = new System.Drawing.Point(351, 12);
            this.MailImageBox.Name = "MailImageBox";
            this.MailImageBox.Size = new System.Drawing.Size(133, 120);
            this.MailImageBox.TabIndex = 13;
            this.MailImageBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(462, -5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseEnter += new System.EventHandler(this.label7_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            // 
            // SuccessImageBox
            // 
            this.SuccessImageBox.Location = new System.Drawing.Point(252, 8);
            this.SuccessImageBox.Name = "SuccessImageBox";
            this.SuccessImageBox.Size = new System.Drawing.Size(45, 45);
            this.SuccessImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SuccessImageBox.TabIndex = 33;
            this.SuccessImageBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(322, 184);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 24);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "@gmail.com";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 278);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SuccessImageBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MailImageBox);
            this.Controls.Add(this.MailCheckBox);
            this.Controls.Add(this.BilgiLabel);
            this.Controls.Add(this.DurumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GönderBtn);
            this.Controls.Add(this.MailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailForm";
            this.Load += new System.EventHandler(this.MailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MailImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Button GönderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DurumLabel;
        private System.Windows.Forms.Label BilgiLabel;
        private MaterialSkin.Controls.MaterialCheckBox MailCheckBox;
        private System.Windows.Forms.PictureBox MailImageBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox SuccessImageBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}