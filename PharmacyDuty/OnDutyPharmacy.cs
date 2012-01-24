using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace PharmacyDuty
{
    public class OnDutyPharmacy
    {
        public AthensArea LocationDesc { get; set; }
        public DateTime DutyDate { get; set; }
        public string DutyDesc { get; set; }
        public string PharmacyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public OnDutyPharmacy()
        {
        }

        public static List<OnDutyPharmacy> GetPharmaciesOnDuty(HtmlDocument doc)
        {
            List<OnDutyPharmacy> result = new List<OnDutyPharmacy>();

            
            HtmlNode root = doc.DocumentNode;

            // from result table for each table row get e.g. javascript:theURL='pharmacyshow.asp?pharmacyid=5129&programmeid=9'
            // scrap that to laod additional info to object
            var ListOfRawUrl = doc.DocumentNode.Descendants("a").Where(y => y.Attributes["class"].Value == "greenlink").Select(z => z.Attributes["onClick"].Value).ToList();
            
            foreach (var url in ListOfRawUrl)
            {

                string[] LinkUrl = url.Split('\'');
                HtmlNode ChildDoc = Helper.DownloadHtml(LinkUrl[1]).DocumentNode;

            }

            return result;
        }
    }
}