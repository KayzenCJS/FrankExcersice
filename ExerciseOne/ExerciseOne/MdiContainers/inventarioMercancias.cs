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
    public partial class inventarioMercancias : Form
    {
        public inventarioMercancias()
        {
            InitializeComponent();
        }

        int NoAjuste = 1;
        double compras, ventas, existencias;

        //Methods
        public void Entradas()
        {         
                try
                {
                    if (!string.IsNullOrEmpty(txtCompras.Text))
                    {
                        compras = Convert.ToDouble(txtCompras.Text);
                    }
                    else
                    {
                        compras = 0;
                    }

                    if (!string.IsNullOrEmpty(txtVentas.Text))
                    {
                        ventas = Convert.ToDouble(txtVentas.Text);
                    }
                    else
                    {
                        ventas = 0;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato incorrecto");
                    txtCompras.Focus();
                }
        }

        public void calculos()
        {
            try
            {
                Entradas();

                if (txtCompras.Text == string.Empty || txtVentas.Text == string.Empty)
                {
                    MessageBox.Show("No puedes dejar los campos vacios!");
                }
                else
                {
                    existencias = (existencias + compras) - ventas;
                    txtExistencia.Text = Convert.ToString(existencias);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato Incorrecto. ");
            }
            
        }

        public void Nuevo()
        {
            NoAjuste++; //{NOAJUSTE = NOAJUSTE + 1;

            txtNumAjuste.Text = Convert.ToString(NoAjuste);

            CbArticulo.Text = "SELECT ANOTHER ITEM";

            //Menu
            CbArticulo.Items.Add("Mouse");
            CbArticulo.Items.Add("Keyboard");
            CbArticulo.Items.Add("TV");

            txtCompras.Text = "0";
            txtVentas.Text = "0";

        }

        private void txtArticulos_Load(object sender, EventArgs e)
        {

        }

        private void txtExistencia_Load(object sender, EventArgs e)
        {

        }

        private void txtCompras_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calculos();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnFinally_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelbackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inventarioMercancias_Load(object sender, EventArgs e)
        {
            txtNumAjuste.Text = Convert.ToString(NoAjuste);
            txtNumAjuste.Enabled = false;
            txtExistencia.Enabled = false;
            CbArticulo.Text = "ESCOJA EL ARTICULO DESEADO";
            txtCompras.Text = "0";
            txtVentas.Text = "0";

            //Propiedades
            Color backgroundCalc = Color.FromArgb(136, 171, 142);

            panelbackground.BackColor = backgroundCalc;
            CbArticulo.BackColor = backgroundCalc;
            txtCompras.BackColor = backgroundCalc;
            txtExistencia.BackColor = backgroundCalc;
            txtNumAjuste.BackColor = backgroundCalc;
            txtVentas.BackColor = backgroundCalc;

            btnCalc.BackColor = backgroundCalc;
            btnNew.BackColor = backgroundCalc;
            btnFinally.BackColor = backgroundCalc;

        }

        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
