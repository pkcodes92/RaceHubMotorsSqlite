#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Request;

/// <summary>
/// This class represents the necessary request when updating an existing drivetrain.
/// </summary>
[SwaggerSchema(Description = "The request when updating an existing drivetrain")]
public class UpdateDrivetrainRequest
{
    /// <summary>
    /// This is the primary key of the existing drivetrain.
    /// </summary>
    [JsonProperty("id")]
    [SwaggerSchema(Description = "The primary key of the existing drivetrain")]
    public int Id { get; set; }

    /// <summary>
    /// This is the code of the existing drivetrain being updated.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the existing drivetrain")]
    public string Code { get; set; }

    /// <summary>
    /// The description of the existing drivetrain to be updated.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the updated drivetrain")]
    public string Description { get; set; }
}