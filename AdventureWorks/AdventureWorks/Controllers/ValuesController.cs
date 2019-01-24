using System;
using System.Collections.Generic;
using Core;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDataProvider _dataProvider;

        public ValuesController(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider ?? throw new ArgumentNullException(nameof(dataProvider));
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<PersonAddress> Get()
        {
            var adresses = _dataProvider.GetPersonAdreses();
            //var provinces = _dataProvider.GetStateProvinces();

            return adresses; //new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
