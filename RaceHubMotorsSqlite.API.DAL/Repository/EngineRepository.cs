using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.DAL;

public class EngineRepository(MotorsContext motorsContext) : IEngineRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    public async Task<Engine> AddEngineAsync(Engine engine)
    {
        this.motorsContext.Engines.Add(engine);
        var result = await this.motorsContext.SaveChangesAsync();
        return result > 0 ? engine : null!;
    }

    public async Task<List<Engine>> GetAllEnginesAsync()
    {
        var results = await this.motorsContext.Engines.ToListAsync();
        return results;
    }

    public async Task<Engine> GetEngineAsync(string code)
    {
        var result = await this.motorsContext.Engines.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    public async Task<Engine> GetEngineAsync(int id)
    {
        var result = await this.motorsContext.Engines.FirstOrDefaultAsync(g => g.EngineId == id);
        return result!;
    }
}
