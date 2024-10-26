using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaceHubMotorsSqlite.API.Services.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Response;

namespace RaceHubMotorsSqlite.API.Controllers
{
    /// <summary>
    /// This class contains methods that interact with the Drivetrain entity. 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DrivetrainController(IDrivetrainService drivetrainSvc,
        ILogger<DrivetrainController> logger) : ControllerBase
    {
        private readonly IDrivetrainService drivetrainSvc = drivetrainSvc;
        private readonly ILogger<DrivetrainController> logger = logger;

        /// <summary>
        /// This method will get all of the drivetrains from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetAllDrivetrains")]
        public async Task<ActionResult> GetAllDrivetrainsAsync()
        {
            this.logger.LogInformation("Getting all the drivetrains...");

            try
            {
                var results = await this.drivetrainSvc.GetAllDrivetrainsAsync();

                return this.Ok(new GetDrivetrainsResponse
                {
                    Drivetrains = results
                });
            }
            catch (Exception ex)
            {
                return this.ErrorResult(ex);
            }
        }

        private ObjectResult ErrorResult(Exception ex)
        {
            this.logger.LogError("Error occurred: {message}", ex.Message);
            return this.StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
        }
    }
}
