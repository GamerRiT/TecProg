using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        int p = 0;
        int a = 0;
        int eq = 0;
        int  qwe=0;
        int a1 = 0;
        int asd=0;
        int pz=0, a2 = 0;
        string t, text="empty", te;
        int o = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text.ToString();
            int countwords = 1, countpred = 0;
            foreach (char q in text)
            {
                if (q == '.')
                {
                    countpred++;
                    textBox.Text += "В предложении " + countpred + ": " + countwords + " слов." + Environment.NewLine;
                    countwords = 0;
                }
                if (q == ' ') countwords++;
            }
            textBox.Text += "Всего в тексте "+ countpred +" предложений."+ Environment.NewLine;
            KeyPreview = true;
            string text1 = text;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            p++;
            if ((p==1) || ((pz-1)>=a2))
                {
                if (o == 0)
                {
                    string text = richTextBox1.Text.ToString();
                    te = text;
                    o++;
                }
                foreach (char q in te)
                {
                    if (q == '.')
                    {
                        richTextBox1.SelectionStart = asd;
                        richTextBox1.SelectionLength = a1;
                        richTextBox1.SelectionBackColor = Color.Green;
                        te = te.Substring(2);
                        asd = asd + a1+2;
                        a1 = 0;
                        a2++;
                        break;
                    }
                    else
                    {
                        a1++;
                        te = te.Substring(1);
                        a2++;
                    }
                }
            }
            else
            {
                if (qwe == 0)
                {
                    string text = richTextBox1.Text.ToString();
                    qwe++;
                    t = text;
                }
                foreach (char q in t)
                {
                    if ((q == ' ') || (q == '.'))
                    {
                        richTextBox1.SelectionStart = eq;
                        richTextBox1.SelectionLength = a;
                        richTextBox1.SelectionBackColor = Color.Red;
                        t = t.Substring(1);
                        eq =eq+ a+1;
                        a = 0;
                        pz++;
                        break;
                    }
                    else a++;
                    t = t.Substring(1);
                    pz++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            richTextBox1.Clear();
        }
    }
}











//{
//    if (qwe == 0)
//    {
//        string text = richTextBox1.Text.ToString();
//        qwe++;
//        t = text;
//    }
//    else
//    {
//        t = text;
//    }
//    foreach (char q in t)
//    {
//        if (q == ' ')
//        {
//            richTextBox1.SelectionStart = eq;
//            richTextBox1.SelectionLength = a;
//            richTextBox1.SelectionBackColor = Color.Red;
//            text = t.Substring(eq, a + 1);
//            eq = a + 1;
//            a = 0;
//            break;
//        }
//        else a++;
//    }
//}
