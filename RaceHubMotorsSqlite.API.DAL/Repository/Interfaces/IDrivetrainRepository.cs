using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

/// <summary>
/// This interface defines methods that interact with the Drivetrain database entity.
/// </summary>
public interface IDrivetrainRepository
{
    /// <summary>
    /// This method definition will get all of the drivetrains from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="Drivetrain"/>.</returns>
    Task<List<Drivetrain>> GetAllDrivetrainsAsync();

    /// <summary>
    /// This method definition will get a single drivetrain from the database.
    /// </summary>
    /// <param name="id">The primary key of the drivetrain entity - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    Task<Drivetrain> GetDrivetrainAsync(int id);

    /// <summary>
    /// This method definition will get a single drivetrain from the database.
    /// </summary>
    /// <param name="code">The code to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    Task<Drivetrain> GetDrivetrainAsync(string code);

    /// <summary>
    /// This method definition will add a new drivetrain to the database.
    /// </summary>
    /// <param name="drivetrain">The new drivetrain information.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    Task<Drivetrain> AddDrivetrainAsync(Drivetrain drivetrain);
}
