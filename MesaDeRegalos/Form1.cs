using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace MesaDeRegalos
{
    public partial class ListaDeseos : Form
    {
        static HttpClient client = new HttpClient();
        public ListaDeseos()
        {
            InitializeComponent();
            GetProductAsync("http://localhost:8080/api/eventos/1");
            MessageBox.Show("Bienvenido a la mesa de regalos de David y Daniela", "Mesa de Regalos");
        }

        async Task<Producto> GetProductAsync(string path)
        {
            string jsonNoFormat = string.Empty;
            Producto product = new Producto();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                jsonNoFormat = await response.Content.ReadAsStringAsync();
            }

            //jsonNoFormat = "{\"Producto\":" + jsonNoFormat + "}";

            Producto obj = JsonConvert.DeserializeObject<Producto>(jsonNoFormat);

            foreach (var item in obj.listaDeseos)
            {
                if (!item.vendido)
                {
                    gridDeseos.Rows.Add(item.productosNombreProducto, item.productosPrecioProducto);
                }
            }



            return product;
        }

        //private static void GetItems(string filter)
        //{
        //    var client = new RestClient("http://localhost:8080");
        //    var request = new RestRequest("items", Method.GET);
        //    request.AddParameter("filter", filter);
        //    var response = client.Execute(request);
        //    Console.WriteLine(response.Content);
        //}

        private async void gridDeseos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                string Deseo = gridDeseos.Rows[e.RowIndex].Cells[0].Value.ToString();
                double Precio = Convert.ToDouble(gridDeseos.Rows[e.RowIndex].Cells[1].Value.ToString());
                gridRegalos.Rows.Add(Deseo, Precio);

                gridDeseos.Rows.RemoveAt(e.RowIndex);

                btnConfirmar.Enabled = true;
            }
        }

        private void gridRegalos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                string Deseo = gridRegalos.Rows[e.RowIndex].Cells[0].Value.ToString();
                double Precio = Convert.ToDouble(gridRegalos.Rows[e.RowIndex].Cells[1].Value.ToString());
                gridDeseos.Rows.Add(Deseo, Precio);

                gridRegalos.Rows.RemoveAt(e.RowIndex);
            }

            if (gridRegalos.Rows.Count == 0)
            {
                btnConfirmar.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Billing billingWindow = new Billing();
            billingWindow.Show();
            foreach (DataGridViewRow item in gridRegalos.Rows)
            {
                string Deseo = item.Cells[0].Value.ToString();
                double Precio = Convert.ToDouble(item.Cells[1].Value.ToString());
                billingWindow.gridRegalos.Rows.Add(Deseo, Precio);
            }

            double total = 0;
            foreach (DataGridViewRow item in gridRegalos.Rows)
            {
                total += Convert.ToDouble(item.Cells[1].Value.ToString());
            }

            billingWindow.lblTotal.Text = "Total: $" + total.ToString();

            Hide();
        }

        private void ListaDeseos_Load(object sender, EventArgs e)
        {

        }
    }
}
