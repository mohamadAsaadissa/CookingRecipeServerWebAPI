using CookingRecipesWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CookingRecipesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitchensController : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();

        private readonly ILogger<KitchensController> _logger;

        public KitchensController(ILogger<KitchensController> logger)
        {
            _logger = logger;
        }

        // GET: api/<KitchensController>
        [HttpGet]
        public IEnumerable<Kitchen> Get()
        {
            return db.Kitchens;
        }

        // GET api/<KitchensController>/5
        [HttpGet("{id}")]
        public Kitchen Get(int id)
        {
            Kitchen kitchen = db.Kitchens.Find(id);

            return kitchen;
        }

        // POST api/<KitchensController>
        [HttpPost]
        public void Post([FromBody] Kitchen kitchen)
        {
            db.Kitchens.Add(kitchen);
            db.SaveChanges();
        }

        // PUT api/<KitchensController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Kitchen kitchen)
        {
            if (id == kitchen.KitchenId)
            {
                db.Entry(kitchen).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/<KitchensController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Kitchen kitchen = db.Kitchens.Find(id);
            if (kitchen != null)
            {
                db.Kitchens.Remove(kitchen);
                db.SaveChanges();
            }
        }
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
