using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Policy;
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
                    textBox9.Text = d.ToString();
                    textBox10.Text = ex_.ToString();
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RSA_Class rs_ = new RSA_Class();
            Digital_ PodPS = new Digital_();
            BigInteger hash_val = 0;
            BigInteger has_ = PodPS.GetHash((textBox5.Text));
            int n = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            long d = int.Parse(textBox9.Text);
            //long e_ = int.Parse(textBox10.Text);
            //
            textBox8.Text = has_.ToString();
             string hash_1 = textBox8.Text;
              byte[] bytes = Encoding.UTF8.GetBytes(hash_1);
             long[] encryptedBlocks = new long[bytes.Length];

            //BigInteger hash_ = BigInteger.ModPow(has_, d, n);
            //textBox12.Text = hash_.ToString();              

            for (int i = 0; i < bytes.Length; i++)
             {
                 encryptedBlocks[i] = (long)rs_.Encrypt(bytes[i], d, n);
             }
            byte[] bytes_1 = new byte[encryptedBlocks.Length];

            for (int i = 0; i < bytes.Length; i++)
            {
                encryptedBlocks[i] = (long)rs_.Encrypt(bytes[i], d, n);
            }
            string result1 = Encoding.UTF8.GetString(bytes_1);
            textBox12.Text = result1;
            textBox12.Text = string.Join("", encryptedBlocks.Select(x => x.ToString()));
            

        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox11.Text = "<" + textBox8.Text + "," + textBox12.Text + ">";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = textBox11.Text;

            int startIndex = input.IndexOf('<'); 
            int endIndex = input.IndexOf(',', startIndex); 
            string extractedWord;
            startIndex++; 
            extractedWord = input.Substring(startIndex, endIndex - startIndex);
            //Digital_ PodPS = new Digital_();
            //BigInteger hash_val = 0;
            //BigInteger has_ = 0;
            //has_ = PodPS.GetHash(extractedWord);
            //textBox8.Text = has_.ToString();
            int n = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            long d = int.Parse(textBox9.Text);
            long e_ = int.Parse(textBox10.Text);

            BigInteger has_1 = 0;
            //has_1 = PodPS.GetHash(extractedWord);

            textBox13.Text = extractedWord.ToString();
            BigInteger hash_ = BigInteger.ModPow(BigInteger.Parse(extractedWord), d, n);

            textBox15.Text = hash_.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string input = textBox11.Text;

            int startIndex = input.IndexOf(','); 
            int endIndex = input.IndexOf('>', startIndex); 
            string extractedWord;
            startIndex++; 
            extractedWord = input.Substring(startIndex, endIndex - startIndex);
            extractedWord = extractedWord.Trim();

            RSA_Class rs_ = new RSA_Class();
            Digital_ PodPS = new Digital_();
            //BigInteger hash_val = 0;
            BigInteger hashValue = PodPS.GetHash(extractedWord);
            //textBox13.Text = PodPS.GetHash(extractedWord, out hash_val);
            int n = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            long d = int.Parse(textBox9.Text);
            long e_ = int.Parse(textBox10.Text);

            string hash_1 = textBox8.Text;
            byte[] bytes = Encoding.UTF8.GetBytes(hash_1);
            long [] encryptedBlocks = new long[bytes.Length];

            //BigInteger hash_ = BigInteger.ModPow(has_, d, n);
            //textBox12.Text = hash_.ToString();              

            for (int i = 0; i < bytes.Length; i++)
            {
                encryptedBlocks[i] = (long)rs_.Encrypt(bytes[i], d, n);
            }

            long[] decryptedBlocks = new long[bytes.Length];

            for (int i = 0; i < encryptedBlocks.Length; i++)
            {
                decryptedBlocks[i] = (long)(rs_.Decrypt(encryptedBlocks[i], e_, n));
            }
            byte[] bytes_2 = new byte[decryptedBlocks.Length];
            for (int i = 0; i < encryptedBlocks.Length; i++)
            {
                bytes_2[i] = (byte)decryptedBlocks[i];
            }

            string decryptedMessage = Encoding.UTF8.GetString(bytes_2);

            //textBox7.Text = (decryptedMessage);

            BigInteger hash_ = BigInteger.ModPow(BigInteger.Parse(decryptedMessage), d, n);
            textBox16.Text = hash_.ToString();


           // BigInteger hashFromSignature = BigInteger.ModPow(BigInteger.Parse(extractedWord), e_, n);
            //textBox16.Text = hashFromSignature.ToString();
            if (textBox15.Text == textBox16.Text)
            {
                textBox15.BackColor = Color.Green;
                textBox16.BackColor = Color.Green;
            }
            else
            {
                textBox15.BackColor = Color.Red;
                textBox16.BackColor = Color.Red;
            }

        }
          

    }
}
