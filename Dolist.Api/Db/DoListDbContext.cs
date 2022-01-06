namespace Dolist.Api.Db;
public class DoListDbContext : DbContext, IDoListDbContext
{
    private readonly string _connectionString;

    public DbSet<User> Users { get; set; } = null!;

    public DbSet<DoItem> DoItems { get; set; } = null!;


    //public DoListDbContext(DbContextOptions options) : base(options)
    //{
    //}

    public DoListDbContext(ConnectionOptions options) 
    {
        _connectionString = options.ConnectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
}