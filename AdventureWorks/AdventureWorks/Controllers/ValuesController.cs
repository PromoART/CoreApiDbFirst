﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        // GET api/values/addresses
        [HttpGet]
        [Route("addresses")]
        public IEnumerable<PersonAddress> GetAddresses()
        {
            var adresses = _dataProvider.GetPersonAdreses();
            //_iDataProvider.GetPersonAdreses();
            //var provinces = _dataProvider.GetStateProvinces();

            return adresses; //new string[] { "value1", "value2" };
        }

        //GET api/values/provinces
        [HttpGet]
        [Route("provinces")]
        public IEnumerable<StateProvince> GetProvince()
        {
            var provinces = _dataProvider.GetStateProvinces();
            return provinces; //new string[] { "value1", "value2" };
        }

        //GET api/values/provinces
        [HttpGet]
        [Route("regions")]
        public IEnumerable<CountryRegion> GetRegions()
        {
            var regions = _dataProvider.GetCountryRegions();

            return regions; //new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [Route("addresses")]
        public ActionResult<PersonAddress> GetAddress(int id)
        {
            var address = _dataProvider.GetPersonAddress(id);
            return address;
        }
        // GET api/values/5
        [HttpGet("{id}")]
        [Route("provinces")]
        public ActionResult<StateProvince> Getprovince(int id)
        {
            var province = _dataProvider.GetStateProvince(id);
            return province;
        }
        // POST api/values
        [HttpPost]
        [Route("addresses")]
        public void PostAddress([FromBody] PersonAddress personAddress)
        {
            var address = new PersonAddress
            {
                City = "NewYork",
                Line1 = "another street",
                PostalCode = "98104",
                ProvinceId = 195,
                StateProvince = new StateProvince{ ProvinceId = 195},
                ModifeDateTime = DateTime.Now,
                RowGuid = Guid.NewGuid()
            };

           _dataProvider.CreatePersonAddress(address);
        }

        // POST api/values
        [HttpPost]
        [Route("provinces")]
        public void PostProvince([FromBody] StateProvince province)
        {
            var newProvince = new StateProvince
            {
                Name = "Brest district",
                RegionCode = "BY",
                ModifeDateTime = DateTime.Now,
                SalesTerritoryId = 2,
                Code = "31",
                IsOnlyStateProvince = false,
                RowGuid = Guid.NewGuid()

            };

            _dataProvider.CreateStateProvince(newProvince);
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
