using Group7Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Group7Project.DataB
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; } 
    }
}
