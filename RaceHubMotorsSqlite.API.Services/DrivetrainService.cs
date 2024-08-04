using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Models;
using RaceHubMotorsSqlite.API.DTO.Request;
using RaceHubMotorsSqlite.API.Services.Interfaces;

namespace RaceHubMotorsSqlite.API.Services;

/// <summary>
/// Initializes an instance of <see cref="DrivetrainService"/>.
/// </summary>
/// <remarks>This class implements the methods defined in <see cref="IDrivetrainService"/>.</remarks>
/// <param name="drivetrainRepo"></param>
public class DrivetrainService(IDrivetrainRepository drivetrainRepo)
    : IDrivetrainService
{
    private readonly IDrivetrainRepository drivetrainRepo = drivetrainRepo;

    /// <summary>
    /// This method implementation will add a new drivetrain to the database.
    /// </summary>
    /// <param name="request">The new drivetrain information.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    public async Task<Drivetrain> AddDrivetrainAsync(AddDrivetrainRequest request)
    {
        var entityToAdd = new DAL.Models.Drivetrain
        {
            Code = request.Code,
            Description = request.Description
        };

        var dbResult = await this.drivetrainRepo.AddDrivetrainAsync(entityToAdd);

        return new Drivetrain
        {
            Id = dbResult.DrivetrainId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }

    /// <summary>
    /// This method implementation will get the necessary drivetrains from the database.
    /// </summary>
    /// <returns>A unit of execuition that contains a list of <see cref="Drivetrain"/>.</returns>
    public async Task<List<Drivetrain>> GetAllDrivetrainsAsync()
    {
        var dbResults = await this.drivetrainRepo.GetAllDrivetrainsAsync();
        var results = new List<Drivetrain>();

        foreach (var item in dbResults)
        {
            var resultToAdd = new Drivetrain
            {
                Id = item.DrivetrainId,
                Code = item.Code,
                Description = item.Description
            };

            results.Add(resultToAdd);
        }

        return results!;
    }

    /// <summary>
    /// This method implementation will get a single drivetrain from the database.
    /// </summary>
    /// <param name="id">The primary key of the <see cref="Drivetrain"/> entity - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    public async Task<Drivetrain> GetDrivetrainAsync(int id)
    {
        var dbResult = await this.drivetrainRepo.GetDrivetrainAsync(id);

        return new Drivetrain
        {
            Id = dbResult.DrivetrainId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }

    /// <summary>
    /// This method implementation will get a single drivetrain from the database.
    /// </summary>
    /// <param name="code">The drivetrain code that is required to be searched.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    public async Task<Drivetrain> GetDrivetrainAsync(string code)
    {
        var dbResult = await this.drivetrainRepo.GetDrivetrainAsync(code);
        return new Drivetrain
        {
            Id = dbResult.DrivetrainId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }

    public async Task<Drivetrain> UpdateDrivetrainAsync(UpdateDrivetrainRequest request)
    {
        var drivetrainToUpdate = await this.drivetrainRepo.GetDrivetrainAsync(request.Id);

        drivetrainToUpdate.Code = request.Code;
        drivetrainToUpdate.Description = request.Description;
        drivetrainToUpdate.DrivetrainId = request.Id;

        var dbResult = await this.drivetrainRepo.UpdateDrivetrainAsync(drivetrainToUpdate);

        return new Drivetrain
        {
            Id = dbResult.DrivetrainId,
            Code = dbResult.Code,
            Description = dbResult.Description
        };
    }
}
