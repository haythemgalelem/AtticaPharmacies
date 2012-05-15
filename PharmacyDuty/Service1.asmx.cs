using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using PharmacyDuty.Lib;

namespace PharmacyDuty
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        [WebMethod]
        public List<AthensArea> GetAvailableAthensAreas()
        {
            List<AthensArea> result = new List<AthensArea>();
            try
            {
                result = AthensArea.ReadAthensAreaFromHtml(Helper.ScrapResponse(Config.FSABaseUrl + Config.FSADutiesPage));
            }
            catch (Exception e)
            {
                //I should log this
                // and do something about it
            }
            return result;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Json_GetAvailableAthensAreas()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(AthensArea.ReadAthensAreaFromHtml(Helper.ScrapResponse(Config.FSABaseUrl + Config.FSADutiesPage)));
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Json_GetAvailableDates()
        {
            string result = Newtonsoft.Json.JsonConvert.SerializeObject(AvailableDates.ReadDatesFromHtml(Helper.ScrapResponse(Config.FSABaseUrl + Config.FSADutiesPage)));
            return result;
        }


        [WebMethod]
        public List<AvailableDates> GetAvailableDates()
        {
            List<AvailableDates> Result = new List<AvailableDates>();
            try
            {
                Result = AvailableDates.ReadDatesFromHtml(Helper.ScrapResponse(Config.FSABaseUrl + Config.FSADutiesPage));
            }
            catch (Exception)
            {
                //I should log this
                // and do something about it
            }
            return Result;
        }

        [WebMethod]
        public List<PharmacyOnDuty> GetPharmaciesOnDuty(AthensArea Area, AvailableDates Date)
        {
            //http://www.fsa.gr/duties.asp?dateduty=30/1/2012&areaid=12
            //string Url = @"http://www.fsa.gr/duties.asp?dateduty=" + Date._ShortDateString + "&areaid=" + Area._id;
            //Config.FSABaseUrl+Config.FSAShow+"?dateduty=" + Date._ShortDateString + "&areaid=" + Area._id"
            string Url = @"http://www.fsa.gr/duties.asp?dateduty=15/5/2012&areaid=12";

            return PharmacyOnDuty.GetPharmaciesOnDuty(Helper.ScrapResponse(Url));
        }
    }
}