#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Request;

/// <summary>
/// This class represents the request to add a new engine.
/// </summary>
[SwaggerSchema(Description = "The request for adding a new engine")]
public class AddEngineRequest
{
    /// <summary>
    /// This is the code of the new engine being added.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the new engine being added")]
    public string Code { get; set; }

    /// <summary>
    /// This is the description of the new engine being added.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the new engine being added")]
    public string Description { get; set; }
}