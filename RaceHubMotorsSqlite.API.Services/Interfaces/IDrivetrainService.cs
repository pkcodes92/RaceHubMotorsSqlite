﻿using RaceHubMotorsSqlite.API.DTO.Models;

namespace RaceHubMotorsSqlite.API.Services.Interfaces;

/// <summary>
/// This interface defines methods that interact with the Drivetrain UI entity.
/// </summary>
public interface IDrivetrainService
{
    /// <summary>
    /// This method definition will get all the drivetrains from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="Drivetrain"/>.</returns>
    Task<List<Drivetrain>> GetAllDrivetrainsAsync();

    /// <summary>
    /// This method definition will get a single drivetrain from the database.
    /// </summary>
    /// <param name="id">The primary key of the Drivetrain UI entity - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="Drivetrain"/>.</returns>
    Task<Drivetrain> GetDrivetrainAsync(int id);
}
