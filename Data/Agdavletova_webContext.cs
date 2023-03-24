using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using agdavletova_beck.Models;

namespace agdavletova_beck.Data
{
    public class Agdavletova_webContext : DbContext
    {
        public Agdavletova_webContext(DbContextOptions<Agdavletova_webContext> options)
            : base(options)
        {
            Database.EnsureCreated(); //создает базу данных
        }

        public DbSet<Vacancy> Vacancy { get; set; }
        public DbSet<Worker> Worker { get; set; }
    }
}