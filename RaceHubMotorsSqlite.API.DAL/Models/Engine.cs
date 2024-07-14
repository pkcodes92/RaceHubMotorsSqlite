#nullable disable

namespace RaceHubMotorsSqlite.API.DAL.Models;

/// <summary>
/// This class represents the engine database entity.
/// </summary>
public class Engine
{
    /// <summary>
    /// Gets or sets the engine ID - the primary key.
    /// </summary>
    public int EngineId { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string Description { get; set; }
}