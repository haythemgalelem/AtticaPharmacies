using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestClient.ServiceReference1;


namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1SoapClient client = new ServiceReference1.Service1SoapClient();
            AthensArea[] Areas = client.GetAvailableAthensAreas();
            AvailableDates[] Dates = client.GetAvailableDates();

            var result = client.GetPharmaciesOnDuty(Areas[2], Dates[2]);
            Console.ReadLine();
        }
    }
}
