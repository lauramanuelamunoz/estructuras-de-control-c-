using Microsoft.EntityFrameworkCore;

namespace CrudNativo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext : DbContext options) : base(options)
            {
            }
            public DbSet <Models.Producto> Productos {  get; set; }
    
}
