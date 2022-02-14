using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net5.R.API.ApplicationServices;
using Net5.R.InfraAlu.CrossCutting.Dtos;
using System;

namespace Net5.R.API.Controllers
{
    [Route("api/alumnos")]
    [ApiController]
    public class AlumnossController : ControllerBase
    {
        private readonly ILibraryApplicationService _libraryApplicationService;

        public AlumnossController(
            ILibraryApplicationService libraryApplicationService)
        {
            _libraryApplicationService = libraryApplicationService;
        }

        [HttpGet]
        public IActionResult GetAlumnoss()
        {
            return Ok(_libraryApplicationService.GetAlumnoss());
        }

        [HttpGet("{id}", Name ="GetAlumnoE")]
        public IActionResult GetAlumnoE(Guid id)
        {
            return Ok(_libraryApplicationService.GetAlumnoE(id));
        }

        [HttpPost]
        public IActionResult CreateAlumnos([FromBody] AlumnosForCreationDto alumno)
        {
            if(alumno == null)
            {
                return BadRequest();
            }

            var result = _libraryApplicationService.CreateAlumnos(alumno);
            return CreatedAtRoute("GetAlumnoE", new {id = result.AlumnosId }, result);  
        }
    }
}
