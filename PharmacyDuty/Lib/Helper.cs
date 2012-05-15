using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;
using System.Net;
using System.Text;
using HtmlAgilityPack;
using System.Configuration;

namespace PharmacyDuty
{
    public static class Helper
    {
        public static HtmlDocument ScrapResponse(string Url)
        {
            string result = string.Empty;
            

            Encoding GreekEncoding = Encoding.GetEncoding("iso-8859-7");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            WebProxy prx = WebProxy.GetDefaultProxy();
            prx.UseDefaultCredentials = true;
            request.Proxy = prx;
            
            request.UseDefaultCredentials = true; 

            HtmlDocument doc = new HtmlDocument();

            request.Method = "GET";
            using (var stream = request.GetResponse().GetResponseStream())

            using (var reader = new StreamReader(stream, GreekEncoding))
            {
                result = reader.ReadToEnd();
            }

            doc.LoadHtml(result);
            return doc;
            }
    }
}