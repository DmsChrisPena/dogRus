using dogsRus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dogsRus.Controllers.Api
{
    public class DogsController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public IHttpActionResult Get()
        {
            var dogs = _db.Dogs;

            return Ok(dogs);
        }
        
        public IHttpActionResult Post(Dog dog)
        {
            _db.Dogs.Add(dog);

            _db.SaveChanges();

            return Ok("Well it worked homie");
        }
    }
}
