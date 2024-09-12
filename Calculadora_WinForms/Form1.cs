namespace Calculadora_WinForms
{
    public partial class Form1 : Form
    {
        float number1;
        EnumOp calcOperator = EnumOp.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        // Number button click events
        // Increments a number in the last position in the text
        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "9";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "6";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "3";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += "0";
        }
        private void btn_Virgula_Click(object sender, EventArgs e)
        {
            txt_SNumber.Text += ",";
        }

        // End of number click events


        // Text change "," verifier
        private void txt_SNumber_TextChanged(object sender, EventArgs e)
        {
            floatVerifier();
        }
        private void floatVerifier()
        {
            bool isFloat = false;
            string newText = "";

            // Looks at each character in the text box
            // excludes any "," after the first one.
            foreach (char t in txt_SNumber.Text)
            {
                if (t.Equals(','))
                {
                    if (isFloat)
                    {
                        continue;
                    }

                    isFloat = true;
                }

                newText += t;
            }
            txt_SNumber.Text = newText;
            return;
        }

        // Operators click event
        // Change to the "EnumOp" selected type
        private void btn_Div_Click(object sender, EventArgs e)
        {
            calcOperator = EnumOp.Divide;
            operationBehavior("/");

        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            calcOperator = EnumOp.Multiplie;
            operationBehavior("x");
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            calcOperator = EnumOp.Subtract;
            operationBehavior("-");
        }

        private void btn_Soma_Click(object sender, EventArgs e)
        {
            operationBehavior("+");
            calcOperator = EnumOp.Add;
        }

        private void operationBehavior(string opType)
        {
            // Changes current operation when there is no number after the operator
            if (txt_OpBox.Text.Length > 0 && txt_SNumber.Text.Length == 0)
            {
                txt_OpBox.Text = $"{number1} {opType}";
                return;
            }

            // try to convert the string into the float
            try
            {
                number1 = float.Parse(txt_SNumber.Text);
            }
            catch
            {
                return;
            }

            txt_SNumber.Text = "";

            txt_OpBox.Text = $"{number1} {opType}";
        }


        // Text handlers click events
        private void btn_Equals_Click(object sender, EventArgs e)
        {
            // Try to convert the string into the float
            float number2;
            try
            {
                number2 = float.Parse(txt_SNumber.Text);
            }
            catch
            {
                return;
            }

            txt_OpBox.Text = "";

            // Use the current "EnumOp" to make the operation
            switch (calcOperator)
            {
                case EnumOp.Multiplie:
                    txt_SNumber.Text = $"{number1 * number2}";
                    break;
                case EnumOp.Divide:
                    txt_SNumber.Text = $"{number1 / number2}";
                    break;
                case EnumOp.Subtract:
                    txt_SNumber.Text = $"{number1 - number2}";
                    break;
                case EnumOp.Add:
                    if (number1 == 2 && number2 == 5)
                    {
                        txt_SNumber.Text = "Hello World!";
                        return;
                    }

                    txt_SNumber.Text = $"{number1 + number2}";

                    break;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // resets everything
            calcOperator = EnumOp.Empty;
            number1 = 0;
            txt_OpBox.Text = "";
            txt_SNumber.Text = "";
        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            // There is no more text in the principal text box but there is some in operator box
            if (txt_SNumber.Text.Length == 0 && txt_OpBox.Text.Length > 0)
            {
                txt_SNumber.Text = $"{number1}";
                txt_OpBox.Text = "";
                calcOperator = EnumOp.Empty;
                return;
            }
            
            // Everything is empty
            if(txt_SNumber.Text.Length == 0 && txt_OpBox.Text.Length == 0)
            {
                return;
            }

            // Erase the last number
            txt_SNumber.Text = txt_SNumber.Text.Remove(txt_SNumber.Text.Length - 1);
        }
    }
}
