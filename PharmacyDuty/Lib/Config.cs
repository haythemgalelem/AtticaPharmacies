using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmacyDuty.Lib
{
    public static class Config
    {
        private static string _FSABaseUrl;
        private static string _FSADutiesPage;
        private static string _FSAShow;

        public static string FSAShow
        {
            get
            {
                if (String.IsNullOrEmpty(_FSAShow))
                {
                    try
                    {
                        _FSAShow = System.Configuration.ConfigurationManager.AppSettings["FSAShow"];
                        if (_FSAShow == null) throw new Exception("Unable to retrieve [FSAShow] key!");
                    }
                    catch
                    {
                        throw;
                    }
                }
                return _FSAShow;

            }
        }

        public static string FSADutiesPage
        {
            get
            {
                if (String.IsNullOrEmpty(_FSADutiesPage))
                {
                    try
                    {
                        _FSADutiesPage = System.Configuration.ConfigurationManager.AppSettings["FSADutiesPage"];
                        if (_FSADutiesPage == null) throw new Exception("Unable to retrieve [FSADutiesPage] key!");
                    }
                    catch
                    {
                        throw;
                    }
                }
                return _FSADutiesPage;
            }
        }

        public static string FSABaseUrl
        {
            get
            {
                if (String.IsNullOrEmpty(_FSABaseUrl))
                {
                    try
                    {
                        _FSABaseUrl = System.Configuration.ConfigurationManager.AppSettings["BaseFSAUrl"];
                        if (_FSABaseUrl == null) throw new Exception("Unable to retrieve [BaseFSAUrl] key!");
                    }
                    catch
                    {
                        throw;
                    }
                }
                return _FSABaseUrl;
            }
        }
    }
}