using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseOne.MdiContainers
{
    public partial class InvAccountBank : Form
    {
        //Variables
        private string account;
        private double deposito, retiros, balance;
        private double nTransaccion = 1;
        private DateTime dateTime;


        public InvAccountBank()
        {
            InitializeComponent();
        }

        private void InvAccountBank_Load(object sender, EventArgs e)
        {
            txtTransiccion.Text = nTransaccion.ToString();

            txtTransiccion.Enabled = false;
            txtBalance.Enabled = false;

        }

        public void Entradas()
        {
            try
            {
                if (cbaAccount.Text == string.Empty || txtDepositos.Text == string.Empty || txtReturis.Text == string.Empty || txtTransiccion.Text == string.Empty)
                {
                    MessageBox.Show("YOU CANNOT LEAVE THE FIELD EMPTY!");
                }
                else
                {
                    account = cbaAccount.Text;

                    deposito = Convert.ToDouble(txtDepositos.Text);
                    retiros = Convert.ToDouble(txtReturis.Text);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("The input isn't valid yet !");
                txtReturis.Focus();
                txtDepositos.Focus();

            }
        }

        public void Nuevo()
        {
            Entradas();

            nTransaccion++;
            txtTransiccion.Text = Convert.ToString(nTransaccion);
            cbaAccount.Text = "Seleccione el numero de cuenta";

            dateTime = txtdate.Value;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Calcular()
        {
            try
            {
                balance = deposito - retiros;
                txtBalance.Text = balance.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error while calculating balance!");
            }
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtDepositos.Text == string.Empty || txtReturis.Text == string.Empty || txtTransiccion.Text == string.Empty)
            {
                MessageBox.Show("YOU CANNOT LEAVE THE FIELD EMPTY!");
            }
            else
            {
                Calcular();

                richTextBox1.Text =  "Numero de cuenta: " + account;
                richTextBox2.Text = "Balance actual: " + balance;


            }
        }
    }
}
