using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL;

public interface IEngineRepository
{
    Task<List<Engine>> GetAllEnginesAsync();

    Task<Engine> GetEngineByCodeAsync(string code);

    Task<Engine> GetEngineByIdAsync(int id);
}
