using Microsoft.EntityFrameworkCore;
using ogarphia_crud.Models;

namespace ogarphia_crud.Models
{
    public class HRDataBaseContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=RYUK\SQLEXPRESS; initial catalog=HRDataBase; integrated security=true;");
        }

    }
}
