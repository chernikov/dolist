
using Dolist.Api.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dolist.Api.Db;
public class DoListDbContext : DbContext, IDoListDbContext
{
    public DbSet<User>? Users { get; set;  }

    public DbSet<DoItem>? DoItems { get; set; }


    public DoListDbContext(DbContextOptions options) : base(options)
    {
    }

}
