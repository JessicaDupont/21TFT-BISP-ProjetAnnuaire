using Annuaire.DAL.Repositories.Bases;
using Annuaire.Models.IModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolIca.DataBases.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Annuaire.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesProposesController : ControllerBase
    {
        private readonly IServiceProposesRepository serviceRepository;
        private readonly ICategorieRepository categorieRepository;
        IList<Filtre> filtres;

        public ServicesProposesController(
            IServiceProposesRepository serviceRepository,
            ICategorieRepository categorieRepository)
        {
            this.serviceRepository = serviceRepository;
            this.categorieRepository = categorieRepository;
            filtres = new List<Filtre>();
        }

        // GET: api/<ServicesProposesController>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                filtres = new List<Filtre>();
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
        [HttpGet("Categorie/{categoryId}")]
        public ActionResult<IEnumerable<string>> GetCategory(int categoryId, bool enfants = false)
        {
            try
            {
                if (enfants)
                {
                    IEnumerable<ICategorie> categories = categorieRepository.Search(new Filtre("Enfants", categoryId));
                    filtres = new List<Filtre>();
                    foreach (ICategorie enf in categories)
                    {
                        filtres.Add(new Filtre("CategorieId", enf.Id));
                    }
                }
                else 
                {
                    Filtre f = new Filtre("CategorieId", categoryId);
                    filtres.Add(f);
                }

                return Ok(serviceRepository.Search(filtres));
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

        // GET api/<ServicesProposesController>/5
        [HttpGet("Region/{regionId}")]
        public ActionResult<IEnumerable<string>> GetRegion(int regionId)
        {
            try
            {
                Filtre f = new Filtre("RegionId", regionId);
                filtres.Add(f);

                return Ok(serviceRepository.Search(filtres));
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
