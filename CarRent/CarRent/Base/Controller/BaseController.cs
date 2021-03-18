using CarRent.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Base.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Entity, Repository, Id> : ControllerBase
        where Entity : class
        where Repository : IRepository<Entity, Id>
    {
        private readonly Repository repository;

        public BaseController(Repository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var data = repository.Get();
            return (data != null) ? (ActionResult)Ok(new { data = data, status = "Ok" }) : StatusCode(500, new { data = data, status = "Internal Server Error", errorMessage = "Cannot Get The Data" });
        }

        [HttpGet("{id}")]
        public ActionResult Get(Id id)
        {
            var data = repository.Get(id);
            return (data != null) ? (ActionResult)Ok(new { data = data, status = "Ok" }) : NotFound(new { data = data, status = "Not Found", errorMessage = "ID Isn't Indentifier" });
        }

        [HttpPut]
        public ActionResult Update(Entity entity)
        {
            try 
            {
                var data = repository.Update(entity);
                return Ok(new { status = "Ok" });
            }
            catch (Exception)
            {
                return StatusCode(500, new { status = "Internal Server Error", errorMessage = "Failed to Input The Data" });
            }
        }


    }
}
