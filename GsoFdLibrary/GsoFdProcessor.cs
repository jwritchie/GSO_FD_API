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
        public static async Task<string> LoadGsoFdData()
        {
            // Test url - to be revised.
            string url = $"https://gis.greensboro-nc.gov/arcgis/rest/services/OpenGateCity/OpenData_ES_DS/MapServer/11/query?where=Year%20%3D%20'2022'%20AND%20Month%20%3D%20'01'%20AND%20Day%20%3D%201%20AND%20station%20%3D%20'07'&outFields=IncidentNumber,Month,Day,DayOfWeek,Week,Year,TotalResponseTime,P911CenterReceived,AlarmDate,UnderControlTime,IncidentClearTime,FireDistrict,station,shift,NumberOfAlarms,NatureCode,PropertyUse,PropertyLoss,ContentLoss,PropertyValue,ContentValue,FireServiceFatalities,FireServiceInjuries,CivilianInjuries,CivilianFatalities,TotalStaffOnIncident,TotalApparatus,FlameSpreadDesc,ExtinguishedByDesc,ConditionsOnArrival,ExtinguishMethod,OccupancyStatus,AreaOfFireOrigin,HeatSource,NFIRS_IncidentTypeDescription,MutualAid,Latitude,Longitude,FullAddress,MonthName&outSR=4326&f=json";

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
