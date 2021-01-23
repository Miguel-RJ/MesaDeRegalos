using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesaDeRegalos
{

    public class Invitado
    {
        public int idInvitado { get; set; }
        public string nombreInvitado { get; set; }
        public string apellidosInvitado { get; set; }
        public string emailInvitado { get; set; }
        public string phoneInvitado { get; set; }
    }

    public class ListaDeseo
    {
        public int idDeseo { get; set; }
        public string invitadosNombreInvitado { get; set; }
        public string invitadosApellidosInvitado { get; set; }
        public string productosNombreProducto { get; set; }
        public double productosPrecioProducto { get; set; }
        public int productosStockProducto { get; set; }
        public bool productosEstatusProducto { get; set; }
        public bool vendido { get; set; }
        public object mensaje { get; set; }
    }

    public class Producto
    {
        public int idEvento { get; set; }
        public string nombreEncargado { get; set; }
        public string apellidosEncargado { get; set; }
        public string direccionEncargado { get; set; }
        public string phoneEncargado { get; set; }
        public string linkListaInventario { get; set; }
        public bool estatusEvento { get; set; }
        public string categoriasNombreCategoria { get; set; }
        public List<Invitado> invitados { get; set; }
        public List<ListaDeseo> listaDeseos { get; set; }
    }


}
