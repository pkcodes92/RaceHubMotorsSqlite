#nullable disable

namespace RaceHubMotorsSqlite.API.DAL.Models;

public class VehicleType
{
    public int VehicleTypeId { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }
}