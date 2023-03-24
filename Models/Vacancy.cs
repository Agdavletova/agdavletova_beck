using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agdavletova_beck.Models
{
    public class Vacancy
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string company { get; set; }
        public int salary { get; set; }
        public string description { get; set; }
        public List <Worker> workers { get; set;  }
    }
}
