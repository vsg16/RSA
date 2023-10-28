using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace RSA
{
    public partial class Form1 : Form
    {
        bool q1 = false;
        bool q2 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Check_changes()
        {
            function_check_prostota(textBox1, textBox3);
            function_check_prostota(textBox2, textBox4);

            if (q1 == false || q2 == false)
            {
                button1.Enabled = false;
            }
            else if (q1 == true || q2 == true)
            {
                button1.Enabled = true;
            }
            if (textBox3.Text == "Нет" || textBox4.Text == "Нет")
            {
                button1.Enabled = false;
            }

        }
        public void function_check_prostota(TextBox txt, TextBox chek)
        {
            RSA_Class rs = new RSA_Class();
            if (rs.Test_Miller(BigInteger.Parse(txt.Text), 10))
            {
                chek.Text = "Да";
            }
            else
                chek.Text = "Нет";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Check_changes();
            function_check_prostota(textBox1, textBox3);
            function_check_prostota(textBox2, textBox4);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_changes();
            RSA_Class rs = new RSA_Class();
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("В алгоритме RSA числа на входе не должны быть равны!!!");
            }
            else
            {
                
                if (textBox3.Text == "Да" && textBox4.Text == "Да" && q1 == true && q2 == true)
                {
                    button1.Enabled = true;
                    int n = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                    int FiEil = (int.Parse(textBox1.Text) - 1) * (int.Parse(textBox2.Text) - 1);
                    int ex_ = rs.e_find(n, FiEil); //случайное число от 1 до FiEil (взаимопростое с FiEil)
                    int d = 0;
                    d = rs.ModInverse(ex_, FiEil);

                    string originalMessage = textBox5.Text;

                    byte[] bytes = Encoding.UTF8.GetBytes(originalMessage);


                    long[] encryptedBlocks = new long[bytes.Length];

                    for (int i = 0; i < bytes.Length; i++)
                    {
                        encryptedBlocks[i] = (long)rs.Encrypt(bytes[i], ex_, n);
                    }
                    byte[] bytes_1 = new byte[encryptedBlocks.Length];
                    for (int i = 0; i < encryptedBlocks.Length; i++)
                    {
                        bytes_1[i] = (byte)encryptedBlocks[i];
                    }
                    string result1 = Encoding.UTF8.GetString(bytes_1);
                    textBox6.Text = result1;

                    long[] decryptedBlocks = new long[bytes.Length];


                    for (int i = 0; i < encryptedBlocks.Length; i++)
                    {
                        decryptedBlocks[i] = (long)(rs.Decrypt(encryptedBlocks[i], d, n));
                    }
                    byte[] bytes_2 = new byte[decryptedBlocks.Length];
                    for (int i = 0; i < encryptedBlocks.Length; i++)
                    {
                        bytes_2[i] = (byte)decryptedBlocks[i];
                    }

                    string decryptedMessage = Encoding.UTF8.GetString(bytes_2);

                    textBox7.Text = (decryptedMessage);
                }
            }
            q1 = false;
            q2 = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
            q1 = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            q2 = true;
        }
    }
}
