using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void degistirButton_Click(object sender, EventArgs e)
        {
            string ydk;
            ydk = gidisTextBox.Text;
            gidisTextBox.Text = donusTextBox.Text;
            donusTextBox.Text = ydk;

        }

        private void ekleButton1_Click(object sender, EventArgs e)
        {
            bilgilerListBox1.Items.Add(isimTextBox.Text);
            bilgilerListBox1.Items.Add(tcTextBox.Text);
            bilgilerListBox1.Items.Add(gidisTextBox.Text);
            bilgilerListBox1.Items.Add(donusTextBox.Text);
            bilgilerListBox1.Items.Add(ucretTextBox.Text);
        }

        private void ucretButton_Click(object sender, EventArgs e)
        {
            ucretTextBox.Text = "500₺";
        }
    }
}
