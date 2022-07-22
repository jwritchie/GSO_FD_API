using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static GsoFdLibrary.GsoFdModels;

namespace GsoFdLibrary
{
    public class GsoFdProcessor
    {
        /// <summary>
        /// Retrieve requested JSON data from API.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static async Task<string> LoadGsoFdData(Dictionary<string,string> queryData, int totalRequested)
        {
            //Dictionary<string, string> queryData = new Dictionary<string, string>()
            //{
            //    ["Year"] = "'2022'",
            //    ["Month"] = "'01'",
            //    ["Day"] = "01",
            //    ["station"] = "'07'"
            //};

            //var baseUri = QueryHelpers.AddQueryString("https://gis.greensboro-nc.gov/arcgis/rest/services/OpenGateCity/OpenData_ES_DS/MapServer/11/query?where1=1",queryData);
            //string append = $"&outFields=IncidentNumber,Month,Day,DayOfWeek,Week,Year,TotalResponseTime,P911CenterReceived,AlarmDate,UnderControlTime,IncidentClearTime,FireDistrict,station,shift,NumberOfAlarms,NatureCode,PropertyUse,PropertyLoss, ContentLoss,PropertyValue,ContentValue,FireServiceFatalities,FireServiceInjuries,CivilianInjuries,CivilianFatalities,TotalStaffOnIncident,TotalApparatus,FlameSpreadDesc,ExtinguishedByDesc,ConditionsOnArrival, ExtinguishMethod,OccupancyStatus,AreaOfFireOrigin,HeatSource,NFIRS_IncidentTypeDescription,MutualAid,Latitude,Longitude,FullAddress,MonthName&outSR=4326&f=json";

            //string url = baseUri + append;

            StringBuilder urlBuilder = new StringBuilder();
            urlBuilder.Append($"https://gis.greensboro-nc.gov/arcgis/rest/services/OpenGateCity/OpenData_ES_DS/MapServer/11/query?where=1%3D1");

            foreach (KeyValuePair<string,string> kvp in queryData)
            {
                urlBuilder.Append($"%20AND%20{kvp.Key}%20%3D%20{kvp.Value}");
            }

            //urlBuilder.Append($"%20AND%20Year%20%3D%20%272022%27%20AND%20Month%20%3D%20%2701%27%20AND%20Day%20%3D%201%20AND%20station%20%3D%20%2707%27");

            urlBuilder.Append($"&outFields=*&resultOffset=0&resultRecordCount={totalRequested}&outSR=4326&f=json");

            //urlBuilder.Append($"&outFields=IncidentNumber,Month,Day,DayOfWeek,Week,Year,TotalResponseTime,P911CenterReceived,AlarmDate,UnderControlTime,IncidentClearTime,FireDistrict,station,shift,NumberOfAlarms,NatureCode,PropertyUse,PropertyLoss, ContentLoss,PropertyValue,ContentValue,FireServiceFatalities,FireServiceInjuries,CivilianInjuries,CivilianFatalities,TotalStaffOnIncident,TotalApparatus,FlameSpreadDesc,ExtinguishedByDesc,ConditionsOnArrival, ExtinguishMethod,OccupancyStatus,AreaOfFireOrigin,HeatSource,NFIRS_IncidentTypeDescription,MutualAid,Latitude,Longitude,FullAddress,MonthName&outSR=4326&f=json");

            string url = urlBuilder.ToString();

            // Test url - to be revised.
            //string url = $"https://gis.greensboro-nc.gov/arcgis/rest/services/OpenGateCity/OpenData_ES_DS/MapServer/11/query?where=Year%20%3D%20'2022'%20AND%20Month%20%3D%20'01'%20AND%20Day%20%3D%201%20AND%20station%20%3D%20'07'&outFields=IncidentNumber,Month,Day,DayOfWeek,Week,Year,TotalResponseTime,P911CenterReceived,AlarmDate,UnderControlTime,IncidentClearTime,FireDistrict,station,shift,NumberOfAlarms,NatureCode,PropertyUse,PropertyLoss,ContentLoss,PropertyValue,ContentValue,FireServiceFatalities,FireServiceInjuries,CivilianInjuries,CivilianFatalities,TotalStaffOnIncident,TotalApparatus,FlameSpreadDesc,ExtinguishedByDesc,ConditionsOnArrival,ExtinguishMethod,OccupancyStatus,AreaOfFireOrigin,HeatSource,NFIRS_IncidentTypeDescription,MutualAid,Latitude,Longitude,FullAddress,MonthName&outSR=4326&f=json";

            using (HttpResponseMessage responseMessage = await ApiHelper.httpClient.GetAsync(url))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    string GsoFdResult = await responseMessage.Content.ReadAsStringAsync();
                    return GsoFdResult;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }
    }
}
