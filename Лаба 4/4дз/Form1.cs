using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4дз
{
    struct Employee
    {
        public string FIO;//ФИО

        public string Post;// Должность
        public string Date_of_Birth;// ДАта рождения 
        public string Degree; //Ученая степеть 
        public string Experience;//Стажработы
        public Employee(string f, string p, string d, string deg, string e)//конструктор
        {
            FIO = f;
            Post = p; Date_of_Birth = d; Degree = deg; Experience = e;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "Ф.И.О студента";
            dataGridView1.Columns[1].HeaderText = "Адрес";
            dataGridView1.Columns[2].HeaderText = "Дата рождения";
            dataGridView1.Columns[3].HeaderText = "Телефон";


            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].HeaderText = "Ф.И.О студента";
            dataGridView2.Columns[1].HeaderText = "Адрес";
            dataGridView2.Columns[2].HeaderText = "Дата рождения";
            dataGridView2.Columns[3].HeaderText = "Телефон";
            dataGridView2.RowHeadersVisible = false;

        }

        Employee[] worker = new Employee[10]; int cout = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            worker[cout].FIO = textBox1.Text;
            worker[cout].Experience = textBox2.Text;
            worker[cout].Date_of_Birth = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            worker[cout].Post = textBox4.Text;
            dataGridView1.Rows.Add(worker[cout].FIO, worker[cout].Experience.ToString(), worker[cout].Date_of_Birth,  worker[cout].Post);
            cout++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                dataGridView2.Rows.Clear();
                string select1 = textBox3.Text; foreach (Employee wSel in worker)
                {
                    if (wSel.Date_of_Birth == select1) dataGridView2.Rows.Add(wSel.FIO, wSel.Experience.ToString(),
                    wSel.Date_of_Birth, wSel.Post);
                }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        { Close(); }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
