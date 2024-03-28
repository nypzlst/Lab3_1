using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float txtRl1 = float.Parse(textReal1.Text);
            float txtRl2 = float.Parse(textReal2.Text);
            float txtIm1 = float.Parse(textImg1.Text);
            float txtIm2 = float.Parse(textImg2.Text);

            Complex complex1 = new Complex(txtRl1, txtIm1);
            Complex complex2 = new Complex(txtRl2, txtIm2);

            Pair res = complex1.Add(complex2);
            Pair res2 = complex1.Multiply(complex2);
            Pair res3 = complex1.Subtract(complex2);
            Pair res4 = complex1.Divide(complex2);
            label1.Text = res.ToString();
            label3.Text = res2.ToString();
            label4.Text = res3.ToString();
            label5.Text = res4.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //float txtVal1 = float.Parse(textVal1.Text);
            //float txtVal2 = float.Parse(textVal2.Text);
            //float txtMem1 = float.Parse(textMem1.Text);
            //float txtMem2 = float.Parse(textMem2.Text);

            //FazzyNumber fazzyNumber1 = new FazzyNumber(txtVal1, txtMem1);
            //FazzyNumber fazzyNumber2 = new FazzyNumber(txtVal2, txtMem2);

            //Pair sum = fazzyNumber1.Add(fazzyNumber2);
            //label2.Text = sum.ToString();
        }
    }
}
