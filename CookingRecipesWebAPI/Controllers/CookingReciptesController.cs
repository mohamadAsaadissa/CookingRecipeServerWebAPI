using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CookingRecipesWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CookingReciptesController : ControllerBase
    {
        

        private readonly ILogger<CookingReciptesController> _logger;

        public CookingReciptesController(ILogger<CookingReciptesController> logger)
        {
            _logger = logger;
        }
        // GET api/CookingRecipte/
        [HttpGet]
        public IEnumerable<Dish> Get()
        {
            return null;
        }
        // DELETE api/CookingRecipte/5
        [HttpDelete]
        public void Delete(int id)
        { }
    }
}
