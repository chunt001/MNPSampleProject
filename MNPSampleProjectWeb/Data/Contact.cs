using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MNPSampleProjectWeb.Data
{
    public class Contact
    {
        public Contact()
        {
            this.LastContactedDate = DateTime.Now;
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        public string Company { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime LastContactedDate { get; set; }
        public string Comments { get; set; }
    }
}
