using ExpressionEvaluator.Core;

namespace ExpressionEvaluator.UI.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnParenthesisOpen_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "(";
        }

        private void btncloseParenthesis_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += ")";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "^";
        }

        private void btnDivide(object sender, EventArgs e)
        {
            DisplayTexto.Text += "/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "3";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text = string.Empty;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += $"={Evaluator.Evaluate(DisplayTexto.Text)}";
        }
    }
}
