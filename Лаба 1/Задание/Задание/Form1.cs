using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, m;
            int i, j, k=1, q=0;
            button3.Enabled = true;
            if (numericUpDown8.Value < numericUpDown7.Value)
            {
                label9.Text = "Макс значение не м.б. меньше мин. значения!"; return;
            }
            n = Convert.ToInt32(numericUpDown6.Value);
            m = Convert.ToInt32(numericUpDown6.Value);
            int[,] ptr;
            ptr = new int[m, n];
            int[,] pr;
            pr = new int[m, k];
            Random rand = new Random();
            dataGridView1.AutoResizeColumns();
            dataGridView1.ColumnCount = n;
            int min = Convert.ToInt32(numericUpDown8.Value), max = Convert.ToInt32(numericUpDown7.Value);
            int maxstol = 0, minstol = 0;
            for (i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add();
                for (j = 0; j < m; j++)
                {
                    ptr[i, j] = rand.Next(Convert.ToInt32(numericUpDown7.Value), Convert.ToInt32(numericUpDown8.Value));
                    dataGridView1.Rows[i].Cells[j].Value = ptr[i, j];
                    if (ptr[i, j] > max)
                    {
                        max = ptr[i, j];
                        maxstol = j;
                    }
                    if (ptr[i, j] < min)
                    {
                        min = ptr[i, j];
                        minstol = j;
                    }
                }

            }
            if (minstol <= maxstol) { q = minstol; k = maxstol; }
            if (minstol > maxstol) { q = maxstol; k = minstol; }
            for (i=0; i<m;i++)
            {
                    pr[i, 0] = ptr[i, maxstol] * ptr[i, minstol];
            }
            dataGridView2.AutoResizeColumns();
            dataGridView2.ColumnCount = n;
            for (i = 0; i < m; i++)
            {
                dataGridView2.Rows.Add();
                for (j = 0; j < m; j++)
                {
                    if (j!=maxstol)
                        if (j!=minstol)
                            dataGridView2.Rows[i].Cells[j].Value = ptr[i, j];
                    if (j==q)
                        dataGridView2.Rows[i].Cells[j].Value = pr[i, 0];
                }
            }
            q = q+1;
            k = k + 1;
            label9.Text = "Удалён столбец- " + k + "; Первый столбец , который был преобразован- " + q;

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            button1.Enabled = true;
            label9.Text = "";
        }
    }
}
