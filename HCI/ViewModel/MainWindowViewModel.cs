using Avapi;
using Avapi.AvapiTIME_SERIES_DAILY;
using System;
using System;
using System.IO;
using Avapi.AvapiTIME_SERIES_DAILY;
using Avapi.AvapiDIGITAL_CURRENCY_DAILY;

namespace HCI.ViewModel
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            testLib();
        }

        private void testLib()
        {
            // Creating the connection object
            IAvapiConnection connection = AvapiConnection.Instance;

            // Set up the connection and pass the API_KEY provided by alphavantage.co
            connection.Connect(API_KEYS.AVAPI_API_KEY);

            Int_DIGITAL_CURRENCY_DAILY digital_cur_daily = connection.GetQueryObject_DIGITAL_CURRENCY_DAILY();

            IAvapiResponse_DIGITAL_CURRENCY_DAILY apiResponse = digital_cur_daily.QueryPrimitive("BTC", "CNY");


            // Printout the results
            Console.WriteLine("******** RAW DATA TIME_SERIES_DAILY ********");
            Console.WriteLine(apiResponse.RawData);

            /*Console.WriteLine("******** STRUCTURED DATA TIME_SERIES_DAILY ********");
            var data = apiResponse.Data;
            if (data.Error)
            {
                Console.WriteLine(data.ErrorMessage);
            }
            else
            {
                Console.WriteLine("Information: " + data.MetaData.Information);
                Console.WriteLine("Symbol: " + data.MetaData.DigitalCurrencyCode);
                Console.WriteLine("LastRefreshed: " + data.MetaData.LastRefreshed);
                Console.WriteLine("OutputSize: " + data.MetaData.DigitalCurrencyName);
                Console.WriteLine("TimeZone: " + data.MetaData.TimeZone);
                Console.WriteLine("========================");
                Console.WriteLine("========================");
                foreach (var timeseries in data.TimeSeries)
                {

                    Console.WriteLine("DateTime: " + timeseries.DateTime);
                    Console.WriteLine("========================");
                }
            }*/
        }
    }
}
