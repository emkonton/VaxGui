namespace VaSuiteGui
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.osint = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.SoicalScanBut = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gialsb = new System.Windows.Forms.Button();
            this.ipadusin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AttackPag = new System.Windows.Forms.TabPage();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxViewS = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.osint.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AttackPag.SuspendLayout();
            this.SuspendLayout();
            // 
            // osint
            // 
            this.osint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.osint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.osint.Controls.Add(this.label4);
            this.osint.Controls.Add(this.SoicalScanBut);
            this.osint.Controls.Add(this.rtbOutput);
            this.osint.Controls.Add(this.label2);
            this.osint.Controls.Add(this.gialsb);
            this.osint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.osint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.osint.Location = new System.Drawing.Point(4, 22);
            this.osint.Name = "osint";
            this.osint.Padding = new System.Windows.Forms.Padding(3);
            this.osint.Size = new System.Drawing.Size(775, 590);
            this.osint.TabIndex = 0;
            this.osint.Text = "Osint";
            this.osint.Click += new System.EventHandler(this.osint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(145, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soical media scan start";
            // 
            // SoicalScanBut
            // 
            this.SoicalScanBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SoicalScanBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SoicalScanBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoicalScanBut.ForeColor = System.Drawing.Color.Red;
            this.SoicalScanBut.Location = new System.Drawing.Point(10, 363);
            this.SoicalScanBut.Name = "SoicalScanBut";
            this.SoicalScanBut.Size = new System.Drawing.Size(129, 23);
            this.SoicalScanBut.TabIndex = 5;
            this.SoicalScanBut.Text = "Scan Start";
            this.SoicalScanBut.UseVisualStyleBackColor = false;
            this.SoicalScanBut.Click += new System.EventHandler(this.SoicalScanBut_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(66)))));
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Location = new System.Drawing.Point(10, 421);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(759, 163);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(145, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geographic IP address location scanning";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gialsb
            // 
            this.gialsb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gialsb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gialsb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gialsb.ForeColor = System.Drawing.Color.Red;
            this.gialsb.Location = new System.Drawing.Point(10, 392);
            this.gialsb.Name = "gialsb";
            this.gialsb.Size = new System.Drawing.Size(129, 23);
            this.gialsb.TabIndex = 2;
            this.gialsb.Text = "Scan Start";
            this.gialsb.UseVisualStyleBackColor = false;
            this.gialsb.Click += new System.EventHandler(this.gialsb_Click);
            // 
            // ipadusin
            // 
            this.ipadusin.Location = new System.Drawing.Point(787, 35);
            this.ipadusin.Name = "ipadusin";
            this.ipadusin.Size = new System.Drawing.Size(198, 20);
            this.ipadusin.TabIndex = 0;
            this.ipadusin.TextChanged += new System.EventHandler(this.ipadusin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(787, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İp adress";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.osint);
            this.tabControl1.Controls.Add(this.AttackPag);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(52, 18);
            this.tabControl1.Location = new System.Drawing.Point(-2, -5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 616);
            this.tabControl1.TabIndex = 0;
            // 
            // AttackPag
            // 
            this.AttackPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AttackPag.Controls.Add(this.label7);
            this.AttackPag.Controls.Add(this.button1);
            this.AttackPag.Controls.Add(this.checkBoxViewS);
            this.AttackPag.Controls.Add(this.label6);
            this.AttackPag.Controls.Add(this.label5);
            this.AttackPag.Location = new System.Drawing.Point(4, 22);
            this.AttackPag.Name = "AttackPag";
            this.AttackPag.Padding = new System.Windows.Forms.Padding(3);
            this.AttackPag.Size = new System.Drawing.Size(775, 590);
            this.AttackPag.TabIndex = 1;
            this.AttackPag.Text = "Attack";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(787, 100);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(197, 20);
            this.usernamebox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(787, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "You are about to access the attack menu.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(9, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(477, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "The user is responsible for everything done.";
            // 
            // checkBoxViewS
            // 
            this.checkBoxViewS.AutoSize = true;
            this.checkBoxViewS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxViewS.ForeColor = System.Drawing.Color.Red;
            this.checkBoxViewS.Location = new System.Drawing.Point(14, 335);
            this.checkBoxViewS.Name = "checkBoxViewS";
            this.checkBoxViewS.Size = new System.Drawing.Size(113, 20);
            this.checkBoxViewS.TabIndex = 2;
            this.checkBoxViewS.Text = "ViewSupport";
            this.checkBoxViewS.UseVisualStyleBackColor = true;
            this.checkBoxViewS.CheckedChanged += new System.EventHandler(this.checkBoxViewS_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "TestButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(10, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(595, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "The attack menu is still under development and testing.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(996, 615);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ipadusin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VaSuite";
            this.osint.ResumeLayout(false);
            this.osint.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.AttackPag.ResumeLayout(false);
            this.AttackPag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage osint;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox ipadusin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gialsb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AttackPag;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SoicalScanBut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxViewS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}

