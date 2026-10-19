// <copyright file="Drivetrain.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

namespace RaceHubMotorsSqlite.API.DAL.Models;

/// <summary>
/// This class represents the drivetrain database entity.
/// </summary>
public class Drivetrain
{
    /// <summary>
    /// Gets or sets the primary key - Drivetrain ID.
    /// </summary>
    public int DrivetrainId { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}