#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Models;

/// <summary>
/// This class defines the Drivetrain UI entity.
/// </summary>
[SwaggerSchema(Description = "This is the definition of a drivetrain")]
public class Drivetrain
{
    /// <summary>
    /// Gets or sets the primary key - the ID.
    /// </summary>
    [JsonProperty("id")]
    [SwaggerSchema(Description = "The primary key of the Drivetrain UI entity - ID")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the drivetrain UI entity")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the drivetrain UI entity")]
    public string Description { get; set; }
}
