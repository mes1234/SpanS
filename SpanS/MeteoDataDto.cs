using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanS
{
    public class MeteoDataDto
    {
        public double Latitude { get; init; }
        public double Longitude { get; init; }
        public double Generationtime_ms { get; init; }
        public int Utc_offset_seconds { get; init; }
        public string? Timezone { get; init; }
        public string? Timezone_abbreviation { get; init; }
        public double Elevation { get; init; }
        public UnitDto? Hourly_units { get; init; }
        public DataDto? Hourly { get; init; }
    }

    public class UnitDto
    {
        public string? Time { get; set; }
        public string? Temperature_2m { get; set; }
        public string? Relativehumidity_2m { get; set; }
        public string? Windspeed_10m { get; set; }
    }

    public class DataDto
    {
        public IEnumerable<DateTime> Time { get; init; } = Enumerable.Empty<DateTime>();
        public IEnumerable<double> Temperature_2m { get; init; } = Enumerable.Empty<double>();
        public IEnumerable<double> Relativehumidity_2m { get; init; } = Enumerable.Empty<double>();
        public IEnumerable<double> Windspeed_10m { get; init; } = Enumerable.Empty<double>();
    }
}
