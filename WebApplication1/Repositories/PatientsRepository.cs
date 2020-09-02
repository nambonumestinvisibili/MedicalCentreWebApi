using MedicCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class PatientsRepository
    {
        public static int counter = 4;
        public static List<Patient> Patients = new List<Patient>
        {
            new Patient {Id=1, Name="Peter", SurName="Parker",
                        ListOfVisitsId = new List<int>{2, 6}},
            new Patient {Id=2, Name="Tony", SurName="Stark",
                        ListOfVisitsId = new List<int>{1}},
            new Patient {Id=3, Name="Pepper", SurName="Popps",
                        ListOfVisitsId=new List<int>{3, 5}},
            new Patient {Id=4, Name="Wanda", SurName="Maximoff",
                        ListOfVisitsId=new List<int>{4}}

        };

        public static PatientDTO ConvertPatientToPatientDTO(Patient pat)
        {
            return new PatientDTO
            {
                Id = pat.Id,
                Links = new List<LinkDTO>(),
                Name = pat.Name,
                SurName = pat.SurName
            };
        }

        public static List<Patient> FindAll()
        {
            return Patients;
        }

        public static Patient FindById(int id)
        {
            return Patients[id];
        }
    }
}
