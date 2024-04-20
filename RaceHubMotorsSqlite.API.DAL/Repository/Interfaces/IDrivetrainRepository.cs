using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL;

public interface IDrivetrainRepository
{
    Task<List<Drivetrain>> GetAllDrivetrainsAsync();

    Task<Drivetrain> GetDrivetrainAsync(int id);

    Task<Drivetrain> GetDrivetrainAsync(string code);

    Task<Drivetrain> AddDrivetrainAsync(Drivetrain drivetrain);
}
