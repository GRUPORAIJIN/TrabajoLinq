using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoLinq
{
    public partial class Contact : Page
    {
        private PedidosDataContext pedido = new PedidosDataContext();

        private IList<Customers> Listar()
        {
            var consulta = from C in pedido.Customers
                           select C;

            return consulta.ToList();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
                GridView1.DataSource = Listar();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customers cliente = new Customers();
            cliente.CustomerID = TextBox1.Text.Trim();
            cliente.CompanyName = TextBox2.Text.Trim();
            cliente.ContactName = TextBox3.Text.Trim();
            cliente.ContactTitle = TextBox4.Text.Trim();
            cliente.Address = TextBox5.Text.Trim();
            cliente.City = TextBox6.Text.Trim();
            cliente.Region = TextBox7.Text.Trim();
            cliente.PostalCode = TextBox8.Text.Trim();
            cliente.Country = TextBox9.Text.Trim();
            cliente.Phone = TextBox10.Text.Trim();
            cliente.Fax = TextBox11.Text.Trim();
            pedido.Customers.InsertOnSubmit(cliente);

            try
            {
                pedido.SubmitChanges();
                GridView1.DataSource = Listar();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Customers cliente = pedido.Customers.Single(C => C.CustomerID == TextBox1.Text.Trim());
            cliente.CompanyName = TextBox2.Text.Trim();
            cliente.ContactName = TextBox3.Text.Trim();
            cliente.ContactTitle = TextBox4.Text.Trim();
            cliente.Address = TextBox5.Text.Trim();
            cliente.City = TextBox6.Text.Trim();
            cliente.Region = TextBox7.Text.Trim();
            cliente.PostalCode = TextBox8.Text.Trim();
            cliente.Country = TextBox9.Text.Trim();
            cliente.Phone = TextBox10.Text.Trim();
            cliente.Fax = TextBox11.Text.Trim();

            try
            {
                pedido.SubmitChanges();
                GridView1.DataSource = Listar();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var codigo = (from C in pedido.Customers
                          where C.CustomerID.Contains(TextBox1.Text.Trim())
                          select C).First();
            pedido.Customers.DeleteOnSubmit(codigo);
            try
            {
                pedido.SubmitChanges();
                GridView1.DataSource = Listar();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;
            TextBox2.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[2].Text;
            TextBox3.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[3].Text;
            TextBox4.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[4].Text;
            TextBox5.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[5].Text;
            TextBox6.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[6].Text;
            TextBox7.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[7].Text;
            TextBox8.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[8].Text;
            TextBox9.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[9].Text;
            TextBox10.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[10].Text;
            TextBox11.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[11].Text;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            

            Listar();
        }
    }
}