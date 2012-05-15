using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace PharmacyDuty
{
    public class PharmacyOnDuty
    {

        /*
          Εφημερία	  
          Φαρμακείο	
          Διεύθυνση	
          Περιοχή	  
          Τηλέφωνο */

        public string Pharmacist { get; private set; }
        public string Address { get; private set; }
        public string AthensArea { get; private set; }
        public string TelNum { get; private set; }
        public string OpeningHours { get; private set; }

        public static List<PharmacyOnDuty> GetPharmaciesOnDuty(HtmlDocument doc)
        {
            List<PharmacyOnDuty> Result = new List<PharmacyOnDuty>();
            var Urls = doc.DocumentNode.Descendants("a").Where(y => y.Attributes["class"].Value == "greenlink").Select(z => z.Attributes["onclick"].Value).ToList();
            List<string> ResultsUrls = new List<string>();

            foreach (string js in Urls)
            {
                ResultsUrls.Add(PharmacyDuty.Lib.Config.FSABaseUrl + js.Split('\'')[1]);
                
            }

            EnumerateResults(ResultsUrls);
            return Result;

        }

        private static void EnumerateResults(List<string> UrlsToScrap)
        {
            foreach (string Url in UrlsToScrap)
            {
                HtmlDocument doc = Helper.ScrapResponse(Url);
                var r = doc.DocumentNode.Descendants("td").Where(y => y.Attributes["class"].Value == "txt10dgreen");
            }

        }
    }
}