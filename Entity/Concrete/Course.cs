using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Link { get; set; }
        public DateTime StartingTime { get; set; }
    }
}
