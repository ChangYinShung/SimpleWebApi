using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpletApi.Context;
using SimpletApi.Models;
using Newtonsoft.Json;
using SimpletApi.Domains;

namespace SimpletApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpPost]
        public void PostCreate(ProductCreateDto model)
        {
            using (var db = new DBContext())
            {
                var product = new Domains.Product()
                {
                    Title = model.Title,
                    ProductCode = model.ProductCode,
                    Description = model.Description
                };
                db.Products.Add(product);
                db.SaveChanges();
            }
        }
        [HttpGet]
        public Domains.Product Get(int id) {
                using (var db = new DBContext())
                {
                    var result = db.Products.Where(x => x.Id == id).SingleOrDefault();
                    return result;
                }
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Domains.Product>), 200)]
        public List<Domains.Product> LoadAll()
        {
            using (var db = new DBContext())
            {
              
                var result = db.Products.ToList();
                return result;
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            using (var db = new DBContext())
            {
                var domain = db.Products.SingleOrDefault(x => x.Id == id);
                db.Products.Remove(domain);
                db.SaveChanges();
            }
        }


    }
}
