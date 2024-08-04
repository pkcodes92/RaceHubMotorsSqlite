#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Models;

/// <summary>
/// This class represents the Vehicle Color UI entity.
/// </summary>
[SwaggerSchema(Description = "The vehicle color UI entity")]
public class VehicleColor
{
    /// <summary>
    /// Gets or sets the primary key - the ID.
    /// </summary>
    [JsonProperty("id")]
    [SwaggerSchema(Description = "The primary key - the ID")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the vehicle color")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the vehicle color")]
    public string Description { get; set; }
}