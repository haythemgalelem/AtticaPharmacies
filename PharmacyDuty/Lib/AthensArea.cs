using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;
using System.Diagnostics;

namespace PharmacyDuty
{
    public class AthensArea
    {
        public int _id { get; private set; }
        public string _description { get; set; }

        public static List<AthensArea> ReadAthensAreaFromHtml(HtmlDocument doc)
        {
            try
            {
                List<AthensArea> Result = new List<AthensArea>();
                var rawData = doc.DocumentNode.Descendants("select").Where(y => y.Attributes["name"].Value == "areaid").Select(x => x.Descendants("option")).FirstOrDefault().ToList();

                foreach (var item in rawData)
                {
                    Result.Add(new AthensArea { _description = item.NextSibling.InnerText.Trim(), _id = Convert.ToInt32(item.Attributes["value"].Value) });
                }
                return Result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}