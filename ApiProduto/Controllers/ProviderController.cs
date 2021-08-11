using ApiProduto.Context;
using ApiProduto.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiProduto.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly ProductContext DbProv;

        public ProviderController(ProductContext db)
        {
            DbProv = db;
        }
        [HttpGet]
        public IEnumerable<Provider> Get()
        {
            var prov = DbProv.providers.ToList();
            return prov;
        }

        [HttpGet("{id}")]
        public Provider Get(int id)
        {
            var prov = DbProv.providers.Find(id);
            return prov;
        }

        [HttpPost]
        public void Post([FromBody] Provider obj)
        {
            DbProv.providers.Add(obj);
            DbProv.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Provider obj)
        {
            DbProv.providers.Update(obj);
            DbProv.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var prov = DbProv.providers.Find(id);
            DbProv.providers.Remove(prov);
            DbProv.SaveChanges();
        }
    }
}
