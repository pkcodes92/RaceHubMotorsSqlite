#nullable disable

namespace RaceHubMotorsSqlite.API.DAL.Models;

/// <summary>
/// This class represents the manufacturer entity.
/// </summary>
public class Manufacturer
{
    /// <summary>
    /// Gets or sets the manufacturer ID - the primary key.
    /// </summary>
    public int ManufacturerId { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the logo.
    /// </summary>
    public string Logo { get; set; }

    /// <summary>
    /// Gets or sets the national flag.
    /// </summary>
    public string NationalFlag { get; set; }

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    public string Region { get; set; }
}