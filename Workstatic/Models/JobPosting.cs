using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Workstatic.Models
{
    public class JobPosting 
    {
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Standort ist erforderlich")]
        public string JobLocation { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public string ContactPhone { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public string ContactMail { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public string ContactWebsite { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public byte[] CompanyImage { get; set; }
        [Required(ErrorMessage = "Standort ist erforderlich")]
        public string OwnerUsername { get; set; }
        
    }
}
