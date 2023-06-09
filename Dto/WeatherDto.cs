/**
 * 
 * Project SmartWASM
 * Copyright (C) 2023 Alessio Saltarin
 * MIT License
 * 
 **/

namespace SmartWasm.Dto;

public class WeatherDto
{
    public int Count { get; set; }
    public List<WeatherData> Data { get; set; } = null!;
}

