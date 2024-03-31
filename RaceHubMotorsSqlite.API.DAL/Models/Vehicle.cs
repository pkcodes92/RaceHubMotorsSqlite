#nullable disable

namespace RaceHubMotorsSqlite.API.DAL.Models;

public class Vehicle
{
    public int VehicleId { get; set; }

    public int ManufacturerId { get; set; }

    public string Name { get; set; }

    public string Picture { get; set; }
}