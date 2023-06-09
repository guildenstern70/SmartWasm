using System.Text.Json.Serialization;

namespace SmartWasm.Dto;
/**
 * 
 * Project SmartWASM
 * Copyright (C) 2023 Alessio Saltarin
 * MIT License
 * 
 **/

public class WeatherData
{
    public double AppTemp { get; set; }
    public int Aqi { get; set; }
    [JsonPropertyName("city_name")]
    public string CityName { get; set; } = null!;

    public int Clouds { get; set; }
    public string CountryCode { get; set; } = null!;
    public string Datetime { get; set; }  = null!;
    public double Dewpt { get; set; }
    public double Dhi { get; set; }
    public double Dni { get; set; }
    public double ElevAngle { get; set; }
    public double Ghi { get; set; }
    public double Gust { get; set; }
    public double HAngle { get; set; }
    public double Lat { get; set; }
    public double Lon { get; set; }
    public string ObTime { get; set; } = null!;
    public string Pod { get; set; } = null!;
    public int Precip { get; set; }
    public double Pres { get; set; }
    public int Rh { get; set; }
    public double Slp { get; set; }
    public int Snow { get; set; }
    public double SolarRad { get; set; }
    public List<string> Sources { get; set; } = null!;
    public string StateCode { get; set; } = null!;
    public string Station { get; set; } = null!;
    public string Sunrise { get; set; } = null!;
    public string Sunset { get; set; } = null!;
    public double Temp { get; set; }
    public string Timezone { get; set; } = null!;
    public int Ts { get; set; }
    public double Uv { get; set; }
    public int Vis { get; set; }
    public Weather Weather { get; set; } = null!;
    public string WindCdir { get; set; } = null!;
    public string WindCdirFull { get; set; } = null!;
    public int WindDir { get; set; }
    public double WindSpd { get; set; }
}
