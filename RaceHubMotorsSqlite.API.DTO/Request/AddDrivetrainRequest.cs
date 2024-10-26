#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Request;

/// <summary>
/// This class represents the necessary request when adding a new drivetrain.
/// </summary>
[SwaggerSchema(Description = "The request when adding a new drivetrain")]
public class AddDrivetrainRequest
{
    /// <summary>
    /// Gets or sets the code of the new drivetrain.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the new drivetrain")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description of the new drivetrain.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the new drivetrain")]
    public string Description { get; set; }
}
