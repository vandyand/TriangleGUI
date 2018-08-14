using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double first_val, second_val, third_val, A = 0;
            try { first_val = Convert.ToDouble(textboxFirst.Text);}
            catch { first_val = 0; }
            try { second_val = Convert.ToDouble(textboxSecond.Text); }
            catch { second_val = 0; }
            try { third_val = Convert.ToDouble(textboxThird.Text); }
            catch { third_val = 0; }


            if (listBox1.SelectedItem == "Square")
            {
                A = Math.Pow(first_val,2);
            }
            if (listBox1.SelectedItem == "Rectangle")
            {
                A = first_val * second_val;
            }
            if (listBox1.SelectedItem == "Trapezoid")
            {
                A =  0.5 * (first_val + second_val) * third_val;
            }
            else if (listBox1.SelectedItem == "Triangle")
            {
                A = first_val * second_val * 0.5;
            }
            else if (listBox1.SelectedItem == "Ellipse")
            {
                A = Math.PI * first_val * second_val;
            }
            else if (listBox1.SelectedItem == "Circle")
            {
                A = Math.PI * Math.Pow(first_val,2);
            }


            lblArea.Text = A.ToString("n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textboxFirst.Text = "";
            textboxSecond.Text = "";
            textboxThird.Text = "";
            lblArea.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textboxFirst.Text = "";
            textboxSecond.Text = "";
            textboxThird.Text = "";

            if (listBox1.SelectedItem == "Square")
            {
                labelFirst.Visible = true;
                labelFirst.Text = "Side Length";
                labelSecond.Visible = false;
                labelThird.Visible = false;
                textboxFirst.Visible = true;
                textboxSecond.Visible = false;
                textboxThird.Visible = false;
            }
            if (listBox1.SelectedItem == "Rectangle")
            {
                labelFirst.Visible = true;
                labelFirst.Text = "Base";
                labelSecond.Visible = true;
                labelSecond.Text = "Height";
                labelThird.Visible = false;
                textboxFirst.Visible = true;
                textboxSecond.Visible = true;
                textboxThird.Visible = false;
            }
            if (listBox1.SelectedItem == "Trapezoid")
            {
                labelFirst.Visible = true;
                labelFirst.Text = "a";
                labelSecond.Visible = true;
                labelSecond.Text = "b";
                labelThird.Visible = true;
                labelThird.Text = "h";
                textboxFirst.Visible = true;
                textboxSecond.Visible = true;
                textboxThird.Visible = true;
            }
            if (listBox1.SelectedItem== "Triangle")
            {
                labelFirst.Visible = true;
                labelFirst.Text = "Base";
                labelSecond.Visible = true;
                labelSecond.Text = "Height";
                labelThird.Visible = false;
                textboxFirst.Visible = true;
                textboxSecond.Visible = true;
                textboxThird.Visible = false;
            }
            if (listBox1.SelectedItem == "Ellipse")
            {
                labelFirst.Visible = true;
                labelFirst.Text = "a";
                labelSecond.Visible = true;
                labelSecond.Text = "b";
                labelThird.Visible = false;
                textboxFirst.Visible = true;
                textboxSecond.Visible = true;
                textboxThird.Visible = false;
            }
            if (listBox1.SelectedItem == "Circle")
            {
                labelFirst.Visible = true;
                labelFirst.Text = "Radius";
                labelSecond.Visible = false;
                labelThird.Visible = false;
                textboxFirst.Visible = true;
                textboxSecond.Visible = false;
                textboxThird.Visible = false;
            }
        }

        private void labelThird_Click(object sender, EventArgs e)
        {

        }
    }
}
