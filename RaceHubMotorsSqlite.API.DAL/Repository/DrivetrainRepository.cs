using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;

namespace RaceHubMotorsSqlite.API.DAL;

public class DrivetrainRepository(MotorsContext motorsContext) : IDrivetrainRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    public async Task<List<Drivetrain>> GetAllDrivetrainsAsync()
    {
        var results = await this.motorsContext.Drivetrains.ToListAsync();
        return results!;
    }

    public async Task<Drivetrain> GetDrivetrainByCodeAsync(string code)
    {
        var result = await this.motorsContext.Drivetrains.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    public async Task<Drivetrain> GetDrivetrainByIdAsync(int id)
    {
        var result = await this.motorsContext.Drivetrains.FirstOrDefaultAsync(g => g.DrivetrainId == id);
        return result!;
    }
}
