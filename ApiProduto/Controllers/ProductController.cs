using ApiProduto.Context;
using ApiProduto.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProduto.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext DbProd;

        public ProductController(ProductContext db)
        {
            DbProd = db;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var product = DbProd.products.ToList();
            return product;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var product = DbProd.products.Find(id);
            return product;
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product obj)
        {
            DbProd.Add(obj);
            DbProd.SaveChanges();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product obj)
        {
            DbProd.products.Update(obj);
            DbProd.SaveChanges();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var product = DbProd.products.Find(id);
            DbProd.products.Remove(product);
            DbProd.SaveChanges();

        }
    }
}
