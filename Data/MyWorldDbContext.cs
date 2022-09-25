using Entitytest.API.Crud.Data.Entities;
using Microsoft.EntityFrameworkCore;
 
namespace Entitytest.API.Crud.Data;
 
public class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
    {
 
    }
    public DbSet<Cake> Cake { get; set; }
}