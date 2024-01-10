using System.Diagnostics;
using log4net.Config;

namespace Calculator_WinApp
{
    public partial class CalculatorApp : Form
    {
        #region logInformation

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
                (typeof(CalculatorApp));
        #endregion
        #region properties/Variables
        double result = 0.0;
        int operandInfo = 0;
        double inputValue=0.0;
        #endregion

        #region Constructor
       
        public CalculatorApp()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
            log4net.Config.XmlConfigurator.Configure();

        }
        #endregion

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 1;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 2;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 3;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 4;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 5;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 6;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 9;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 8;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 7;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 0;
        }

        private void BtndoubleZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 0+0;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            int c = txtDisplay.TextLength;
            int flag = 0;
            string text = txtDisplay.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtDisplay.Text = txtDisplay.Text + ".";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            operandInfo = 0;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            setData(4);
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            setData(3);
        }

        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            setData(2);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            setData(1);
        }

        private void setData(int operand)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && txtDisplay.Text != "")
            {
                Debug.WriteLine(txtDisplay.Text);
                log.Info(txtDisplay.Text);
                operandInfo = operand;
                inputValue = double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                txtDisplay.Focus();
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
           log.Info("Calculation part started");
            calculation(operandInfo);
        }

        private void calculation(int operationInfoData)
        {
            try
            {
            switch (operationInfoData)
            {
                case 1:
                    Debug.WriteLine(txtDisplay.Text);
                    Debug.WriteLine("Add function");
                    log.Info(txtDisplay.Text);
                    log.Debug("Add function");
                    result = inputValue + double.Parse(txtDisplay.Text);
                    txtDisplay.Text = result.ToString();
                    Debug.WriteLine(txtDisplay.Text);
                    log.Info("Result is: " + txtDisplay.Text);
                    log.Debug("Result is: " + txtDisplay.Text);
                    Debug.WriteLine("Result is: "+txtDisplay.Text);
                    break;
                case 2:
                    Debug.WriteLine(txtDisplay.Text);
                    Debug.WriteLine("Subtraction function");
                    log.Info(txtDisplay.Text);
                    log.Debug("Subtraction function");
                    result = inputValue - double.Parse(txtDisplay.Text);
                    txtDisplay.Text = result.ToString();
                    log.Info("Result is: " + txtDisplay.Text);
                    log.Debug("Result is: " + txtDisplay.Text);
                    Debug.WriteLine("Result is: "+txtDisplay.Text);
                    break;
                case 3:
                    Debug.WriteLine(txtDisplay.Text);
                    Debug.WriteLine("Divid function");
                    log.Info(txtDisplay.Text);
                    log.Debug("Divid function");
                    result = inputValue / double.Parse(txtDisplay.Text);
                    txtDisplay.Text = result.ToString();
                    log.Info("Result is: " + txtDisplay.Text);
                    log.Debug("Result is: " + txtDisplay.Text);
                    Debug.WriteLine("Result is: "+txtDisplay.Text);
                    break;
                case 4:
                    Debug.WriteLine(txtDisplay.Text);
                    Debug.WriteLine("Multiplication function");
                    log.Info(txtDisplay.Text);
                    log.Debug("Multiplication function");
                    result = inputValue * double.Parse(txtDisplay.Text);
                    txtDisplay.Text = result.ToString();
                    log.Info("Result is: " + txtDisplay.Text);
                    log.Debug("Result is: " + txtDisplay.Text);
                    Debug.WriteLine("Result is: "+txtDisplay.Text);
                    break;
                default:
                    Debug.WriteLine("Non Operation");
                    log.Warn("No information");
                    break;
            }
            }
            catch
            {
                Debug.WriteLine("Result is undefined");
                log.Error("Result is undefined");
                txtDisplay.Text = "Error";
            }
        }
    }
}
