using RaceHubMotorsSqlite.API.DAL.Context;

namespace RaceHubMotorsSqlite.DAL.Repository;

public class ManufacturerRepository(MotorsContext motorsContext) : IManufacturerRepository
{
    private readonly MotorsContext motorsContext = motorsContext;
}