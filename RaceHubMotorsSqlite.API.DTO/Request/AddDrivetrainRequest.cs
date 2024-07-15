#nullable disable

using Newtonsoft.Json;

namespace RaceHubMotorsSqlite.API.DTO.Request;

/// <summary>
/// This class represents the necessary request when adding a new drivetrain.
/// </summary>
public class AddDrivetrainRequest
{
    /// <summary>
    /// Gets or sets the code of the new drivetrain.
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description of the new drivetrain.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }
}
