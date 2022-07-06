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
    public class IngredientsController : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();

        private readonly ILogger<IngredientsController> _logger;

        public IngredientsController(ILogger<IngredientsController> logger)
        {
            _logger = logger;
        }

        // GET: api/<IngredientsController>
        [HttpGet]
        public IEnumerable<Ingredient> Get()
        {
            return db.Ingredients;
        }

        // GET api/<IngredientsController>/5
        [HttpGet("{id}")]
        public Ingredient Get(int id)
        {
            Ingredient ingredient = db.Ingredients.Find(id);

            return ingredient;
        }

        // POST api/<IngredientsController>
        [HttpPost]
        public void Post([FromBody] Ingredient ingredient)
        {
            db.Ingredients.Add(ingredient);
            db.SaveChanges();
        }

        // PUT api/<IngredientsController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Ingredient ingredient)
        {
            if (id == ingredient.IngredientId)
            {
                db.Entry(ingredient).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/<IngredientsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Ingredient ingredient = db.Ingredients.Find(id);
            if (ingredient != null)
            {
                db.Ingredients.Remove(ingredient);
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
