using Microsoft.AspNetCore.Mvc;
using RaceHubMotorsSqlite.API.DTO.Response;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DAL.Extensions;

namespace RaceHubMotorsSqlite.API.Controllers
{
    /// <summary>
    /// This class contains methods that interact with the Drivetrain entity. 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DrivetrainController(IDrivetrainRepository drivetrainRepo,
        ILogger<DrivetrainController> logger) : ControllerBase
    {
        private readonly IDrivetrainRepository drivetrainRepo = drivetrainRepo;
        private readonly ILogger<DrivetrainController> logger = logger;

        /// <summary>
        /// This method will get all of the drivetrains from the database.
        /// </summary>
        /// <returns>A unit of execution that contains a type of <see cref="ActionResult"/>.</returns>
        [HttpGet("GetAllDrivetrains")]
        [ProducesResponseType(typeof(GetDrivetrainsResponse), StatusCodes.Status200OK, "application/json")]
        public async Task<ActionResult> GetAllDrivetrainsAsync()
        {
            this.logger.LogInformation("Getting all the drivetrains...");

            try
            {
                var dbResults = await this.drivetrainRepo.GetAllDrivetrainsAsync();

                var results = dbResults.Select(x => x.ToDto()).ToList();

                return this.StatusCode(StatusCodes.Status200OK, new GetDrivetrainsResponse
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
