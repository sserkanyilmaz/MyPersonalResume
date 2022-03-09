using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string About { get; set; }
        public string GithubAddress { get; set; }
        public string LinkedInAddress { get; set; }
        public string Photo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
