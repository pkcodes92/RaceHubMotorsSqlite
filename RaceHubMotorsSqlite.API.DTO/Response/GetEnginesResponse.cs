using RaceHubMotorsSqlite.API.DTO.Models;

namespace RaceHubMotorsSqlite.API.DTO.Response;

public class GetEnginesResponse
{
    public List<Engine> Engines { get; set; } = null!;
}
