using Microsoft.EntityFrameworkCore;

namespace An_e_commerce_app.Data
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        
        {
            
        }
    }
}
