#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Models;

/// <summary>
/// This class represents the Vehicle UI entity.
/// </summary>
[SwaggerSchema(Description = "The vehicle UI entity")]
public class Vehicle
{
    /// <summary>
    /// This is the primary key of the vehicle UI entity - the ID.
    /// </summary>
    [JsonProperty("id")]
    [SwaggerSchema(Description = "The primary key of the Vehicle UI entity - the ID")]
    public int Id { get; set; }

    /// <summary>
    /// The name of the manufacturer of the vehicle
    /// </summary>
    [JsonProperty("manufacturer")]
    [SwaggerSchema(Description = "The name of the manufacturer for the vehicle")]
    public string Manufacturer { get; set; }

    /// <summary>
    /// The name of the vehicle.
    /// </summary>
    [JsonProperty("name")]
    [SwaggerSchema(Description = "The actual name of the vehicle")]
    public string Name { get; set; }

    /// <summary>
    /// The image of the vehicle - leading to the URL.
    /// </summary>
    [JsonProperty("picture")]
    [SwaggerSchema(Description = "The picture of the vehicle - the image URL")]
    public string Picture { get; set; }
}