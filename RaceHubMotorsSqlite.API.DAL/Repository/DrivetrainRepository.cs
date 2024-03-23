
namespace RaceHubMotorsSqlite.API.DAL;

public class DrivetrainRepository : IDrivetrainRepository
{
    public Task<List<Drivetrain>> GetAllDrivetrainsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Drivetrain> GetDrivetrainByCodeAsync(string code)
    {
        throw new NotImplementedException();
    }

    public Task<Drivetrain> GetDrivetrainByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
