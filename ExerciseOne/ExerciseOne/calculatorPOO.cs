using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ExerciseOne
{
    public partial class calculatorPOO : Form
    {
        public calculatorPOO()
        {
            InitializeComponent();
        }


        // Declarar una variable para almacenar el valor ingresado
       
        //Define
        private double firstNumber;
        private double secondNumber;
        private string currentOperator = "";

        //Values
        public string one = "1";
        public string two = "2";
        public string third = "3";
        public string forth = "4";
        public string fifth = "5";
        public string six = "6";
        public string seven = "7";
        public string eigth = "8";
        public string nine = "9";
        public string zero = "0";

        //public string sum = "+";
        //public string substraction = "-";
        //public string divide = "/";
        //public string multiply = "*";
        //public string porcentage = "%";
        //public string aproximate = "-"; //  -/+
        public string point = ",";
        //public string equal = "=";


        public void Clear()
        {
            firstNumber = 0; //Reset Number

            txtAllResult.Text = string.Empty;
            txtFormula.Text = string.Empty;
        }


        public void designComponents()
        {
            //Create Color -- Forms
            Color backgroundCalc = Color.FromArgb(136, 171, 142);
            Color panelOpt = Color.FromArgb(175, 200, 173);
            Color txtResult = Color.FromArgb(136, 171, 142); //Textbox
            Color Logs = Color.FromArgb(238, 231, 218);
            Color txtformula = Color.FromArgb(136, 171, 142);

            //Set Value -- Forms
            PanelCalc.BackColor = backgroundCalc;
            panelOptions.BackColor = panelOpt;
            txtAllResult.BackColor = txtResult; //Textbox
            PanelLogs.BackColor = Logs;
            txtFormula.BackColor = txtformula;

            txtAllResult.Enabled = true;

            //Create Color -- Buttons
            Color btns = Color.FromArgb(136, 171, 142);

            //Set Value -- Buttons
            btn0.BackColor = btns;
            btn1.BackColor = btns;
            btn2.BackColor = btns;
            btn3.BackColor = btns;
            btn4.BackColor = btns;
            btn5.BackColor = btns;
            btn6.BackColor = btns;
            btn7.BackColor = btns;
            btn8.BackColor = btns;
            btn9.BackColor = btns;
            btnSalir.BackColor = btns;
            btnPoint.BackColor = btns;
            btnPorcentage.BackColor = btns;
            btnSubtraction.BackColor = btns;
            btnSum.BackColor = btns;
            btnMultiply.BackColor = btns;
            btnDelete.BackColor = btns;
            btnDivision.BackColor = btns;
            btnEqual.BackColor = btns;
            btnPotencia.BackColor = btns;
            btnMenu.BackColor = btns;
        }


        private void calculatorPOO_Load(object sender, EventArgs e)
        {

            designComponents(); //Methods Design


        }

        private void btn1_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            one = btn.Text;

            txtAllResult.Text += btn.Text;

        }

        //Dont touch this
        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            two = btn.Text;

            txtAllResult.Text += btn.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            third = btn.Text;

            txtAllResult.Text += btn.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            forth = btn.Text;

            txtAllResult.Text += btn.Text;

        }

        private void btn5_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            fifth = btn.Text;

            txtAllResult.Text += btn.Text;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            six = btn.Text;

            txtAllResult.Text += btn.Text;

        }

        private void btn7_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            seven = btn.Text;

            txtAllResult.Text += btn.Text;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            eigth = btn.Text;

            txtAllResult.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            nine = btn.Text;

            txtAllResult.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            zero = btn.Text;

            txtAllResult.Text += btn.Text;

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            point = btn.Text;

            txtAllResult.Text += btn.Text;

        }


        private void btnSum_Click(object sender, EventArgs e)
        {
            firstNumber += Convert.ToDouble(txtAllResult.Text);
            txtFormula.Text = firstNumber.ToString() + "+";
            txtAllResult.Text = string.Empty;
            currentOperator = "+";


        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtAllResult.Text);
            txtFormula.Text = firstNumber.ToString() + "-";
            txtAllResult.Text = string.Empty;
            currentOperator = "-";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtAllResult.Text);
            txtFormula.Text = firstNumber.ToString() + "*";
            txtAllResult.Text = string.Empty;
            currentOperator = "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtAllResult.Text);
            txtFormula.Text = firstNumber.ToString() + "/";
            txtAllResult.Text = string.Empty;
            currentOperator = "/";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtAllResult.Text);
            txtFormula.Text = firstNumber.ToString() + "^";
            txtAllResult.Text = string.Empty;
            currentOperator = "^";
        }

        private void btnPorcentage_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtAllResult.Text);
            txtFormula.Text = firstNumber.ToString() + "%";
            txtAllResult.Text = string.Empty; //Clean Textbox
            currentOperator = "%";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos en mantenimiento !");
        }

        private void btnAproximate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos en mantenimiento !");

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos en mantenimiento !");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            try
            {
                //double secondNumber;
                double result;

                secondNumber = Convert.ToDouble(txtAllResult.Text);           

                    switch (currentOperator)
                    {
                        case "+":

                            result = (firstNumber + secondNumber);
                            txtAllResult.Text = Convert.ToString(result);

                            txtAllResult.Text = "";
                            txtFormula.Text = firstNumber + "+" + secondNumber + "=" + result;

                            string lasteEc = result.ToString();
                            LastFormula.Text = firstNumber + "+" + secondNumber + "=" + lasteEc;

                            txtAllResult.Text = lasteEc;

                            //goto suma;

                            break;

                        case "-":

                            result = (firstNumber + -secondNumber);
                            txtAllResult.Text = Convert.ToString(result);

                            txtAllResult.Text = "";
                            txtFormula.Text = firstNumber + "-" + secondNumber + "=" + result;

                            lasteEc = result.ToString();
                            LastFormula.Text = firstNumber + "+" + secondNumber + "=" + lasteEc;

                            txtAllResult.Text = lasteEc;


                            break;

                        case "*":

                            result = (firstNumber * secondNumber);
                            txtAllResult.Text = Convert.ToString(result);

                            txtAllResult.Text = "";
                            txtFormula.Text = firstNumber + "*" + secondNumber + "=" + result;

                            lasteEc = result.ToString();
                            LastFormula.Text = firstNumber + "+" + secondNumber + "=" + lasteEc;

                            txtAllResult.Text = lasteEc;


                            break;

                        case "/":

                            if (secondNumber == 0)
                            {
                                MessageBox.Show("cannot divide by zero");
                            }

                            else
                            {
                                result = (firstNumber / secondNumber);
                                txtAllResult.Text = Convert.ToString(result);

                                txtAllResult.Text = "";
                                txtFormula.Text = firstNumber + "/" + secondNumber + "=" + result;

                                lasteEc = result.ToString();
                                LastFormula.Text = firstNumber + "+" + secondNumber + "=" + lasteEc;

                                txtAllResult.Text = lasteEc;

                            }
                            break;

                        /*
                         * 
                         Percentage=( n1 / n2 ) * 100
                         *
                         */

                        case "%":
                            result = (firstNumber / secondNumber) * 100;
                            txtAllResult.Text = Convert.ToString(result);

                            txtAllResult.Text = "";
                            txtFormula.Text = firstNumber + "%" + secondNumber + "=" + result;

                            lasteEc = result.ToString();
                            LastFormula.Text = firstNumber + "%" + secondNumber + "=" + lasteEc;
                            txtAllResult.Text = lasteEc;

                            break;

                    case "^":

                        result = Math.Pow(firstNumber, secondNumber); //Formula Potenciacion 

                        txtAllResult.Text = Convert.ToString(result);

                        txtAllResult.Text = "";
                        txtFormula.Text = firstNumber + "^" + secondNumber + "=" + result;

                        lasteEc = result.ToString();
                        LastFormula.Text = firstNumber + "^" + secondNumber + "=" + lasteEc;
                        txtAllResult.Text = lasteEc;

                        break;

                    case "√":

                        result = Math.Sqrt(firstNumber); //Formula Potenciacion 

                        txtAllResult.Text = Convert.ToString(result);

                        txtAllResult.Text = "";
                        txtFormula.Text = firstNumber + "^" + "=" + result;

                        lasteEc = result.ToString();
                        LastFormula.Text = firstNumber + "^" + "=" + lasteEc;
                        txtAllResult.Text = lasteEc;

                        break;

                    default:
                            MessageBox.Show("No puedes calcular datos vacios.");
                            break;

                    }

                

            }

            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto, por favor intentalo de nuevo!");
            }

        }    
//}


private void btnMercancia_Click(object sender, EventArgs e)
{
    MdiContainers.inventarioMercancias mdi = new MdiContainers.inventarioMercancias();
    mdi.Show();

  //  this.Close();
}

private void txtFormula_TextChanged(object sender, EventArgs e)
{

}

private void btnStadistics_Click(object sender, EventArgs e)
{

}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            MdiContainers.InvAccountBank invAccountBank = new MdiContainers.InvAccountBank();
            invAccountBank.Show();

          //  this.Close();

        }
    }
}
