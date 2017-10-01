using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoodsManager.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>(); 

        public ProductController(){
            products.Add(new Product(){Id = 1, Name = "Product 1"});
            products.Add(new Product(){Id = 2, Name = "Product 2"});
            products.Add(new Product(){Id = 3, Name = "Product 3"});
            products.Add(new Product(){Id = 4, Name = "Product 4"});
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products.AsEnumerable();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return products.SingleOrDefault(x => x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
