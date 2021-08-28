using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNPSampleProject.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public DateTime LastContactedDate { get; set; }
        public string Comments { get; set; }
    }
}
