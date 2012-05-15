using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace PharmacyDuty
{
    public class AvailableDates
    {
        public string _ShortDateString { get; set; }

        public static List<AvailableDates> ReadDatesFromHtml(HtmlDocument doc)
        {
            HtmlNode root = doc.DocumentNode;
            var rawDates = doc.DocumentNode.Descendants("select").Where(y => y.Attributes["name"].Value == "dateduty").Select(x => x.Descendants("option").Select(z => z.Attributes["value"].Value)).FirstOrDefault().ToList();

            List<AvailableDates> DateKeys = new List<AvailableDates>();
            foreach (var item in rawDates)
            {
                DateKeys.Add(new AvailableDates { _ShortDateString = item.Trim().ToString() });
            }
            return DateKeys;
        }
    }
}