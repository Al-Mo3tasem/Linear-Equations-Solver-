using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearEquationsSolver.Forms
{
    public partial class Solve_  : Form
    {
        
        public Solve_ ()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {
            richTextBox1.Clear();
            int s, a, c, p = 0;
            float sum;
            float[,] x;//= new float[s, s];
            float[] b;//= new float[s];
            float[,] order;// = new float[s, s];
            float[] border;// = new float[s];
            float[] check;// = new float[s];
            float[] result;// = new float[s];
            float[] r;//= new float[s];
            //old
            s = int.Parse(textBox1.Text);
            a = int.Parse(textBox5.Text);
            x = new float[s, s];
            b = new float[s];
            order = new float[s, s];
            border = new float[s];
            check = new float[s];
            result = new float[s];
            r = new float[s];

            // Maram R2

            string[] ArrSplit1 = richTextBox2.Text.Split(' ');
            float[] arr1 = new float[ArrSplit1.Length];
            for (int i = 0; i < ArrSplit1.Length; i++)
            {
                arr1[i] = float.Parse(ArrSplit1[i]);
            }
            ////
            // Maram R3 
            string[] ArrSplit2 = richTextBox3.Text.Split(' ');
            float[] arr2 = new float[ArrSplit2.Length];
            for (int i = 0; i < ArrSplit2.Length; i++)
            {
                arr2[i] = float.Parse(ArrSplit2[i]);
            }
            ///
            for (int i = 0; i < s; i++)
                result[i] = arr2[i];
            //////////////////////////////////////
            int Q = 0;
            for (int j = 0; j < s; j++)
            {
                for (int i = 0; i < s + 1; i++)
                {
                    if (i < s)
                    {
                        x[i, j] = arr1[Q];
                    }
                    else
                        b[j] = arr1[Q];
                    Q++;
                }
            }

            /////////////////////////////////////////////////////////////
            for (int j = 0; j < s; j++)
            {
                for (int i = 0; i < s + 1; i++)
                {
                    if (i < s)
                    {
                        richTextBox1.Text += (x[i, j] + " X" + (i + 1));
                        if (i + 1 != s)
                            richTextBox1.Text += (" + ");
                    }
                    else
                        richTextBox1.Text += (" = " + b[j] + "");
                }
                richTextBox1.Text += ("\n");
            }
            ///////////////////////////////////////////////////////////

            for (int i = 0; i < s; i++)
                for (int j = 0; j < s; j++)
                {
                    sum = 0;
                    for (int k = 0; k < s; k++)
                        if (j != k)
                            sum += x[k, i];
                    if (sum < Math.Abs(x[j, i]))
                    {
                        for (int m = 0; m < s; m++)
                            order[m, j] = x[m, i];
                        border[j] = b[i];
                        break;
                    }
                }
            richTextBox1.Text += (" ");
            ////////////////////////////////////////////////////////////////
            for (int j = 0; j < s; j++)
            {
                for (int i = 0; i < s + 1; i++)
                {
                    if (i < s)
                    {
                        richTextBox1.Text += (order[i, j] + " X" + (i + 1));
                        if (i + 1 != s)
                            richTextBox1.Text += (" + ");
                    }
                    else
                        richTextBox1.Text += (" = " + border[j] + "");
                }
                richTextBox1.Text += (" ");
            }
            richTextBox1.Text += (" ");
            //////////////////////////////////////////////////////////////////
            if (a == 1)
            {
                while (true)
                {
                    c = 0;
                    richTextBox1.Text += ("\n");
                    richTextBox1.Text += (" Iteration " + (p + 1));
                    for (int i = 0; i < s; i++)
                    {
                        sum = 0;
                        for (int j = 0; j < s; j++)
                            if (i != j)
                            {
                                sum += (-(order[j, i] * result[j]));
                            }
                        r[i] = 1 / order[i, i] * (border[i] + sum);
                        richTextBox1.Text += ("\n");
                        richTextBox1.AppendText("x" + (i + 1) + " = " + r[i] + "     ");
                        //richTextBox1.Text += ("\n");
                        if (p != 0)
                        {
                            check[i] = Math.Abs(r[i] - result[i]);
                            if (check[i] <= 0.01)
                                c += 1;
                            else
                                continue;
                        }
                    }
                    if (check[s - 1] <= 0.01 && c == s)
                    {
                        richTextBox1.Text += ("\n");
                        richTextBox1.Text += ("Final answer is Iteration " + (p + 1));
                        richTextBox1.Text += ("\n");
                        for (int i = 0; i < s; i++)
                        {
                            richTextBox1.AppendText("x" + (i + 1) + " = " + r[i] + "     ");
                            richTextBox1.Text += ("\n");
                        }
                        break;
                    }
                    for (int l = 0; l < s; l++)
                        result[l] = r[l];
                    if (p == 9)
                    {
                        richTextBox1.Text += ("No Solution.");
                        break;
                    }
                    p++;
                }
            }
            /////////////////////////////////////////////////////////
            else if (a == 2)
            {

                while (true)
                {
                    c = 0;
                    for (int i = 0; i < s; i++)
                    {
                        sum = 0;
                        for (int j = 0; j < s; j++)
                            if (i != j)
                                sum += (-(order[j, i] * result[j]));
                        result[i] = 1 / order[i, i] * (border[i] + sum);
                        if (p != 0)
                        {
                            check[i] = Math.Abs(result[i] - r[i]);
                            if (check[i] <= 0.01)
                                c += 1;
                            else
                                continue;
                        }
                    }
                    if (check[s - 1] <= 0.01 && c == s)
                    {
                        richTextBox1.Text += ("Final answer is Iteration " + (p + 1));
                        for (int i = 0; i < s; i++)
                            richTextBox1.Text += ("x" + (i + 1) + " = " + result[i] + "     ");
                        break;
                    }
                    for (int i = 0; i < s; i++)
                        r[i] = result[i];
                    if (p == 9)
                    {
                        richTextBox1.Text += ("No Solution.");
                        break;

                    }
                    p++;
                }
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
        /* private void Start_Load(object sender, EventArgs e)
{
LoadTheme();
}
private void LoadTheme()
{
foreach (Control btns in this.Controls)
{
if (btns.GetType() == typeof(Button))
{
Button btn = (Button)btns;
btn.BackColor = ThemeColor.PrimaryColor;
btn.ForeColor = Color.White;
btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
}
}
}*/
    }
}
