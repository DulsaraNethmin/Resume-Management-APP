using AutoMapper;
using backend.Context;
using backend.Dtos;
using backend.Enties;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CompanyController(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateCompany([FromBody] CompanyCreateDto comppanyToCreate)
        {
            if (comppanyToCreate == null)
            {
                return BadRequest();
            }

            var company = _mapper.Map<Company>(comppanyToCreate);

            _context.Companies.Add(company);
            _context.SaveChanges();

            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok("Successfully Created.");
        }
    }
}
