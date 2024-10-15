using API_BTN.Model;
using Microsoft.EntityFrameworkCore;

namespace API_BTN.Data_Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Information_Details> Information { get; set; }
        public DbSet<DetailContent> DetailsContent { get; set; }
    }
}
