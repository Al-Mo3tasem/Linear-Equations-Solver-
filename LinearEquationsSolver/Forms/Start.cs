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
    public partial class Solve_Equations : Form
    {
        public Solve_Equations()
        {
            InitializeComponent();
           
        }

        private void Solve_Equations_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox2.Text == ""&&textBox1.Text=="")
            {
                MessageBox.Show("Please enter the name and the password");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter the password");
            }
            else if(textBox1.Text == "")
            {
                MessageBox.Show("Please enter a name ");
            }
            else if (textBox2.Text == "Math3")
            {
                Solve_ x = new Solve_();
                x.Show();
            }
            else
            {
                MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* private void LoadTheme()
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
             label1.ForeColor = ThemeColor.SecondaryColor;
             label2.ForeColor = ThemeColor.PrimaryColor;
         }*/
    }


    }
