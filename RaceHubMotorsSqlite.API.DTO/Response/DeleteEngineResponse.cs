using System;
using System.Collections.Generic;
using System.Text;

namespace RaceHubMotorsSqlite.API.DTO.Response
{
    public class DeleteEngineResponse
    {
        public bool IsDeleted { get; set; }

        public int Id { get; set; }
    }
}
