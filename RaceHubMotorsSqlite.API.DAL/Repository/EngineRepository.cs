using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.DAL.Repository;

/// <summary>
/// Initializes an instance of <see cref="EngineRepository"/>.
/// </summary>
/// <param name="motorsContext">The database context injection.</param>
public class EngineRepository(MotorsContext motorsContext) : IEngineRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    /// <summary>
    /// This method implementation will add a new engine to the database.
    /// </summary>
    /// <param name="engine">The new engine being added.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    public async Task<Engine> AddEngineAsync(Engine engine)
    {
        this.motorsContext.Engines.Add(engine);
        var result = await this.motorsContext.SaveChangesAsync();
        return result > 0 ? engine : null!;
    }

    /// <summary>
    /// This method implementation gets all the engines from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="Engine"/>.</returns>
    public async Task<List<Engine>> GetAllEnginesAsync()
    {
        var results = await this.motorsContext.Engines.ToListAsync();
        return results;
    }

    /// <summary>
    /// This method implementation will get a single engine from the database.
    /// </summary>
    /// <param name="code">The code to search the database.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    public async Task<Engine> GetEngineAsync(string code)
    {
        var result = await this.motorsContext.Engines.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    /// <summary>
    /// This method implementation will get a single engine from the database.
    /// </summary>
    /// <param name="id">The primary key - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    public async Task<Engine> GetEngineAsync(int id)
    {
        var result = await this.motorsContext.Engines.FirstOrDefaultAsync(g => g.EngineId == id);
        return result!;
    }
}
