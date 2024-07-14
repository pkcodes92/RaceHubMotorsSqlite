using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.DAL.Repository;

/// <summary>
/// Initializes an instance of <see cref="DrivetrainRepository"/>.
/// </summary>
/// <remarks>This class implements defined in <see cref="IDrivetrainRepository"/>.</remarks>
/// <param name="motorsContext">The database context injection.</param>
public class DrivetrainRepository(MotorsContext motorsContext) : IDrivetrainRepository
{
    private readonly MotorsContext motorsContext = motorsContext;

    /// <summary>
    /// This method implementation will add a new drivetrain to the database.
    /// </summary>
    /// <param name="drivetrain">The new drivetrain information to add.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    public async Task<Drivetrain> AddDrivetrainAsync(Drivetrain drivetrain)
    {
        this.motorsContext.Drivetrains.Add(drivetrain);
        var result = await this.motorsContext.SaveChangesAsync();
        return result > 0 ? drivetrain! : null!;
    }

    /// <summary>
    /// This method implementation will get all the drivetrains from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="Drivetrain"/>.</returns>
    public async Task<List<Drivetrain>> GetAllDrivetrainsAsync()
    {
        var results = await this.motorsContext.Drivetrains.ToListAsync();
        return results!;
    }

    /// <summary>
    /// This method implementation will get a single drivetrain from the database.
    /// </summary>
    /// <param name="code">The drivetrain code.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    public async Task<Drivetrain> GetDrivetrainAsync(string code)
    {
        var result = await this.motorsContext.Drivetrains.FirstOrDefaultAsync(g => g.Code == code);
        return result!;
    }

    /// <summary>
    /// This method implementation will get a single drivetrain from the database.
    /// </summary>
    /// <param name="id">The ID - primary key of the drivetrain entity.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    public async Task<Drivetrain> GetDrivetrainAsync(int id)
    {
        var result = await this.motorsContext.Drivetrains.FirstOrDefaultAsync(g => g.DrivetrainId == id);
        return result!;
    }
}
