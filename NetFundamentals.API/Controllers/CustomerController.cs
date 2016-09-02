using NetFundamentals.Model;
using NetFundamentals.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetFundamentals.API.Controllers
{
    public class CustomerController : ApiController
    {
        private IRepository<Customer> repository;
        public CustomerController() {
            repository = new BaseRepository<Customer>();
        }

        [HttpPut]
        public IHttpActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(repository.Add(customer));
        }

        [HttpGet]
        public IHttpActionResult Details(int? id)
        {
            var customer = repository.GetById(x => x.CustomerId == id);
            if (customer == null)
                return BadRequest(ModelState);
            return Ok(customer);
        }

    }
}
