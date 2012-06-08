using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;
using System.Text;

namespace PharmacyDuty
{
    public class PharmacyOnDuty
    {
        public string Pharmacist { get; private set; }
        public string Address { get; private set; }
        public string AthensArea { get; private set; }
        public string TelNum { get; private set; }
        public string OpeningHours { get; private set; }
        public double AddressLongitute { get; set; }
        public double AddressLatitude { get; set; }

        public static List<PharmacyOnDuty> GetPharmaciesOnDuty(HtmlDocument doc)
        {
            try
            {
                List<PharmacyOnDuty> Result = new List<PharmacyOnDuty>();
                var Urls = doc.DocumentNode.Descendants("a").Where(y => y.Attributes["class"].Value == "greenlink").Select(z => z.Attributes["onclick"].Value).ToList();
                List<string> ResultsUrls = new List<string>();

                foreach (string js in Urls)
                {
                    ResultsUrls.Add(PharmacyDuty.Lib.Config.FSABaseUrl + js.Split('\'')[1]);
                }

                return CreateResultsObjectsFromUrl(ResultsUrls);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Εφημερία
        ///  Φαρμακείο
        ///  Διεύθυνση
        ///  Περιοχή
        /// Τηλέφωνο
        /// </summary>
        /// <param name="UrlsToScrap"></param>
        private static List<PharmacyOnDuty> CreateResultsObjectsFromUrl(List<string> UrlsToScrap)
        {
            List<PharmacyOnDuty> Result = new List<PharmacyOnDuty>();

            foreach (string Url in UrlsToScrap)
            {
                HtmlDocument doc = Helper.ScrapResponse(Url, new UTF8Encoding());
                var ResultColumn = doc.DocumentNode.Descendants("td").Select(y => y.Attributes["class"]).Where(z => z != null).Where(w => w.Value == "txt10dgreen").Select(t => t.OwnerNode.InnerText).ToList();

                PharmacyOnDuty ph = new PharmacyOnDuty();
                ph.OpeningHours = ResultColumn.FirstOrDefault().ToString().Trim();
                ph.Pharmacist = ResultColumn[1].ToString().Trim();
                ph.Address = ResultColumn[2].ToString().Trim();
                ph.AthensArea = ResultColumn[3].ToString().Trim();
                ph.TelNum = ResultColumn.LastOrDefault().ToString().Trim();

                PharmacyDuty.GeoLocation.LocationHelper.GeoLocate(ref ph);
                Result.Add(ph);
            }
            return Result;
        }

    }
}