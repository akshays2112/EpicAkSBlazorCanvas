﻿using System.Text.Json.Serialization;

namespace EpicAkSBlazorCanvas.Structs;

///<summary>Custom</summary>
public struct CanvasWidthHeight
{
    ///<summary>Custom</summary>
    [JsonPropertyName("canvasWidth")]
    public int Width { get; set; }

    ///<summary>Custom</summary>
    [JsonPropertyName("canvasHeight")]
    public int Height { get; set; }
}
