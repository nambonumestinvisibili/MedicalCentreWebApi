using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class VisitsRepository
    {

        public static int counter = 6;
        public static List<Visit> Visits = new List<Visit>
        {
            new Visit {Id=1, Date="today", IsPaid=true},
            new Visit {Id=2, Date="today", IsPaid=true},
            new Visit {Id=3, Date="today", IsPaid=false},
            new Visit {Id=4, Date="today", IsPaid=true},
            new Visit {Id=5, Date="yesterday", IsPaid=true},
            new Visit {Id=6, Date="yesterday", IsPaid=false},

        };

        public static List<Visit> FindAll()
        {
            return Visits;
        }

        public static Visit FindById(int id)
        {
            return Visits[id];
        }
    }
}
