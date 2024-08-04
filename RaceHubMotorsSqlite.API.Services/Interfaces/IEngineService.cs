using RaceHubMotorsSqlite.API.DTO.Models;
using RaceHubMotorsSqlite.API.DTO.Request;

namespace RaceHubMotorsSqlite.API.Services.Interfaces;

/// <summary>
/// This interface defines methods that interact with the Engine UI entity.
/// </summary>
public interface IEngineService
{
    /// <summary>
    /// This method defintion gets all of the engines from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of <see cref="Engine"/>.</returns>
    Task<List<Engine>> GetEnginesAsync();

    /// <summary>
    /// This method definition will get a single engine.
    /// </summary>
    /// <param name="id">The primary key of the Engine entity - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    Task<Engine> GetEngineAsync(int id);

    /// <summary>
    /// This method definition will get a single engine.
    /// </summary>
    /// <param name="code">The code to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    Task<Engine> GetEngineAsync(string code);

    /// <summary>
    /// This method definition will add a new engine to the database.
    /// </summary>
    /// <param name="request">The new engine information to be added.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    Task<Engine> AddEngineAsync(AddEngineRequest request);

    /// <summary>
    /// This method definition will update an existing engine in the database.
    /// </summary>
    /// <param name="request">The updated engine information.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    Task<Engine> UpdateEngineAsync(UpdateEngineRequest request);
}