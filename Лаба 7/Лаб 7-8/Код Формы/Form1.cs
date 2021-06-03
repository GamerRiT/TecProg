using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Код_Формы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Both;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Point Cordinates= new Point();
            Cordinates.pointX=Convert.ToInt32(X1.Text);
            Cordinates.pointY = Convert.ToInt32(Y1.Text);
            textBox1.Text += "Точка имеет координаты" + Environment.NewLine;
            textBox1.Text += "x= " + Cordinates.pointX + "\t";
            textBox1.Text += "y= " + Cordinates.pointY + Environment.NewLine;
            textBox1.Text += Environment.NewLine + Environment.NewLine;

            int h1 = Convert.ToInt32(H1.Text);
            int r1 =Convert.ToInt32(R1.Text);
            int h2 = Convert.ToInt32(H2.Text);
            int r2 = Convert.ToInt32(R2.Text);

            Imarea Crug = new Circle();
            textBox1.Text += "Площадь окружности = " + Crug.Area(r1) + Environment.NewLine;
            textBox1.Text += Environment.NewLine + Environment.NewLine;

            Imarea PCone = new Cone();
            textBox1.Text += "Площадь поверхности конуса = " + PCone.Area(r1, h1) + Environment.NewLine;
            textBox1.Text += Environment.NewLine + Environment.NewLine;

            Imarea VCone = new Frustrum();
            textBox1.Text += "Объем усеченного конуса = " + VCone.Area(r1, r2 ,h1) + Environment.NewLine;
            textBox1.Text += Environment.NewLine + Environment.NewLine;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
