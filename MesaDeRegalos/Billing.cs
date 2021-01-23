using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesaDeRegalos
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            double total = 0;
            foreach (DataGridViewRow item in gridRegalos.Rows)
            {
                total += Convert.ToDouble(item.Cells[1].Value.ToString());
            }

            lblTotal.Text = "Total: $" + total.ToString();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != string.Empty && txtNombre.Text != string.Empty && txtCVV.Text != string.Empty)
            {
                MessageBox.Show("Gracias por su regalo.", "Gratula");
            }
            else
            {
                MessageBox.Show("Complete los datos bancarios", "Alerta");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ListaDeseos listaDeseosWindow = new ListaDeseos();
            listaDeseosWindow.Show();

            this.Close();
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }
    }
}
