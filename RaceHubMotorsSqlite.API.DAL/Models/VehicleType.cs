#nullable disable

namespace RaceHubMotorsSqlite.API.DAL.Models;

/// <summary>
/// This class represents the vehicle type database entity.
/// </summary>
public class VehicleType
{
    /// <summary>
    /// Gets or sets the vehicle type ID - the primary key.
    /// </summary>
    public int VehicleTypeId { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string Description { get; set; }
}