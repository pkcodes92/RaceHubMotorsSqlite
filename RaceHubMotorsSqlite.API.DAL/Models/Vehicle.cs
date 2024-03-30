#nullable disable

namespace RaceHubMotorsSqlite.DAL.Models;

public class Vehicle
{
    public int VehicleId { get; set; }

    public int ManufacturerId { get; set; }

    public string Name { get; set; }
}