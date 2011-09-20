using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;

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
            return AthensArea.ReadAthensAreaFromHtml(Helper.DownloadHtmlAndCreateFile());
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Json_GetAvailableAthensAreas()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(AthensArea.ReadAthensAreaFromHtml(Helper.DownloadHtmlAndCreateFile()));
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Json_GetAvailableDates()
        {
            string result = Newtonsoft.Json.JsonConvert.SerializeObject(AvailableDates.ReadDatesFromHtml(Helper.DownloadHtmlAndCreateFile()));
            return result;
        }


        [WebMethod]
        public List<AvailableDates> GetAvailableDates()
        {
            return AvailableDates.ReadDatesFromHtml(Helper.DownloadHtmlAndCreateFile());
        }

    }
}