
using Net5.R.InfraAlu.CrossCutting.Dtos;
using System;
using System.Collections.Generic;

namespace Net5.R.API.ApplicationServices
{
    public interface ILibraryApplicationService
    {
        List<AlumnosDto> GetAlumnoss();
        AlumnosDto GetAlumnoE(Guid alumnoId);

        AlumnosDto CreateAlumnos(AlumnosForCreationDto alumno);
    }
}