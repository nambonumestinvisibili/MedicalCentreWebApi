using MedicCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Patient 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public List<int> ListOfVisitsId { get; set; }

        
        
    }

    public class PatientDTO
    {
        public int Id { get; set; }
        public List<LinkDTO> Links { get; set; } //= new List<LinkDto>();
        public string Name { get; set; }
        public string SurName { get; set; }

    }

}
