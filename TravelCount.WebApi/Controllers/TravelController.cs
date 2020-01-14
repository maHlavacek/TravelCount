using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contract = TravelCount.Contracts.Persistence.ITravel;
using Model = TravelCount.Transfer.Persistence.Travel;
namespace TravelCount.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TravelController : GenericController<Contract, Model>
    {
        [HttpGet("/api/[controller]/Count")]
        public Task<int> GetCountAsync()
        {
            return base.CountAsync();
        }

        [HttpGet("/api/[controller]/Get")]
        public Task<IEnumerable<Contract>> GetAsync()
        {
            return base.GetAllAsync();
        }
    }
}
