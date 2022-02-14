using System;

namespace Net5.R.Alumnos.Data.Entities
{
    public class course
    {
        public Guid courseId { get; set; }
        public String courseName { get; set; }
        public String Description { get; set; }
        public Guid AlumnosId { get; set; }
        public Guid ProfesorId { get; set; }
        public decimal Parcial { get; set; }
        public decimal Final { get; set; }
        public decimal ScoreFinal { get; set; }
        public Alumnos Alumnos { get; set; }

    }
}