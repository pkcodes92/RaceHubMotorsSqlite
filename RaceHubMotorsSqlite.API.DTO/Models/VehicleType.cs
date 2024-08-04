#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Models;

/// <summary>
/// This class represents the Vehicle Type entity.
/// </summary>
[SwaggerSchema(Description = "This is the vehicle type UI entity")]
public class VehicleType
{
    /// <summary>
    /// Gets or sets the primary key - the ID.
    /// </summary>
    [JsonProperty("id")]
    [SwaggerSchema(Description = "The primary key - the ID")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the necessary code.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the vehicle type")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the vehicle type")]
    public string Description { get; set; }
}
