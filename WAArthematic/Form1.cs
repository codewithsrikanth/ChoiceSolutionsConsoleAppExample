using CLibArthematic;
using System;
using System.Windows.Forms;

namespace WAArthematic
{
    public partial class Form1 : Form
    {
        Arthematic obj = new Arthematic();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1 =Convert.ToInt32(txtNum1.Text);
            int num2 =Convert.ToInt32(txtNum2.Text);
            int res = obj.Add(num1, num2);
            lblRes.Text = res.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            int res = obj.Sub(num1, num2);
            lblRes.Text = res.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            int res = obj.Mul(num1, num2);
            lblRes.Text = res.ToString();
        }
    }
}
