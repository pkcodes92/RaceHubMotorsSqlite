// <copyright file="RefreshToken.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

namespace RaceHubMotorsSqlite.API.DAL.Models;

/// <summary>
/// This class represents a record in the Refresh Token table.
/// </summary>
public partial class RefreshToken
{
    /// <summary>
    /// The primary key of the refresh token.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The relevant user ID that the refresh token is scoped to.
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// The actual refresh token itself.
    /// </summary>
    public string Token { get; set; } = null!;

    /// <summary>
    /// The date and time the refresh token record is created.
    /// </summary>
    public string CreatedDate { get; set; } = null!;

    /// <summary>
    /// The date and time that the refresh token expires.
    /// </summary>
    public string ExpirationDate { get; set; } = null!;
}
