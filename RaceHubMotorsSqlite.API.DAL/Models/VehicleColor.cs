#nullable disable

namespace RaceHubMotorsSqlite.API.DAL.Models;

/// <summary>
/// This class represents the vehicle color database entity.
/// </summary>
public class VehicleColor
{
    /// <summary>
    /// Gets or sets the vehicle color ID - the primary key.
    /// </summary>
    public int VehicleColorId { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string Description { get; set; }
}