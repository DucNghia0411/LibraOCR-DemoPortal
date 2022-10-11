using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.API.VehicleRegistration
{
    public interface IVehicleRegistrationsAPI
    {
        public Task<string> ReadVehicleRegistration(IFormFile file);
    }
}
