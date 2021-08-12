using Annuaire.DAL.Repositories.Bases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Annuaire.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesProposesController : ControllerBase
    {
        private readonly IServiceProposesRepository serviceRepository;

        public ServicesProposesController(IServiceProposesRepository serviceRepository)
        {
            this.serviceRepository = serviceRepository;
        }

        // GET: api/<ServicesProposesController>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                return Ok(serviceRepository.Read());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Get",
                        Message = ex.Message
                    });
            }
        }

        // GET api/<ServicesProposesController>/5
        [HttpGet("{categoryId}")]
        public ActionResult<IEnumerable<string>> GetCategory(int categoryId)
        {
            try
            {
                return Ok(serviceRepository.Search("CategorieId", categoryId));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "GetCategory",
                        Message = ex.Message
                    });
            }
        }

        //// GET api/<ServicesProposesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ServicesProposesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ServicesProposesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ServicesProposesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
