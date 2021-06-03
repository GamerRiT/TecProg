using sorting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            рекурсивнымиФункциямиToolStripMenuItem.Enabled = false;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].Color = Color.Red;
            chart1.Series[1].BorderWidth = 3;
            chart1.Series[1].Color = Color.Blue;
            chart1.Series[0].LegendText = "Сравнения";
            chart1.Series[1].LegendText = "Обмены";
            chart2.Series[0].BorderWidth = 3;
            chart2.Series[0].Color = Color.Red;
            chart2.Series[1].BorderWidth = 3;
            chart2.Series[1].Color = Color.Blue;
            chart2.Series[0].LegendText = "Сравнения";
            chart2.Series[1].LegendText = "Обмены";
            chart3.Series[0].BorderWidth = 3;
            chart3.Series[0].Color = Color.Red;
            chart3.Series[1].BorderWidth = 3;
            chart3.Series[1].Color = Color.Blue;
            chart3.Series[0].LegendText = "Сравнения";
            chart3.Series[1].LegendText = "Обмены";
            chart4.Series[0].BorderWidth = 3;
            chart4.Series[0].Color = Color.Red;
            chart4.Series[1].BorderWidth = 3;
            chart4.Series[1].Color = Color.Blue;
            chart4.Series[0].LegendText = "Сравнения";
            chart4.Series[1].LegendText = "Обмены";
            chart5.Series[0].BorderWidth = 3;
            chart5.Series[0].Color = Color.Red;
            chart5.Series[1].BorderWidth = 3;
            chart5.Series[1].Color = Color.Blue;
            chart5.Series[0].LegendText = "Сравнения";
            chart5.Series[1].LegendText = "Обмены";
            chart6.Series[0].BorderWidth = 3;
            chart6.Series[0].Color = Color.Red;
            chart6.Series[1].BorderWidth = 3;
            chart6.Series[1].Color = Color.Blue;
            chart6.Series[0].LegendText = "Сравнения";
            chart6.Series[1].LegendText = "Обмены";


        }
        public void output_textBox(int[] out_a, int n) //вывод массива в textBox
        {
            for (int i = 0; i < n; i++)
            { textBox1.Text += out_a[i] + " "; }
            textBox1.Text += Environment.NewLine;
        }
        public void output_dataGridView(int count, int sr, int obm, int vid_sort)// вывод в таблицу кол-ва сравнений и обменов
        {
            dataGridView1.Rows[count].Cells[vid_sort].Value = sr;
            dataGridView2.Rows[count].Cells[vid_sort].Value = obm;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].HeaderText = "Размер";
            dataGridView1.Columns[1].HeaderText = "Выбор";
            dataGridView1.Columns[2].HeaderText = "Вставки";
            dataGridView1.Columns[3].HeaderText = "Пузырек";
            dataGridView1.Columns[4].HeaderText = "Рукурсия Выбор";
            dataGridView1.Columns[5].HeaderText = "Шелла";
            dataGridView1.Columns[6].HeaderText = "Рекурсия пузырек";
            dataGridView1.Columns[7].HeaderText = "Рекурсия вставка";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 8;
            dataGridView2.Columns[0].HeaderText = "Размер";
            dataGridView2.Columns[1].HeaderText = "Выбор";
            dataGridView2.Columns[2].HeaderText = "Вставки";
            dataGridView2.Columns[3].HeaderText = "Пузырек";
            dataGridView2.Columns[4].HeaderText = "Рукурсия Выбор";
            dataGridView2.Columns[5].HeaderText = "Шелла";
            dataGridView2.Columns[6].HeaderText = "Рекурсия пузырек";
            dataGridView2.Columns[7].HeaderText = "Рекурсия вставка";
            dataGridView1.ColumnCount = 8;
            dataGridView2.ColumnCount = 8;
            if (numericUpDown4.Value < numericUpDown5.Value)
            { label8.Text = "Макс значение не м.б. меньше мин значения!"; return; }
            int count = 0, n, sr = 0, obm = 0;
            ArraySort sort_select = new ArraySort();
            ArraySort sort_insert = new ArraySort();
            ArraySort sort_bubble = new ArraySort();
            ArraySort sort_RecSelect = new ArraySort();
            ArraySort sort_ShellSort = new ArraySort();
            ArraySort sort_RecBubbleSort = new ArraySort();
            ArraySort sort_RecInsertSort = new ArraySort();
            

            for (n = Convert.ToInt32(numericUpDown1.Value); n <= Convert.ToInt32(numericUpDown2.Value); n += Convert.ToInt32(numericUpDown3.Value))
            {
                int[] base_a = new int[n];
                Random rand = new Random();
                for (int j = 0; j < n; j++)
                {
                    base_a[j] = rand.Next(Convert.ToInt32(numericUpDown5.Value), Convert.ToInt32(numericUpDown4.Value));
                }

                textBox1.Text += "Исходный массив " + Environment.NewLine;
                output_textBox(base_a, n);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[count].Cells[0].Value = n;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[count].Cells[0].Value = n;



                sort_select.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_select.SelectSort(sort_select.a, ref sr, ref obm);
                textBox1.Text += "Сортировка выбором " + Environment.NewLine;
                output_textBox(sort_select.a, n);
                output_dataGridView(count, sr, obm, 1);
                chart1.Series[0].Points.AddXY(n, sr);
                chart1.Series[1].Points.AddXY(n, obm);


                sort_insert.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_insert.InsertSort(sort_insert.a, ref sr, ref obm);
                textBox1.Text += "Сортировка вставками " + Environment.NewLine;
                output_textBox(sort_insert.a, n);
                output_dataGridView(count, sr, obm, 2);
                chart2.Series[0].Points.AddXY(n, sr);
                chart2.Series[1].Points.AddXY(n, obm);

                sort_bubble.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_bubble.BubbleSort(sort_bubble.a, ref sr, ref obm);
                textBox1.Text += "Сортировка пузырьком " + Environment.NewLine;
                output_textBox(sort_bubble.a, n);
                output_dataGridView(count, sr, obm, 3);
                chart3.Series[0].Points.AddXY(n, sr);
                chart3.Series[1].Points.AddXY(n, obm);

                sort_RecSelect.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_RecSelect.RecSelect(sort_RecSelect.a, base_a.Length, ref sr, ref obm);
                textBox1.Text += "Сортировка Рекурсия выбором " + Environment.NewLine;
                output_textBox(sort_RecSelect.a, n);
                output_dataGridView(count, sr, obm, 4);

                sort_ShellSort.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_ShellSort.ShellSort(sort_ShellSort.a, ref sr, ref obm);
                textBox1.Text += "Сортировка Шелла " + Environment.NewLine;
                output_textBox(sort_ShellSort.a, n);
                output_dataGridView(count, sr, obm, 5);
                chart5.Series[0].Points.AddXY(n, sr);
                chart5.Series[1].Points.AddXY(n, obm);
                chart7.Series[0].Points.AddXY(n, sr);
                chart8.Series[0].Points.AddXY(n, obm);

                sort_RecBubbleSort.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_RecBubbleSort.RecBubbleSort(sort_RecBubbleSort.a, ref sr, ref obm);
                textBox1.Text += "Сортировка Рекурсия пузырек " + Environment.NewLine;
                output_textBox(sort_RecBubbleSort.a, n);
                output_dataGridView(count, sr, obm, 6);
                chart4.Series[0].Points.AddXY(n, sr);
                chart4.Series[1].Points.AddXY(n, obm);
                chart7.Series[1].Points.AddXY(n, sr);
                chart8.Series[1].Points.AddXY(n, obm);

                sort_RecInsertSort.a = (int[])base_a.Clone();
                sr = 0; obm = 0; int i = 1;
                sort_RecInsertSort.RecInsertSort(sort_RecInsertSort.a, ref sr, ref obm, i);
                textBox1.Text += "Сортировка Рекурсия вставка " + Environment.NewLine;
                output_textBox(sort_RecInsertSort.a, n);
                output_dataGridView(count, sr, obm, 7);
                chart6.Series[0].Points.AddXY(n, sr);
                chart6.Series[1].Points.AddXY(n, obm);
                chart7.Series[2].Points.AddXY(n, sr);
                chart8.Series[2].Points.AddXY(n, obm);
                count++;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            textBox1.Text = "";
            button1.Enabled = true;
            цикламиToolStripMenuItem.Enabled = true;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart3.Series[0].Points.Clear();
            chart3.Series[1].Points.Clear();
            chart4.Series[0].Points.Clear();
            chart4.Series[1].Points.Clear();
            chart5.Series[0].Points.Clear();
            chart5.Series[1].Points.Clear();
            chart6.Series[0].Points.Clear();
            chart6.Series[1].Points.Clear();
        }

        private void сохранитьВсеФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сохранитьГрафикСортировкиВставкамиToolStripMenuItem_Click(sender, e);
            сохранитьГрафикСортировкиВыборомToolStripMenuItem_Click(sender, e);
            сохранитьГрафикСортировкиПузырькомToolStripMenuItem_Click(sender, e);
            сохранитьГрафкиСортировкиРекурсииВыборомToolStripMenuItem_Click(sender, e);
            сохранитьГрафикиСортировкиШеллаToolStripMenuItem_Click(sender, e);
            сохранитьГрафикСортировкиРекурсияВставкаToolStripMenuItem_Click(sender, e);
            сохранитьГрафикСравненияСортировокоToolStripMenuItem_Click(sender, e); 
        }

        private void сохранитьГрафикСортировкиВставкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr1 = new SaveFileDialog())
            {
                saveGr1.Title = "Сохранить график как ...";
                saveGr1.Filter = "*.jpg|*.jpg";
                saveGr1.AddExtension = true;
                saveGr1.FileName = "Insert";
                if (saveGr1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   chart2.SaveImage(saveGr1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void сохранитьГрафикСортировкиВыборомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr = new SaveFileDialog())
            {
                saveGr.Title = "Сохранить график как ...";
                saveGr.Filter = "*.jpg|*.jpg";
                saveGr.AddExtension = true;
                saveGr.FileName = "Select";
                if (saveGr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart1.SaveImage(saveGr.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void сохранитьГрафикСортировкиПузырькомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr2 = new SaveFileDialog())
            {
                saveGr2.Title = "Сохранить график как ...";
                saveGr2.Filter = "*.jpg|*.jpg";
                saveGr2.AddExtension = true;
                saveGr2.FileName = "Bubble";
                if (saveGr2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart3.SaveImage(saveGr2.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }

        }
        private void сохранитьГрафкиСортировкиРекурсииВыборомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr3 = new SaveFileDialog())
            {
                saveGr3.Title = "Сохранить график как ...";
                saveGr3.Filter = "*.jpg|*.jpg";
                saveGr3.AddExtension = true;
                saveGr3.FileName = "RecBubbleSort";
                if (saveGr3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart4.SaveImage(saveGr3.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }
        private void сохранитьГрафикиСортировкиШеллаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr4 = new SaveFileDialog())
            {
                saveGr4.Title = "Сохранить график как ...";
                saveGr4.Filter = "*.jpg|*.jpg";
                saveGr4.AddExtension = true;
                saveGr4.FileName = "ShellSort";
                if (saveGr4.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart5.SaveImage(saveGr4.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }
        private void сохранитьГрафикСортировкиРекурсияВставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr5 = new SaveFileDialog())
            {
                saveGr5.Title = "Сохранить график как ...";
                saveGr5.Filter = "*.jpg|*.jpg";
                saveGr5.AddExtension = true;
                saveGr5.FileName = "RecInsertSort";
                if (saveGr5.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart6.SaveImage(saveGr5.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }
        private void сохранитьГрафикСравненияСортировокоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr6 = new SaveFileDialog())
            {
                saveGr6.Title = "Сохранить график как ...";
                saveGr6.Filter = "*.jpg|*.jpg";
                saveGr6.AddExtension = true;
                saveGr6.FileName = "AllSort";
                if (saveGr6.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart6.SaveImage(saveGr6.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void цикламиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            цикламиToolStripMenuItem.Enabled = false;
        }

        private void рекурсивнымиФункциямиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 help = new Form2();
            help.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
