namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String CalTotal;
        int number1;
        int number2;
        string option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button9.Text;

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + buttonZero.Text;

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            number1 = int.Parse(textTotal.Text);
            textTotal.Clear();

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            number1 = int.Parse(textTotal.Text);
            textTotal.Clear();

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            number1 = int.Parse(textTotal.Text);
            textTotal.Clear();

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            number1 = int.Parse(textTotal.Text);
            textTotal.Clear();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textTotal.Clear();

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            number2 = int.Parse(textTotal.Text);
            if (option.Equals("+"))
                result = number1 + number2;
            if (option.Equals("-"))
                result = number1 - number2;
            if (option.Equals("*"))
                result = number1 * number2;
            if (option.Equals("/"))
                result = number1 / number2;

            textTotal.Text = result + "";
        }
    }
}
