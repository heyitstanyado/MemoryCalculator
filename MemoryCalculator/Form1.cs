using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCalculator
{
    public partial class Form1 : Form
    {
        string input = "";
        string[] pastExpr = { "", "", "" };

        public Form1()
        {
            InitializeComponent();
        }

        private void addToHistory(string input)
        {
            for (int i = pastExpr.Length - 1; i > 0; i--)
            {
                pastExpr[i] = pastExpr[i - 1];
            }

            pastExpr[0] = input; 
        }

        private void updateResultHistory()
        {
            this.resultWindow.Items.Clear();
            for (int i = 0; i < pastExpr.Length; i++)
            {
                this.resultWindow.Items.Add(pastExpr[i]);                 
            }
        }


        private void zero_Click(object sender, EventArgs e)
        {
            input += "0";
            this.resultWindow.Text = input;
           
        }

        private void one_Click(object sender, EventArgs e)
        {
            input += "1";
            this.resultWindow.Text = input; 
        }

        private void two_Click(object sender, EventArgs e)
        {
            input += "2";
            this.resultWindow.Text = input; 
        }

        private void three_Click(object sender, EventArgs e)
        {
            input += "3";
            this.resultWindow.Text = input; 
        }

        private void four_Click(object sender, EventArgs e)
        {
            input += "4";
            this.resultWindow.Text = input; 
        }

        private void five_Click(object sender, EventArgs e)
        {
            input += "5";
            this.resultWindow.Text = input; 
        }

        private void six_Click(object sender, EventArgs e)
        {
            input += "6";
            this.resultWindow.Text = input; 
        }

        private void seven_Click(object sender, EventArgs e)
        {
            input += "7";
            this.resultWindow.Text = input; 
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input += "8";
            this.resultWindow.Text = input; 
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input += "9";
            this.resultWindow.Text = input; 
        }

        private void period_Click(object sender, EventArgs e)
        {
            input += ".";
            this.resultWindow.Text = input; 
        }

        private void clr_Click(object sender, EventArgs e)
        {
            input = "";
            this.resultWindow.Text = input;

        }

        private void divide_Click(object sender, EventArgs e)
        {
            input += " / ";
            this.resultWindow.Text = input; 
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            input += " * ";
            this.resultWindow.Text = input; 
        }

        private void minus_Click(object sender, EventArgs e)
        {
            input += " - ";
            this.resultWindow.Text = input; 
        }

        private void add_Click(object sender, EventArgs e)
        {
            input += " + ";
            this.resultWindow.Text = input; 
   
        }

        private void mod_Click(object sender, EventArgs e)
        {
            input += " % ";
            this.resultWindow.Text = input;
        }

        private void openParenth_Click(object sender, EventArgs e)
        {
            input += "(";
            this.resultWindow.Text = input;
        }

        private void closeParenth_Click(object sender, EventArgs e)
        {
            input += ")";
            this.resultWindow.Text = input;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                input = this.resultWindow.Text; 
                object result = new DataTable().Compute(input, null);

                this.resultWindow.Text = result.ToString();

                addToHistory(input);
                updateResultHistory();
                input = "";

            }
            catch
            {
                
                this.resultWindow.Text = "ERROR";

                addToHistory(input);
                updateResultHistory();
                input = "";
            }
        }

        private void inputWindow_TextChanged(object sender, EventArgs e)
        {
            //Isn't used
        }






    }
}
