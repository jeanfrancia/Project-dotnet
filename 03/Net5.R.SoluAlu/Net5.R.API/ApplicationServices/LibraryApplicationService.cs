using AutoMapper;
using Net5.R.InfraAlu.CrossCutting.Dtos;
using Net5.R.InfraAlu.Data.Contexts;
using Net5.R.InfraAlu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Net5.R.API.ApplicationServices
{
    public class LibraryApplicationService : ILibraryApplicationService
    {
        private readonly LibraryContext _context;
        private readonly IMapper _mapper;
        public LibraryApplicationService(
            LibraryContext context,
            IMapper mapper
            ) 
        {
            _context = context;
            _mapper = mapper;
        }

        public AlumnosDto CreateAlumnos(AlumnosForCreationDto alumno)
        {
            var alumnoEntity = _mapper.Map<Alumnos>(alumno);
            _context.Alumnos.Add(alumnoEntity);
            _context.SaveChanges();

            var alumnoToReturn = _mapper.Map<AlumnosDto>(alumnoEntity);

            return alumnoToReturn;
        }

        public AlumnosDto GetAlumnoE(Guid alumnoId)
        {
            AlumnosDto AlumnoE = _mapper.Map<AlumnosDto>(_context.Alumnos.FirstOrDefault(a=>a.AlumnosId == alumnoId));
            return AlumnoE; 
        }

        public List<AlumnosDto> GetAlumnoss()
        {
            List<AlumnosDto> Alumnoss = _mapper.Map<List<AlumnosDto>>(_context.Alumnos.ToList()); 
            return Alumnoss;
        }
    }
}
