using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

public class AppDbContext : DbContext 
{
    protected readonly IConfiguration Configuration; 
    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;    
    }    
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Person>personen { get; set; }
}



//Server=DESKTOP-V469TKV;Databse=Personen;Trusted_Connection=True

//https://zetbit.tech/categories/asp-dot-net-core/56/insert-row-to-db-by-form-blazor