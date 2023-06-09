/**
 * 
 * Project SmartWASM
 * Copyright (C) 2023 Alessio Saltarin
 * MIT License
 * 
 **/

using System.Text.Json;
using SmartWasm.Dto;

namespace SmartWasm.Services;

public class WeatherApi
{
    public static async Task<WeatherDto?> GetWeather(double longitude, double latitude)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com/current?lon=" + longitude + "&lat=" + latitude),
            Headers =
            {
                { "X-RapidAPI-Key", "28d255ad04msh8d5160d72fca715p179956jsnd6e6fbe16e1f" },
                { "X-RapidAPI-Host", "weatherbit-v1-mashape.p.rapidapi.com" },
            },
        };
        using var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var jsonBody = await response.Content.ReadAsStringAsync();
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        return JsonSerializer.Deserialize<WeatherDto>(jsonBody, options);
    }
}