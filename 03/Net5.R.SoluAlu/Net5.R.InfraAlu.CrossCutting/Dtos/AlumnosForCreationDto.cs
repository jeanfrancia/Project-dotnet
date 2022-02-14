using System;
using System.Collections.Generic;

namespace Net5.R.InfraAlu.CrossCutting.Dtos
{
    public class AlumnosForCreationDto
    {
        public AlumnosForCreationDto()
        {
            Courses = new List<courseForCreationDto>();
        }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public String Specialty { get; set; }

        public virtual ICollection<courseForCreationDto> Courses { get; set; }
}
}
