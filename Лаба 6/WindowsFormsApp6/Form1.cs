using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenText, k, n = 0, k1 = 0;
            string[] alf = new string[] { "а", "б", "в", "г", "д", "е",  "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я"};
            string b = "", b1, b2 = "";
            string T = textBox1.Text.ToString();

            lenText = textBox1.Text.Length;
            for (int i = 0; i < lenText; i++) 
            {
                b += textBox1.Text.Substring(i, 1);
                if (textBox1.Text.Substring(i, 1) == " " || textBox1.Text.Substring(i,1)==".") 
                {
                    for(int j = 0; j < b.Length-1; j++)
                    {
                        b1 = b.Substring(j, 1);
                        for(int j1 = 0 ; j1<32 ;j1++ )
                        {
                            if(b1==alf[j1])
                            {
                                k1 = j1;
                                
                            }
                            
                        }
                        int PascId = factor(b.Length - 2) / (factor(j) * factor((b.Length - 2) - (j)));
                        k1 += PascId;
                        b2 += alf[k1];
                        k1 = 0;
                    }
                    b2 += " ";
                    b = "";
                }
                
                
            }
            textBox2.Text += "Зашифрованный текст: " + Environment.NewLine;
            textBox2.Text += b2 + Environment.NewLine + Environment.NewLine;

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            int lenText, k, n = 0, k1 = 0;
            string[] alf = new string[] { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х","ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            string b = "", b1, b2 = "";
            string T = textBox1.Text.ToString();

            lenText = textBox1.Text.Length;
            for (int i = 0; i < lenText; i++)
            {
                b += textBox1.Text.Substring(i, 1);
                if (textBox1.Text.Substring(i, 1) == " ")
                {
                    for (int j = 0; j < b.Length - 1; j++)
                    {
                        b1 = b.Substring(j, 1);
                        for (int j1 = 0; j1 < 32; j1++)
                        {
                            if (b1 == alf[j1])
                            {
                                k1 = j1;

                            }

                        }
                        int PascId = factor(b.Length - 2) / (factor(j) * factor((b.Length - 2) - (j)));
                        k1 -= PascId;
                        b2 += alf[k1];
                        k1 = 0;
                    }
                    b2 += " ";
                    b = "";
                }


            }
            textBox2.Text += "Расшифрованный текст: " + Environment.NewLine;
            textBox2.Text += b2 + Environment.NewLine + Environment.NewLine;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string[] alf = new string[] { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х","ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            string slovo = textBox3.Text.ToString();
            string code = textBox4.Text.ToString();
            string a = "", b = "", c = "", d = "";
            int k = 0, Code, n = 0;
            for (int s = 0; code.Length <= slovo.Length; s++)
            {
                if (code.Length < s)
                {
                    s = 0;
                }
                b = code.Substring(s, 1);
                code += b;

            }
            for (int i = 0; i < slovo.Length; i++)
            {
                a = slovo.Substring(i, 1);
                for (int j1 = 0; j1 < 32; j1++)
                {
                    if (a == alf[j1])
                    {
                        k = j1;
                        break;
                    }
                }
                if (a == " ")
                {
                    d += " ";
                    n++;
                }
                else
                {
                    c = code.Substring(i-n, 1);
                    Code = Convert.ToInt32(c);
                    d += alf[k + Code];
                    k = 0;
                }
            }
            textBox2.Text += "Зашифрованный текст: " + Environment.NewLine;
            textBox2.Text += d + Environment.NewLine + Environment.NewLine;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string[] alf = new string[] { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            string slovo = textBox3.Text.ToString();
            string code = textBox4.Text.ToString();
            string a = "", b = "", c = "", d = "";
            int k = 0, Code, n = 0;
            for (int s = 0; code.Length <= slovo.Length; s++)
            {
                if (code.Length < s)
                {
                    s = 0;
                }
                b = code.Substring(s, 1);
                code += b;

            }
            for (int i = 0; i < slovo.Length; i++)
            {
                a = slovo.Substring(i, 1);
                for (int j1 = 0; j1 < 32; j1++)
                {
                    if (a == alf[j1])
                    {
                        k = j1;
                        break;
                    }
                }
                if (a == " ")
                {
                    d += " ";
                    n++;
                }
                else
                {
                    c = code.Substring(i - n, 1);
                    Code = Convert.ToInt32(c);
                    d += alf[k - Code];
                    k = 0;
                }
            }
            textBox2.Text += "Расшифрованный текст: " + Environment.NewLine;
            textBox2.Text += d + Environment.NewLine + Environment.NewLine;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string[] alf = new string[] { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            int[] code1 = new int[5];
            int[] code2 = new int[100];
            string slovo = textBox5.Text.ToString();
            string code = textBox6.Text.ToString();
            string a = "", b = "", c = "",d = "",f = "";
            int k = 0, n = 0, p = 0,s1 = 0, j3 = 0, j4 = 0,n1 = 0;
            for (int j2 = 0; j2 < code.Length; j2++)  
            {
                a = code.Substring(j2, 1);               
                for (int j1 = 0; j1 < 31; j1++)
                {                
                    if (a == alf[j1])
                    {
                        code1[j3] = j1;
                        break;
                    }
                }
                j3++;
            }
            j4 = j3;
            for (j3=0; s1 <= slovo.Length; j3++)
            {

                if (j3 >= j4) 
                {
                    j3 = 0;
                }
                code2[s1] = code1[j3];
                s1++;
            }
            for (int i = 0; i < slovo.Length; i++) 
            {
                a = slovo.Substring(i, 1);
                for (int j1 = 0; j1 < 32; j1++)
                {
                    if (a == alf[j1])
                    {
                        k = j1;
                        break;
                    }
                }
                if (a == " ")
                {
                    f += " ";
                    n1++;
                }
                else
                {
                    n = code2[i-n1];
                    p = (n + k) % 32;
                    f += alf[p];
                }
            }
            textBox2.Text += "Зашифрованный текст: " + Environment.NewLine;
            textBox2.Text += f + Environment.NewLine + Environment.NewLine;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        int factor(int ABC)
        {
            int fact = 1;
            for (int i = 1; i <= ABC; i++)
            {
                fact *= i;
            }
            return fact;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] alf = new string[] { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            int[] code1 = new int[5];
            int[] code2 = new int[100];
            string slovo = textBox5.Text.ToString();
            string code = textBox6.Text.ToString();
            string a = "", b = "", c = "", d = "", f = "";
            int k = 0, n = 0, p = 0, s1 = 0, j3 = 0, j4 = 0, n1 = 0;
            for (int j2 = 0; j2 < code.Length; j2++)
            {
                a = code.Substring(j2, 1);
                for (int j1 = 0; j1 < 31; j1++)
                {
                    if (a == alf[j1])
                    {
                        code1[j3] = j1;
                        break;
                    }
                }
                j3++;
            }
            j4 = j3;
            for (j3 = 0; s1 <= slovo.Length; j3++)
            {

                if (j3 >= j4)
                {
                    j3 = 0;
                }
                code2[s1] = code1[j3];
                s1++;
            }
            for (int i = 0; i < slovo.Length; i++)
            {
                a = slovo.Substring(i, 1);
                for (int j1 = 0; j1 < 32; j1++)
                {
                    if (a == alf[j1])
                    {
                        k = j1;
                        break;
                    }
                }
                if (a == " ")
                {
                    f += " ";
                    n1++;
                }
                else
                {
                    n = code2[i - n1];
                    p = (k-n+32) % 32;
                    f += alf[p];
                }
            }
            textBox2.Text += "Зашифрованный текст: " + Environment.NewLine;
            textBox2.Text += f + Environment.NewLine + Environment.NewLine;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
