﻿using Northwind.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Northwind.WebApi.Controllers
{
    public class TransportadorasController : ApiController
    {
        public IEnumerable<Transportadora> Get()
        {
            var db = new NorthwindEntities();
            return db.Transportadoras.ToList();
        }

        public Transportadora Get(int id)
        {
            var db = new NorthwindEntities();
            return db.Transportadoras.Find(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Transportadora t)
        {
            var db = new NorthwindEntities();
            db.Transportadoras.Add(t);
            db.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Transportadora t)
        {
            var db = new NorthwindEntities();
            var original = db.Transportadoras.Find(id);
            original.Nome = t.Nome;
            original.Telefone = t.Telefone;
            db.SaveChanges();
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public void Delete(int id)
        {
            var db = new NorthwindEntities();
            var original = db.Transportadoras.Find(id);
            db.Transportadoras.Remove(original);
            db.SaveChanges();
        }
    }
}
