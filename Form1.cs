using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstValue = 0;
        double secondValue = 0;
        string operation = "";
        
       

     

        public Form1()
        {
           

            InitializeComponent();
        }
        

        private void calculate()
        {
            switch (operation)
            {
                case "+":
                    secondValue = firstValue + Convert.ToDouble(txbx_result.Text);
                    txbx_result.Clear();
                    txbx_result.Text = secondValue.ToString();

                    break;

                case "-":
                    secondValue = firstValue - Convert.ToDouble(txbx_result.Text);
                    txbx_result.Clear();
                    txbx_result.Text = secondValue.ToString();

                    break;

                case "/":
                    secondValue = firstValue / Convert.ToDouble(txbx_result.Text);
                    txbx_result.Clear();
                    txbx_result.Text = secondValue.ToString();

                    break;

                case "*":
                    secondValue = firstValue * Convert.ToDouble(txbx_result.Text);
                    txbx_result.Clear();
                    txbx_result.Text = secondValue.ToString();

                    break;

               
            }
        }

   
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            if (txbx_result.Text == "0")
            {
                txbx_result.Clear();
            }


            Button button = (Button)sender;

            txbx_result.Text += button.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
 

            operation = "-";
            firstValue = Convert.ToDouble(txbx_result.Text);
            txbx_result.Clear();

            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(txbx_result.Text);

            operation = "+";

            txbx_result.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(txbx_result.Text);

            operation = "*";
            txbx_result.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(txbx_result.Text);

            operation = "/";
            txbx_result.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txbx_result.Clear();
            txbx_result.Text += "0";
        }
    }
}
