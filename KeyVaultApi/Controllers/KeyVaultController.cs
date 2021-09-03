﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KeyVaultApi.Controllers
{
    public class KeyVaultController : ApiController
    {
        // GET: api/KeyVault
        public List<string> Get()
        {
            var result = new List<string>();
            var val = ConfigurationManager.AppSettings["ClientSecret"];

            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"];

            result.Add(val);
            result.Add(connectionString.ConnectionString);

            return result;
        }

        // GET: api/KeyVault/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/KeyVault
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/KeyVault/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/KeyVault/5
        public void Delete(int id)
        {
        }
    }
}
