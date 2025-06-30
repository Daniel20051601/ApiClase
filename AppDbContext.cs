using ApiClase.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace ApiClase;

public class AppDbContext: DbContext
{
    public DbSet<Productos> productos => Set<Productos>();

    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {

    }
       

}
