#nullable disable

using Newtonsoft.Json;

namespace RaceHubMotorsSqlite.API.DTO.Models;

/// <summary>
/// This class represents the Vehicle Color UI entity.
/// </summary>
public class VehicleColor
{
    /// <summary>
    /// Gets or sets the primary key - the ID.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }
}