#nullable disable

using Newtonsoft.Json;
using RaceHubMotorsSqlite.API.DTO.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Response;

/// <summary>
/// This class represents the response when a new drivetrain is added.
/// </summary>
[SwaggerSchema(Description = "The response when a new drivetrain is added.")]
public class AddDrivetrainResponse
{
    /// <summary>
    /// Gets or sets the newly added drivetrain.
    /// </summary>
    [JsonProperty("drivetrain")]
    [SwaggerSchema(Description = "The newly added drivetrain.")]
    public Drivetrain Drivetrain { get; set; }
}
