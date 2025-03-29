using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Extensions;

/// <summary>
/// This class extends the type of <see cref="Drivetrain"/>.
/// </summary>
/// <remarks>Initializes an instance of <see cref="DrivetrainExtensions"/>.</remarks>
public static class DrivetrainExtensions 
{
    /// <summary>
    /// This method converts a database entity to a DTO entity.
    /// </summary>
    /// <param name="value">The drivetrain information from the database.</param>
    /// <returns>A type of <see cref="DTO.Models.Drivetrain"/>.</returns>
    public static DTO.Models.Drivetrain ToDto(this Drivetrain value)
    {
        return new DTO.Models.Drivetrain
        {
            Id = value.DrivetrainId,
            Code = value.Code,
            Description = value.Description
        };
    }
}