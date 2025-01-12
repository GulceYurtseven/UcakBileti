
namespace WindowsFormsApp1
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
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.degistirButton = new System.Windows.Forms.Button();
            this.donusTextBox = new System.Windows.Forms.TextBox();
            this.gidisTextBox = new System.Windows.Forms.TextBox();
            this.donusLabel = new System.Windows.Forms.Label();
            this.gidisLabel = new System.Windows.Forms.Label();
            this.ekleButton1 = new System.Windows.Forms.Button();
            this.bilgilerListBox1 = new System.Windows.Forms.ListBox();
            this.ucretButton = new System.Windows.Forms.Button();
            this.ucretTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // isimTextBox
            // 
            this.isimTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.isimTextBox.Location = new System.Drawing.Point(209, 19);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(176, 26);
            this.isimTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox1.Controls.Add(this.tcTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.isimTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(62, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // tcTextBox
            // 
            this.tcTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.tcTextBox.Location = new System.Drawing.Point(209, 59);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(176, 26);
            this.tcTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox2.Controls.Add(this.ucretTextBox);
            this.groupBox2.Controls.Add(this.ucretButton);
            this.groupBox2.Controls.Add(this.degistirButton);
            this.groupBox2.Controls.Add(this.donusTextBox);
            this.groupBox2.Controls.Add(this.gidisTextBox);
            this.groupBox2.Controls.Add(this.donusLabel);
            this.groupBox2.Controls.Add(this.gidisLabel);
            this.groupBox2.Location = new System.Drawing.Point(62, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 202);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GİDİŞ-DÖNÜŞ";
            // 
            // degistirButton
            // 
            this.degistirButton.BackColor = System.Drawing.Color.Pink;
            this.degistirButton.Location = new System.Drawing.Point(6, 140);
            this.degistirButton.Name = "degistirButton";
            this.degistirButton.Size = new System.Drawing.Size(121, 41);
            this.degistirButton.TabIndex = 4;
            this.degistirButton.Text = "değiştir";
            this.degistirButton.UseVisualStyleBackColor = false;
            this.degistirButton.Click += new System.EventHandler(this.degistirButton_Click);
            // 
            // donusTextBox
            // 
            this.donusTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.donusTextBox.Location = new System.Drawing.Point(209, 64);
            this.donusTextBox.Name = "donusTextBox";
            this.donusTextBox.Size = new System.Drawing.Size(176, 26);
            this.donusTextBox.TabIndex = 3;
            // 
            // gidisTextBox
            // 
            this.gidisTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.gidisTextBox.Location = new System.Drawing.Point(209, 23);
            this.gidisTextBox.Name = "gidisTextBox";
            this.gidisTextBox.Size = new System.Drawing.Size(176, 26);
            this.gidisTextBox.TabIndex = 2;
            // 
            // donusLabel
            // 
            this.donusLabel.AutoSize = true;
            this.donusLabel.BackColor = System.Drawing.SystemColors.Info;
            this.donusLabel.Location = new System.Drawing.Point(7, 67);
            this.donusLabel.Name = "donusLabel";
            this.donusLabel.Size = new System.Drawing.Size(60, 20);
            this.donusLabel.TabIndex = 1;
            this.donusLabel.Text = "Dönüş:";
            // 
            // gidisLabel
            // 
            this.gidisLabel.AutoSize = true;
            this.gidisLabel.BackColor = System.Drawing.SystemColors.Info;
            this.gidisLabel.Location = new System.Drawing.Point(7, 26);
            this.gidisLabel.Name = "gidisLabel";
            this.gidisLabel.Size = new System.Drawing.Size(49, 20);
            this.gidisLabel.TabIndex = 0;
            this.gidisLabel.Text = "Gidiş:";
            // 
            // ekleButton1
            // 
            this.ekleButton1.BackColor = System.Drawing.Color.Pink;
            this.ekleButton1.Location = new System.Drawing.Point(644, 281);
            this.ekleButton1.Name = "ekleButton1";
            this.ekleButton1.Size = new System.Drawing.Size(188, 35);
            this.ekleButton1.TabIndex = 6;
            this.ekleButton1.Text = "ekle";
            this.ekleButton1.UseVisualStyleBackColor = false;
            this.ekleButton1.Click += new System.EventHandler(this.ekleButton1_Click);
            // 
            // bilgilerListBox1
            // 
            this.bilgilerListBox1.BackColor = System.Drawing.SystemColors.Info;
            this.bilgilerListBox1.FormattingEnabled = true;
            this.bilgilerListBox1.ItemHeight = 20;
            this.bilgilerListBox1.Location = new System.Drawing.Point(644, 51);
            this.bilgilerListBox1.Name = "bilgilerListBox1";
            this.bilgilerListBox1.Size = new System.Drawing.Size(188, 224);
            this.bilgilerListBox1.TabIndex = 7;
            // 
            // ucretButton
            // 
            this.ucretButton.BackColor = System.Drawing.Color.Pink;
            this.ucretButton.Location = new System.Drawing.Point(6, 104);
            this.ucretButton.Name = "ucretButton";
            this.ucretButton.Size = new System.Drawing.Size(121, 30);
            this.ucretButton.TabIndex = 5;
            this.ucretButton.Text = "ücret hesapla";
            this.ucretButton.UseVisualStyleBackColor = false;
            this.ucretButton.Click += new System.EventHandler(this.ucretButton_Click);
            // 
            // ucretTextBox
            // 
            this.ucretTextBox.BackColor = System.Drawing.Color.Wheat;
            this.ucretTextBox.Location = new System.Drawing.Point(209, 104);
            this.ucretTextBox.Name = "ucretTextBox";
            this.ucretTextBox.Size = new System.Drawing.Size(176, 26);
            this.ucretTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(904, 475);
            this.Controls.Add(this.bilgilerListBox1);
            this.Controls.Add(this.ekleButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox donusTextBox;
        private System.Windows.Forms.TextBox gidisTextBox;
        private System.Windows.Forms.Label donusLabel;
        private System.Windows.Forms.Label gidisLabel;
        private System.Windows.Forms.Button degistirButton;
        private System.Windows.Forms.Button ekleButton1;
        private System.Windows.Forms.ListBox bilgilerListBox1;
        private System.Windows.Forms.TextBox ucretTextBox;
        private System.Windows.Forms.Button ucretButton;
    }
}

