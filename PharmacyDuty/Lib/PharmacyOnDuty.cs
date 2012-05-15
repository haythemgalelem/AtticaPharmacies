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

        public string Pharmacist { get; set; }
        public string Address { get; set; }
        public string AthensArea { get; set; }
        public string TelNum { get; set; }
        public string OpeningHours { get; set; }

        public static List<PharmacyOnDuty> GetPharmaciesOnDuty(HtmlDocument doc)
        {
            List<PharmacyOnDuty> Result = new List<PharmacyOnDuty>();

            HtmlNode root = doc.DocumentNode;
            var Urls = doc.DocumentNode.Descendants("a").Where(y => y.Attributes["class"].Value == "greenlink").Select(z => z.Attributes["onclick"].Value).ToList();
            List<string> UrlsToAppend = new List<string>();
            
            foreach (string js in Urls)
                UrlsToAppend.Add(js.Split('\'')[1]);


            return Result;

        }
    }
}