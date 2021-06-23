using System;
using System.Windows.Forms;

namespace messageapp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
      
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "2")
            {
                mesaj f1 = new mesaj();

                f1.ShowDialog();

                this.Close();
            }
            else
            {

                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı!");
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
