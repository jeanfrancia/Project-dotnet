using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.R.InfraAlu.Data.Entities
{
    public class Alumnos
    {

        public Alumnos()
        {
            Courses = new HashSet<course>();
        }

        public Guid AlumnosId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public String Specialty { get; set; }
        public virtual ICollection<course> Courses { get; set; }
    }
}
