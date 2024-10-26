#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Request
{
    /// <summary>
    /// This class represents the request when adding a new vehicle type.
    /// </summary>
    [SwaggerSchema(Description = "The request when adding a new vehicle type")]
    public class AddVehicleTypeRequest
    {
        /// <summary>
        /// Gets or sets the vehicle type code.
        /// </summary>
        [JsonProperty("code")]
        [SwaggerSchema(Description = "The code of the new vehicle type")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        [JsonProperty("description")]
        [SwaggerSchema(Description = "The description of the new vehicle type")]
        public string Description { get; set; }
    }
}