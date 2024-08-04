using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

/// <summary>
/// This interface defines methods that interact with the Engine database entity.
/// </summary>
public interface IEngineRepository
{
    /// <summary>
    /// This method definition will get all the engines from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="Engine"/>.</returns>
    Task<List<Engine>> GetAllEnginesAsync();

    /// <summary>
    /// This method definition will get a single engine from the database.
    /// </summary>
    /// <param name="code">The code to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    Task<Engine> GetEngineAsync(string code);

    /// <summary>
    /// This method definition will get a single engine from the database.
    /// </summary>
    /// <param name="id">The primary key - ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    Task<Engine> GetEngineAsync(int id);

    /// <summary>
    /// This method definition will add a new engine to the database.
    /// </summary>
    /// <param name="engine">The new engine information.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    Task<Engine> AddEngineAsync(Engine engine);

    /// <summary>
    /// This method definition will update an existing engine in the database.
    /// </summary>
    /// <param name="engine">The updated engine information.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    Task<Engine> UpdateEngineAsync(Engine engine);
}
