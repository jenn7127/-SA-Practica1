using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _SA_Practica1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //instancia de cliente par servicio:
            SA_API.administratorcontact100Client clientApi = new SA_API.administratorcontact100Client();
            SA_API.readItemResponse resposeAPI = new SA_API.readItemResponse();
            SA_API.readItemResponse_item intemAPI = new SA_API.readItemResponse_item();

            string name = "";
            name = "200714174 " + this.txtName.Text;

            try
            {
                Boolean res = false;
                res = clientApi.create(name, 0, "", 0);
                if (res)
                {
                    Response.Write("Registro agregado exitosamente");
                }
                else
                {
                    Response.Write("Error al agregar registro");
                }

                this.txtName.Text = "";
            }
            catch (Exception exe)
            {
                Response.Write("Error de comunicacion con el servidor");
            }
        }

        protected void btnLista_Click(object sender, EventArgs e)
        {
            //intancia de cliente del servicio
            SA_API.administratorcontact100Client clientApi = new SA_API.administratorcontact100Client();
            SA_API.readListResponse listResponse = new SA_API.readListResponse();
            SA_API.readListResponse_list_item lista = new SA_API.readListResponse_list_item();

            try
            {
                listResponse.list = clientApi.readList(0, 10, "200714174", null, "", "", "").ToArray();
                int numResultados = listResponse.list.Count();

                StringBuilder html = new StringBuilder();
                html.Append("<table border = '1'>");
                html.Append("<tr>");
                html.Append("<th>ID</th>");
                html.Append("<th>Name</th>");
                html.Append("</tr>");
                for (int i = 0; i < numResultados; i++)
                {
                    lista = listResponse.list.ElementAt(i);
                    html.Append("<tr>");
                    html.Append("<td>" + lista.id + "</td>");
                    html.Append("<td>" + lista.name + "</td>");
                    html.Append("</tr>");
                }
                html.Append("</table>");
                this.lblTabla.Text = html.ToString();

            }
            catch (Exception exe)
            {
                Response.Write("Error de comunicacion con el servidor");
            }
        }
    }
}