// <copyright file="Manufacturer.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

namespace RaceHubMotorsSqlite.API.DAL.Models;

/// <summary>
/// This class represents the manufacturer entity.
/// </summary>
public class Manufacturer
{
    /// <summary>
    /// Gets or sets the manufacturer ID - the primary key.
    /// </summary>
    public int ManufacturerId { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the logo.
    /// </summary>
    public string Logo { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the national flag.
    /// </summary>
    public string NationalFlag { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    public string Region { get; set; } = string.Empty;
}