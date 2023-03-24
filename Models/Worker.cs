using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agdavletova_beck.Models
{
    public class Worker
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int experience { get; set; }
        public string speciality {get; set;}

        public List<Vacancy> vacancies { get; set; }
         
    }
}
