using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _SA_Practica1.Parte1
{
    public partial class Practica2Parte1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string resultado = "";
            var contacto = "";

            //Aqui se establece la requests al cliente
            var client = new RestClient("https://api.softwareavanzado.world/index.php?option=token&api=oauth2");
            var requests = new RestRequest(Method.POST);
            requests.AddHeader("cache-control", "no-cache");
            requests.AddHeader("content-type", "application/x-www-form-urlencoded");

            //parametros para solicitar el token
            requests.AddParameter("application/x-www-form-urlencoded", "grant_type=client_credentials&client_id=sa&client_secret=fb5089840031449f1a4bf2c91c2bd2261d5b2f122bd8754ffe23be17b107b8eb103b441de3771745", ParameterType.RequestBody);

            IRestResponse response = client.Execute(requests);

            //response de credencial de tokens
            dynamic response = JObject.Parse(response.Content);
            String token = response.access_token;

            //Validacion de token obtenido 
            if (token != "")
            {
                Response.Write("TOKEN:" + token);
            }

        

            //creacion de los 10 contactos
            for (int i = 1; i <= 10; i++)
            {
               
                client = new RestClient("https://api.softwareavanzado.world/index.php?webserviceClient=administrator&webserviceVersion=1.0.0&option=contact&api=hal");
                requests = new RestRequest(Method.POST);
                requests.AddHeader("Authorization", "Bearer " + token);
                requests.AddHeader("cache-control", "no-cache");

                //creando el nombre de los contactos 
                contacto = "200714174_test_" + i;
                contacto nuevo = new contacto { name = contacto, published = 1 };

                //JSON para enviar el paràmetro de nombre de contacto
                requests.AddJsonBody(new { name = contacto });
                //se hace la solicitud al cliente 
                response = client.Execute(requests);
                response = JObject.Parse(response.Content);
                resultado = response.result;

              

            }


          

            //Se redirecciona el cliente a la función de listar contactos
            client = new RestClient("https://api.softwareavanzado.world/index.php?webserviceClient=administrator&webserviceVersion=1.0.0&option=contact&api=hal");
            requests = new RestRequest(Method.GET);
            requests.AddHeader("Authorization", "Bearer " + token);
            requests.AddHeader("cache-control", "no-cache");

            //Aplcacion de filtros de la busqueda.
            requests.AddParameter("filter[search]", "200714174_");
            requests.AddParameter("list[limit]", 30);

            //peticion al servicio.
            response = client.Execute(requests);
            response = JObject.Parse(response.Content);

            //llena la tabla con la respuesta de la busqueda
            StringBuilder html = new StringBuilder();
            html.Append("<table border = '1'>");
            html.Append("<tr>");
            html.Append("<th>ID</th>");
            html.Append("<th>Name</th>");
            html.Append("</tr>");
           
            for (int j = 0; j < 10; j++)
            {

                html.Append("<tr>");
                html.Append("<td>" + response._embedded.item[j].id + "</td>");
                html.Append("<td>" + response._embedded.item[j].name + "</td>");
                html.Append("</tr>"); 
            }

            html.Append("</table>");
            this.lblLista.Text = html.ToString();



        }
    }
}