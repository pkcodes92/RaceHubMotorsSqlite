#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Request;

/// <summary>
/// This class represents the request when adding a new vehicle color.
/// </summary>
[SwaggerSchema(Description = "The request for adding a new vehicle color")]
public class AddVehicleColorRequest
{
    /// <summary>
    /// This is the code of the new vehicle color.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the new vehicle color")]
    public string Code { get; set; }

    /// <summary>
    /// This is the description of the new vehicle color.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the new vehicle color")]
    public string Description { get; set; }
}