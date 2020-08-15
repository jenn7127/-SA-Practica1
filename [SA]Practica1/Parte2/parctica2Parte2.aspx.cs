using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _SA_Practica1.Parte2
{
    public partial class parctica2Parte1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                WSHttpBinding myBinding = new WSHttpBinding();
                myBinding.Security.Mode = SecurityMode.Transport;
                myBinding.Security.Transport.ClientCredentialType =
                    HttpClientCredentialType.Basic;

                EndpointAddress ea = new EndpointAddress("https://localhost:51841/Parte2/parctica2Parte2");
                //instancia de cliente par servicio:
                SA_Ap13.administratorcontact100Client clientApi = new SA_Ap13.administratorcontact100Client();
                SA_Ap13.readItemResponse resposeAPI = new SA_Ap13.readItemResponse();
                SA_Ap13.readItemResponse_item intemAPI = new SA_Ap13.readItemResponse_item();
                
                

                //se agregaron las credenciales para el servicio 
               
                clientApi.ClientCredentials.UserName.UserName = "sa";
                clientApi.ClientCredentials.UserName.Password = "usac";

                //clientApi.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.PeerOrChainTrust;

                using(new OperationContextScope(clientApi.InnerChannel))
                {
                    SoapAuthHeader.create(clientApi.ClientCredentials.UserName.UserName, clientApi.ClientCredentials.UserName.Password);
                    string name = "";
                    name = "200714174 " + this.txtName.Text;


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
               

            }
            catch (Exception exe)
            {
                Response.Write("Error de comunicacion con el servidor: "+ exe);
            }
        }

        protected void btnLista_Click(object sender, EventArgs e)
        {

        }
    }
}