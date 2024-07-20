#nullable disable

using Newtonsoft.Json;

namespace RaceHubMotorsSqlite.API.DTO.Request
{
    /// <summary>
    /// This class represents the request when adding a new vehicle type.
    /// </summary>
    public class AddVehicleTypeRequest
    {
        /// <summary>
        /// Gets or sets the vehicle type code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}