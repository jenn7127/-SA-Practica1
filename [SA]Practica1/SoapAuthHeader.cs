using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;

namespace _SA_Practica1
{
    public static class SoapAuthHeader
    {
       public static void create(string username,string password)
        {
            //Agrengando un HTTP SOAP header para una solicitud 
            string auth = "Basic" + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(username +":"+ password));
            HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
            requestMessage.Headers.Add("Authorization", auth);
            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

        } 
    }
}