namespace Calculator
{
    public partial class Form1 : Form
    {
        private float _num1, _num2;
        private int _count;
        private bool _sign = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            switch(_count)
            {
                case 1:
                    _num2 = _num1 + float.Parse(textBox1.Text);
                    break;
                case 2:
                    _num2 = _num1 - float.Parse(textBox1.Text);
                    break;
                case 3:
                    _num2 = _num1 * float.Parse(textBox1.Text);
                    break;
                case 4:
                    _num2 = _num1 / float.Parse(textBox1.Text);
                    break;

                default:
                    break;
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += 0;
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text.Substring(1) + 1;
            else
                textBox1.Text += 1;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text.Substring(1) + 2;
            else
                textBox1.Text += 2;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text.Substring(1) + 3;
            else
                textBox1.Text += 3;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text.Substring(1) + 4;
            else
                textBox1.Text += 4;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text.Substring(1) + 5;
            else
                textBox1.Text += 5;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text.Substring(1) + 6;
            else
                textBox1.Text += 6;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text.Substring(1) + 7;
            else
                textBox1.Text += 7;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text.Substring(1) + 8;
            else
                textBox1.Text += 8;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text.Substring(1) + 9;
            else
                textBox1.Text += 9;
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !textBox1.Text.Contains(',', StringComparison.CurrentCulture))
                textBox1.Text += ",";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                _num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                _count = 1;
                label1.Text = _num1.ToString() + "+";
                _sign = true;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                _num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                _count = 2;
                label1.Text = _num1.ToString() + "-";
                _sign = true;
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { 
                _num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                _count = 3;
                label1.Text = _num1.ToString() + "*";
                _sign = true;
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                _num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                _count = 4;
                label1.Text = _num1.ToString() + "/";
                _sign = true;
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" && textBox1.Text != "")
            {
                Calculate();

                label1.Text = "";
                textBox1.Text = _num2.ToString();

                if (_num2 < 0)
                    _sign = false;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void lastClear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            //else
            //    textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "0");
        }

        private void changeSign_Click(object sender, EventArgs e)
        {
            if (_sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                _sign = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                _sign = true;
            }
        }
    }
}