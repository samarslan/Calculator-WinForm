namespace WinForm_Calculator
{
    public partial class Form1 : Form
    {
        Double value=0;
        string operation;
        bool operaionPressed=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            result.Text += button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Convert.ToDouble(result.Text);
            operaionPressed = true;
            result.Text = string.Empty;
            equation.Text = value + " " + operation;    
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = string.Empty;
            switch(operation)
            {
                case "+":
                    result.Text = (value + Convert.ToDouble(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Convert.ToDouble(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Convert.ToDouble(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Convert.ToDouble(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operaionPressed = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = string.Empty;
        }
    }
}