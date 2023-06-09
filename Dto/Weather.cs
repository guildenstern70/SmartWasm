/**
 * 
 * Project SmartWASM
 * Copyright (C) 2023 Alessio Saltarin
 * MIT License
 * 
 **/

namespace SmartWasm.Dto;

public class Weather
{
    public string Description { get; set; } = string.Empty;
    public int Code { get; set; } = 0;
    public string Icon { get; set; } = string.Empty;
}
