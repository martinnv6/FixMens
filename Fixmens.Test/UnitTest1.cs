using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FixMens.BLL;
using FixMens.Models;

namespace Fixmens.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConsultarOrdenClienteExistente()
        {
            Orden orden = new Orden();
            var result = orden.ConsultarOrden("LUZ", 12344, "");
            Assert.IsTrue(result != default(OrdenModel));
        }
        [TestMethod]
        public void ConsultarOrdenClienteErroneo()
        {
            Orden orden = new Orden();
            var result = orden.ConsultarOrden("LUZAAAAAAAAAAAA", 12344, "");
            Assert.IsTrue(result != default(OrdenModel));
        }


        [TestMethod]
        public void ValidateCertificate()
        {
            //ServicePointManager.ServerCertificateValidationCallback += ServerCertificateValidationCallback;
            string message = "";
            var request = WebRequest.Create("https://www.junomx.com");

            var response = request.GetResponse();

            var pointCertificate = ((HttpWebRequest)request).ServicePoint.Certificate;
            if (pointCertificate != null)
            {
                var expirationDate = DateTime.Parse(pointCertificate.GetExpirationDateString());
                if ((expirationDate - DateTime.Now).Days < 90)
                {
                    Assert.IsTrue(false);
                }
            }
            else
            {
                message = "No se logro leer el certificado de JUNOMX";
            }

           // return message;
        }

        //private bool ServerCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors)
        //{
        //    Console.WriteLine("Certificate expires on " + certificate.GetExpirationDateString());

        //    return true;
        //}
    }
}
