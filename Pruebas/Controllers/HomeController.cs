using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Pruebas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        string data;
        public ActionResult GetHtml() {

            string urlAddress = "https://www.bna.com.ar/Cotizador/MonedasHistorico";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //if (response.StatusCode == HttpStatusCode.OK)
            //{
            //    Stream receiveStream = response.GetResponseStream();
            //    StreamReader readStream = null;

            //    if (response.CharacterSet == null)
            //    {
            //        readStream = new StreamReader(receiveStream);
            //    }
            //    else
            //    {
            //        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
            //    }

            //    data = readStream.ReadToEnd();

            //    response.Close();
            //    readStream.Close();
            //}

            using (WebClient client = new WebClient())
            {
                data = client.DownloadString(urlAddress);
            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        
    }
}
