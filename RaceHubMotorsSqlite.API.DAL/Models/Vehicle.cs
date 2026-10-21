// <copyright file="Vehicle.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

namespace RaceHubMotorsSqlite.API.DAL.Models;

/// <summary>
/// This class represents the vehicle database entity.
/// </summary>
public class Vehicle
{
    /// <summary>
    /// Gets or sets the vehicle ID.
    /// </summary>
    public int VehicleId { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer ID.
    /// </summary>
    public int ManufacturerId { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the picture.
    /// </summary>
    public string Picture { get; set; } = string.Empty;
}