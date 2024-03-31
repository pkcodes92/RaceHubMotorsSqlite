#nullable disable

namespace RaceHubMotorsSqlite.API.DAL.Models;

public class Manufacturer
{
    public int ManufacturerId { get; set; }

    public string Name { get; set; }

    public string Country { get; set; }

    public string Logo { get; set; }

    public string NationalFlag { get; set; }

    public string Region { get; set; }
}