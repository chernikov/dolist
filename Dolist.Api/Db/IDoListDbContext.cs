
using Dolist.Api.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dolist.Api.Db;
public interface IDoListDbContext
{
    DbSet<User>? Users { get; set; }

    DbSet<DoItem>? DoItems { get; set; }

    int SaveChanges();

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

}
