using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Experience : IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string WorkInTime { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
    }
}
