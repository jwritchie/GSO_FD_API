using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsoFdLibrary
{
    /// <summary>
    /// Models built from API's JSON.
    /// </summary>
    public class GsoFdModels
    {
        public class GsoFdRootobject
        {
            public string displayFieldName { get; set; } = string.Empty;
            public Fieldaliases fieldAliases { get; set; }
            public IList<Field> fields { get; set; }
            public IList<Feature> features { get; set; }
        }

        public class Fieldaliases
        {
            public string IncidentNumber { get; set; } = string.Empty;
            public string Month { get; set; } = string.Empty;
            public string Day { get; set; } = string.Empty;
            public string DayOfWeek { get; set; } = string.Empty;
            public string Week { get; set; } = string.Empty;
            public string Year { get; set; } = string.Empty;
            public string TotalResponseTime { get; set; } = string.Empty;
            public string P911CenterReceived { get; set; } = string.Empty;
            public string AlarmDate { get; set; } = string.Empty;
            public string UnderControlTime { get; set; } = string.Empty;
            public string IncidentClearTime { get; set; } = string.Empty;
            public string FireDistrict { get; set; } = string.Empty;
            public string station { get; set; } = string.Empty;
            public string shift { get; set; } = string.Empty;
            public string NumberOfAlarms { get; set; } = string.Empty;
            public string NatureCode { get; set; } = string.Empty;
            public string PropertyUse { get; set; } = string.Empty;
            public string PropertyLoss { get; set; } = string.Empty;
            public string ContentLoss { get; set; } = string.Empty;
            public string PropertyValue { get; set; } = string.Empty;
            public string ContentValue { get; set; } = string.Empty;
            public string FireServiceFatalities { get; set; } = string.Empty;
            public string FireServiceInjuries { get; set; } = string.Empty;
            public string CivilianInjuries { get; set; } = string.Empty;
            public string CivilianFatalities { get; set; } = string.Empty;
            public string TotalStaffOnIncident { get; set; } = string.Empty;
            public string TotalApparatus { get; set; } = string.Empty;
            public string FlameSpreadDesc { get; set; } = string.Empty;
            public string ExtinguishedByDesc { get; set; } = string.Empty;
            public string ConditionsOnArrival { get; set; } = string.Empty;
            public string ExtinguishMethod { get; set; } = string.Empty;
            public string OccupancyStatus { get; set; } = string.Empty;
            public string AreaOfFireOrigin { get; set; } = string.Empty;
            public string HeatSource { get; set; } = string.Empty;
            public string NFIRS_IncidentTypeDescription { get; set; } = string.Empty;
            public string MutualAid { get; set; } = string.Empty;
            public string Latitude { get; set; } = string.Empty;
            public string Longitude { get; set; } = string.Empty;
            public string FullAddress { get; set; } = string.Empty;
            public string MonthName { get; set; } = string.Empty;
        }

        public class Field
        {
            public string name { get; set; } = string.Empty;
            public string type { get; set; } = string.Empty;
            public string alias { get; set; } = string.Empty;
            public int length { get; set; }
        }

        public class Feature
        {
            public Attributes attributes { get; set; }
        }

        public class AttributeList
        {
            public IList<Attributes> Attributes { get; set; }
        }

        public class Attributes
        {
            public string IncidentNumber { get; set; } = string.Empty;
            public string Month { get; set; } = string.Empty;
            public int Day { get; set; }
            public string DayOfWeek { get; set; } = string.Empty;
            public int Week { get; set; }
            public string Year { get; set; } = string.Empty;
            public string TotalResponseTime { get; set; } = string.Empty;
            public string P911CenterReceived { get; set; } = string.Empty;
            public string AlarmDate { get; set; } = string.Empty;
            public string UnderControlTime { get; set; } = string.Empty;
            public string IncidentClearTime { get; set; } = string.Empty;
            public string FireDistrict { get; set; } = string.Empty;
            public string station { get; set; } = string.Empty;
            public string shift { get; set; } = string.Empty;
            public int NumberOfAlarms { get; set; }
            public string NatureCode { get; set; } = string.Empty;
            public string PropertyUse { get; set; } = string.Empty;
            public double PropertyLoss { get; set; }
            public double ContentLoss { get; set; }
            public double PropertyValue { get; set; }
            public double ContentValue { get; set; }
            public int FireServiceFatalities { get; set; }
            public int FireServiceInjuries { get; set; }
            public int CivilianInjuries { get; set; }
            public int CivilianFatalities { get; set; }
            public int TotalStaffOnIncident { get; set; }
            public int TotalApparatus { get; set; }
            public string FlameSpreadDesc { get; set; } = string.Empty;
            public string ExtinguishedByDesc { get; set; } = string.Empty;
            public string ConditionsOnArrival { get; set; } = string.Empty;
            public string ExtinguishMethod { get; set; } = string.Empty;
            public string OccupancyStatus { get; set; } = string.Empty;
            public string AreaOfFireOrigin { get; set; } = string.Empty;
            public string HeatSource { get; set; } = string.Empty;
            public string NFIRS_IncidentTypeDescription { get; set; } = string.Empty;
            public string MutualAid { get; set; } = string.Empty;
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public string FullAddress { get; set; } = string.Empty;
            public string MonthName { get; set; } = string.Empty;
        }

    }
}
