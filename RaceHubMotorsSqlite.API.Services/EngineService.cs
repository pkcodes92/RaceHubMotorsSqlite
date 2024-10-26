using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Models;
using RaceHubMotorsSqlite.API.DTO.Request;
using RaceHubMotorsSqlite.API.Services.Interfaces;

namespace RaceHubMotorsSqlite.API.Services;

/// <summary>
/// Initializes an instance of <see cref="EngineService"/>.
/// </summary>
/// <remarks>This class implements the methods defined in <see cref="IEngineService"/>.</remarks>
/// <param name="engineRepo">The necessary engine repository injection.</param>
public class EngineService(IEngineRepository engineRepo) : IEngineService
{
    private readonly IEngineRepository engineRepo = engineRepo;

    /// <summary>
    /// This method implementation will add a new engine to the database.
    /// </summary>
    /// <param name="request">The new engine being added.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    public async Task<Engine> AddEngineAsync(AddEngineRequest request)
    {
        var entityToAdd = new DAL.Models.Engine
        {
            Code = request.Code,
            Description = request.Description
        };

        var dbResult = await this.engineRepo.AddEngineAsync(entityToAdd);

        return new Engine
        {
            Id = dbResult.EngineId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }

    /// <summary>
    /// This method implementation will get a single engine.
    /// </summary>
    /// <param name="id">The primary key of the engine entity - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    public async Task<Engine> GetEngineAsync(int id)
    {
        var dbResult = await this.engineRepo.GetEngineAsync(id);

        return new Engine
        {
            Id = dbResult.EngineId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }

    /// <summary>
    /// This method implementation will get a single engine.
    /// </summary>
    /// <param name="code">The code to search for.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    public async Task<Engine> GetEngineAsync(string code)
    {
        var dbResult = await this.engineRepo.GetEngineAsync(code);

        return new Engine
        {
            Id = dbResult.EngineId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }

    /// <summary>
    /// This method implementation will get all the engines.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="Engine"/>.</returns>
    public async Task<List<Engine>> GetEnginesAsync()
    {
        var dbResults = await this.engineRepo.GetAllEnginesAsync();

        var results = new List<Engine>();

        foreach (var item in dbResults)
        {
            var itemToAdd = new Engine
            {
                Id = item.EngineId,
                Code = item.Code,
                Description = item.Description
            };

            results.Add(itemToAdd);
        }

        return results!;
    }

    /// <summary>
    /// This method implementation will update an existing engine.
    /// </summary>
    /// <param name="request">The updated engine information.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Engine"/>.</returns>
    public async Task<Engine> UpdateEngineAsync(UpdateEngineRequest request)
    {
        var entityToUpdate = await this.engineRepo.GetEngineAsync(request.Id);

        entityToUpdate.Code = request.Code;
        entityToUpdate.Description = request.Description;

        var dbResult = await this.engineRepo.UpdateEngineAsync(entityToUpdate);

        return new Engine
        {
            Id = dbResult.EngineId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }
}