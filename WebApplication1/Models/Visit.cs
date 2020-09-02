using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Visit
    {
        //public DateTime Date { get; set; }
        public int Id { get; set; }
        public string Date { get; set; }
        public bool IsPaid { get; set; }
    }
}
