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
        public static HtmlDocument DownloadHtmlAndCreateFile()
        {
            string result = string.Empty;
            string Url = @"http://www.fsa.gr/duties.asp";

            Encoding en = Encoding.GetEncoding("iso-8859-7");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            
            request.Method = "GET";

            using (var stream = request.GetResponse().GetResponseStream())

            using (var reader = new StreamReader(stream, en))
            {
                result = reader.ReadToEnd();
            }
            string filepath = ConfigurationManager.AppSettings.Get("HtmlSourceFilePath");
            //iso8859-7
            using (System.IO.TextWriter writeFile = new StreamWriter(filepath,true, en))
            {
                writeFile.Write(result);
            }

            HtmlDocument doc = new HtmlDocument();
            doc.Load(filepath,en);

            return doc;
        }
    }
}