using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Skill : IEntity
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public byte Grade { get; set; }
    }
}
