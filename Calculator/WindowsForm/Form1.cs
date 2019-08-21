using System;
using Calculator;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        static int counter = 0;
        static double num1 = 0;
        static double num2 = 0;
        static string opp = "";
        public Form1()
        {
            InitializeComponent();
            Calculator c1 = new Calculator();
            lblResult.Text = c1.num1.ToString();
        }
        
        private void btn0_Click(object sender, EventArgs e)
        {
            if (counter == 0)
                num1 = 0;
            else if (counter == 1)
                num2 = 0;

            counter++;
        }
    }
}
