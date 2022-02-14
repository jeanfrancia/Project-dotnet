using AutoMapper;
using Net5.R.InfraAlu.CrossCutting.Dtos;
using Net5.R.InfraAlu.CrossCutting.Helpers;
using Net5.R.InfraAlu.Data.Entities;

namespace Net5.R.API.Infrastructure.Mapper
{
    public class LibraryProfile:Profile
    {
        public LibraryProfile()
        {
            CreateMap<Alumnos, AlumnosDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));

            CreateMap<AlumnosForCreationDto, Alumnos>();
            CreateMap<courseForCreationDto, course>();
        }


    }
}
