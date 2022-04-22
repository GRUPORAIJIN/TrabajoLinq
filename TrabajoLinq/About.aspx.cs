using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoLinq
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PedidosDataContext pedido = new PedidosDataContext();
            var consulta = from C in pedido.Customers
                           select C;
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            PedidosDataContext pedido = new PedidosDataContext();
            var consulta = from C in pedido.Customers
                           select new
                           {
                               Compañia = C.CompanyName,
                               Cliente = C.ContactName,
                               Profesion = C.ContactTitle,
                               Region = C.Region
                           };
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (PedidosDataContext pedido = new PedidosDataContext())
            {
                var nro = TextBox1.Text;
                var consulta = pedido.Customers.Where(C => C.Country == nro);
                GridView1.DataSource = consulta;
                GridView1.DataBind();

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (PedidosDataContext ventas = new PedidosDataContext())
            {

                var consulta = from C in ventas.Customers
                               select new
                               {
                                   Nombres = C.NombresCompletos(),
                                   ID = C.CustomerID
                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (PedidosDataContext ventas = new PedidosDataContext())
            {

                var consulta = from P in ventas.Orders
                               group P by P.Customers.CustomerID into D
                               select new
                               {

                                   CustomerID = D.Key,

                                   Promedio = D.Average(P => P.Freight),
                                   Cantidad = D.Count(),
                                   Pais = D.Select(P => P.ShipRegion)

                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();

            }
        }
    }
}