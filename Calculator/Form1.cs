using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string firstElement = "0";
        private EnumOperations lastOperation;
        private EnumOperations currentOperation;
        private string lastSecondElement = "";
        private string secondElement = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (currentOperation == EnumOperations.Result)
            {
                ResetCalc();
            }

            if(currentOperation == EnumOperations.None)
            {
                if (firstElement == "0")
                {
                    firstElement = b.Text;
                }
                else
                {
                    firstElement += b.Text;
                }

                tbResult.Text = firstElement;
            }
            else
            {
                if (secondElement == "" || secondElement == "0")
                {
                    secondElement = b.Text;
                }
                else
                {
                    secondElement += b.Text;
                }

                tbResult.Text = secondElement;
            }

            lastSecondElement = "";
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetCalc();
        }

        private void ResetCalc()
        {
            currentOperation = EnumOperations.None;
            firstElement = "0";
            secondElement = "";
            lastSecondElement = "";
            tbResult.Text = "0";
        }

        private void tbComma_Click(object sender, EventArgs e)
        {
            switch (currentOperation)
            {
                case EnumOperations.None:
                    CheckComma(ref firstElement);
                    break;
                default:
                    CheckComma(ref secondElement);
                    break;
            }
        }

        private void CheckComma(ref string inElement)
        {
            if (inElement == null)
            {
                return;
            }
            if (inElement.Length >= 1)
            {
                if (!inElement.Contains(","))
                {
                    inElement += tbComma.Text;
                }
            }

            tbResult.Text = inElement;
        }

        private void btNegative_Click(object sender, EventArgs e)
        {
            if (firstElement != "0")
            {
                try
                {
                    firstElement = (Convert.ToDouble(firstElement) * -1).ToString();
                    tbResult.Text = firstElement;
                }
                catch (Exception ex)
                {
                    firstElement = "0";
                    tbResult.Text = ex.Message;
                }
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            switch (currentOperation)
            {
                case EnumOperations.None:
                    break;
                case EnumOperations.Plus:
                    {
                        if (secondElement != "")
                        {
                            if (lastSecondElement == "")
                            {
                                firstElement = (Convert.ToDouble(firstElement) + Convert.ToDouble(secondElement)).ToString();
                                lastSecondElement = secondElement;
                                secondElement = "0";
                            }
                            else
                            {
                                firstElement = (Convert.ToDouble(firstElement) + Convert.ToDouble(lastSecondElement)).ToString();
                            }

                            tbResult.Text = firstElement;
                        }
                        break;
                    }
                case EnumOperations.Minus:
                case EnumOperations.Multiply:
                case EnumOperations.Divide:
                case EnumOperations.Result:
                    secondElement = "0";
                    break;
                default:
                    break;
            }

            currentOperation = EnumOperations.Plus;
            lastOperation = EnumOperations.Plus;
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            if (secondElement != "")
            {
                switch (lastOperation)
                {
                    case EnumOperations.None:
                        break;
                    case EnumOperations.Plus:
                        firstElement = (Convert.ToDouble(firstElement) + Convert.ToDouble(secondElement)).ToString();
                        tbResult.Text = firstElement;
                        break;
                    case EnumOperations.Minus:
                        firstElement = (Convert.ToDouble(firstElement) - Convert.ToDouble(secondElement)).ToString();
                        tbResult.Text = firstElement;
                        break;
                    case EnumOperations.Multiply:
                        firstElement = (Convert.ToDouble(firstElement) * Convert.ToDouble(secondElement)).ToString();
                        tbResult.Text = firstElement;
                        break;
                    case EnumOperations.Divide:
                        firstElement = (Convert.ToDouble(firstElement) / Convert.ToDouble(secondElement)).ToString();
                        tbResult.Text = firstElement;
                        break;
                }
            }

            currentOperation = EnumOperations.Result;
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            switch (currentOperation)
            {
                case EnumOperations.None:
                    break;
                case EnumOperations.Minus:
                    {
                        if (lastSecondElement == "")
                        {
                            firstElement = (Convert.ToDouble(firstElement) - Convert.ToDouble(secondElement)).ToString();
                            lastSecondElement = secondElement;
                            secondElement = "0";
                        }
                        else
                        {
                            firstElement = (Convert.ToDouble(firstElement) - Convert.ToDouble(lastSecondElement)).ToString();
                        }

                        tbResult.Text = firstElement;
                        break;
                    }
                case EnumOperations.Plus:
                case EnumOperations.Multiply:
                case EnumOperations.Divide:
                case EnumOperations.Result:
                    secondElement = "0";
                    break;
                default:
                    break;
            }

            currentOperation = EnumOperations.Minus;
            lastOperation = EnumOperations.Minus;
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            switch (currentOperation)
            {
                case EnumOperations.None:
                    break;
                case EnumOperations.Multiply:
                    {
                        if (secondElement != "")
                        {
                            if (lastSecondElement == "")
                            {
                                firstElement = (Convert.ToDouble(firstElement) * Convert.ToDouble(secondElement)).ToString();
                                lastSecondElement = secondElement;
                                secondElement = "0";
                            }
                            else
                            {
                                firstElement = (Convert.ToDouble(firstElement) * Convert.ToDouble(lastSecondElement)).ToString();
                            }

                            tbResult.Text = firstElement;
                        }
                        break;
                    }
                case EnumOperations.Plus:
                case EnumOperations.Minus:
                case EnumOperations.Divide:
                case EnumOperations.Result:
                    secondElement = "0";
                    break;
                default:
                    break;
            }

            currentOperation = EnumOperations.Multiply;
            lastOperation = EnumOperations.Multiply;
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            switch (currentOperation)
            {
                case EnumOperations.None:
                    break;
                case EnumOperations.Divide:
                    {
                        if (secondElement != "")
                        {
                            if (lastSecondElement == "")
                            {
                                firstElement = (Convert.ToDouble(firstElement) / Convert.ToDouble(secondElement)).ToString();
                                lastSecondElement = secondElement;
                                secondElement = "0";
                            }
                            else
                            {
                                firstElement = (Convert.ToDouble(firstElement) / Convert.ToDouble(lastSecondElement)).ToString();
                            }

                            tbResult.Text = firstElement;
                        }
                        break;
                    }
                case EnumOperations.Plus:
                case EnumOperations.Minus:
                case EnumOperations.Multiply:
                case EnumOperations.Result:
                    secondElement = "0";
                    break;
                default:
                    break;
            }

            currentOperation = EnumOperations.Divide;
            lastOperation = EnumOperations.Divide;
        }
    }
}
