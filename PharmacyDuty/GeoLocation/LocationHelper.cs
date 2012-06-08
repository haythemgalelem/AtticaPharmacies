using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PharmacyDuty.BingGeoCodeService;
using System.Threading;

namespace PharmacyDuty.GeoLocation
{
    public class LocationHelper
    {
        private static Dictionary<char, string> _MatchGrToEn = GrToEnHelper.MatchGrToEn();

        public static void GeoLocate(ref PharmacyOnDuty ph)
        {
            string LatinAddress = ConvertToLatin(ph.Address + " " + ph.AthensArea) + " Athens" + " Greece";
            
            GeocodeResponse rsp = GeoResolution(LatinAddress);
            Thread.Sleep(180);
            if (rsp.Results != null && rsp.Results.Count() >= 1 && rsp.Results.First().Locations.Count() >= 1)
            {
                ph.AddressLatitude = rsp.Results.First().Locations.First().Latitude;
                ph.AddressLongitute = rsp.Results.First().Locations.First().Longitude;
            }
        }

        private static GeocodeResponse GeoResolution(string qry)
        {
            try
            {
                string key = System.Configuration.ConfigurationManager.AppSettings["BingMapKey"];

                GeocodeRequest geocodeRequest = new GeocodeRequest();
                geocodeRequest.Credentials = new Credentials();
                geocodeRequest.Credentials.ApplicationId = key;

                geocodeRequest.Query = qry;

                ConfidenceFilter[] filters = new ConfidenceFilter[1];
                filters[0] = new ConfidenceFilter();
                filters[0].MinimumConfidence = Confidence.Medium;

                GeocodeOptions geocodeOptions = new GeocodeOptions();
                geocodeOptions.Filters = filters;
                geocodeRequest.Options = geocodeOptions;

                // Make the geocode request
                GeocodeServiceClient geocodeService = new GeocodeServiceClient("BasicHttpBinding_IGeocodeService");
                GeocodeResponse geocodeResponse = geocodeService.Geocode(geocodeRequest);

                return geocodeResponse;
            }
            catch
            {
                return new GeocodeResponse();
            }
        }

        private static string ConvertToLatin(string TmpStr)
        {
            string ConvertedToLatinAddress = string.Empty;
            foreach (char c in TmpStr)
                ConvertedToLatinAddress += LatinToGreekCharEquivelant(c);
            return ConvertedToLatinAddress;
        }

        private static string LatinToGreekCharEquivelant(char inp_char)
        {

            if (_MatchGrToEn.ContainsKey(inp_char))
                return _MatchGrToEn[inp_char];
            else return inp_char.ToString();
        }
    }
}