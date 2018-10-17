using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Model;

namespace ConsoleApplication1.Context
{
    class UniversityContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
