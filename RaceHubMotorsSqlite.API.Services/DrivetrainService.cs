using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Models;
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
}
