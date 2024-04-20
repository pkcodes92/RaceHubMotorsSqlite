using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL;

public class DrivetrainRepository(MotorsContext motorsContext) : IDrivetrainRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    public async Task<Drivetrain> AddDrivetrainAsync(Drivetrain drivetrain)
    {
        this.motorsContext.Drivetrains.Add(drivetrain);
        var result = await this.motorsContext.SaveChangesAsync();
        return result > 0 ? drivetrain! : null!;
    }

    public async Task<List<Drivetrain>> GetAllDrivetrainsAsync()
    {
        var results = await this.motorsContext.Drivetrains.ToListAsync();
        return results!;
    }

    public async Task<Drivetrain> GetDrivetrainAsync(string code)
    {
        var result = await this.motorsContext.Drivetrains.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    public async Task<Drivetrain> GetDrivetrainAsync(int id)
    {
        var result = await this.motorsContext.Drivetrains.FirstOrDefaultAsync(g => g.DrivetrainId == id);
        return result!;
    }
}
