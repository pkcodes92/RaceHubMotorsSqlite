using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL;

public class EngineRepository : IEngineRepository
{
    public Task<List<Engine>> GetAllEnginesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Engine> GetEngineByCodeAsync(string code)
    {
        throw new NotImplementedException();
    }

    public Task<Engine> GetEngineByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
