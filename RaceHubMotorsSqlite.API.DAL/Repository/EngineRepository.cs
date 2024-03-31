using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL;

public class EngineRepository(MotorsContext motorsContext) : IEngineRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    public async Task<List<Engine>> GetAllEnginesAsync()
    {
        var results = await this.motorsContext.Engines.ToListAsync();
        return results;
    }

    public async Task<Engine> GetEngineByCodeAsync(string code)
    {
        var result = await this.motorsContext.Engines.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    public async Task<Engine> GetEngineByIdAsync(int id)
    {
        var result = await this.motorsContext.Engines.FirstOrDefaultAsync(g => g.EngineId == id);
        return result!;
    }
}
