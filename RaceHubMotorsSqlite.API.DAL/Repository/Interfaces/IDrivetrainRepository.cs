using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL;

public interface IDrivetrainRepository
{
    Task<List<Drivetrain>> GetAllDrivetrainsAsync();

    Task<Drivetrain> GetDrivetrainByIdAsync(int id);

    Task<Drivetrain> GetDrivetrainByCodeAsync(string code);
}
