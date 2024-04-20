using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

public interface IEngineRepository
{
    Task<List<Engine>> GetAllEnginesAsync();

    Task<Engine> GetEngineAsync(string code);

    Task<Engine> GetEngineAsync(int id);

    Task<Engine> AddEngineAsync(Engine engine);
}
