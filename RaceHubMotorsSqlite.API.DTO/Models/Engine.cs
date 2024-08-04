#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Models;

/// <summary>
/// This class represents the engine UI entity.
/// </summary>
[SwaggerSchema(Description = "This class represents the Engine UI entity")]
public class Engine
{
    /// <summary>
    /// The primary key of the engine UI entity.
    /// </summary>
    [JsonProperty("id")]
    [SwaggerSchema(Description = "The primary key of the Engine UI entity")]
    public int Id { get; set; }

    /// <summary>
    /// The code of the engine UI entity.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the engine UI entity")]
    public string Code { get; set; }

    /// <summary>
    /// The description of the engine UI entity.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the engine UI entity")]
    public string Description { get; set; }
}