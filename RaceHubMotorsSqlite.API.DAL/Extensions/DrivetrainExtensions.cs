using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Extensions;

public static class DrivetrainExtensions 
{
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