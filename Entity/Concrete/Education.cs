using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Education :IEntity
    {
        public int Id { get; set; }
        public string EducationalStatus { get; set; }
        public string SchoolName { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
