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
        
        public static HtmlDocument DownloadHtml(string Url)
        {
            string result = string.Empty;

            Encoding GreekEncoding;
            HttpWebRequest request;
            CreateWebRequest(Url, out GreekEncoding, out request);
            HtmlDocument doc = new HtmlDocument();

            return CreateHtmlDoc(ref result, GreekEncoding, request, doc);
        }

        private static HtmlDocument CreateHtmlDoc(ref string result, Encoding GreekEncoding, HttpWebRequest request, HtmlDocument doc)
        {
            using (var stream = request.GetResponse().GetResponseStream())

            using (var reader = new StreamReader(stream, GreekEncoding))
            {
                result = reader.ReadToEnd();
            }

            doc.LoadHtml(result);
            return doc;
        }
        private static void CreateWebRequest(string Url, out Encoding GreekEncoding, out HttpWebRequest request)
        {
            GreekEncoding = Encoding.GetEncoding("iso-8859-7");
            request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
        }

        public static HtmlDocument DownloadHtmlWithResults(string Url, string Date, int Areaid)
        {
            Encoding GreekEncoding;
            HttpWebRequest request;
            HtmlDocument doc = new HtmlDocument();
            
            string result = string.Empty;
            string QryString = Url + @"?dateduty=" + Date + "&areaid=" + Areaid.ToString();

            CreateWebRequest(QryString, out GreekEncoding, out request);

            return CreateHtmlDoc(ref result, GreekEncoding, request, doc);
        }
    }
}