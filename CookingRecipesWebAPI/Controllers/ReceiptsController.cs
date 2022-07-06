using CookingRecipesWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CookingRecipesWebAPI.Controllers
{  
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptsController : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();

        // GET: api/<ReceiptsController>
        [HttpGet]
        public IEnumerable<Receipt> Get()
        {
            return db.Receipts;
        }

        // GET api/<ReceiptsController>/5
        [HttpGet("{id}")]
        public Receipt Get(int id)
        {
            Receipt receipt = db.Receipts.Find(id);

            return receipt;
        }

        // POST api/<ReceiptsController>
        [HttpPost]
        public void Post([FromBody] Receipt receipt)
        {
            db.Receipts.Add(receipt);
            db.SaveChanges();
        }

        // PUT api/<ReceiptsController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Receipt receipt)
        {
            if (id == receipt.ReceiptId)
            {
                db.Entry(receipt).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/<ReceiptsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Receipt receipt = db.Receipts.Find(id);
            if (receipt != null)
            {
                db.Receipts.Remove(receipt);
                db.SaveChanges();
            }
        }
    }
}
