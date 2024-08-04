namespace RaceHubMotorsSqlite.API.DTO.Request;

public class UpdateEngineRequest
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }
}