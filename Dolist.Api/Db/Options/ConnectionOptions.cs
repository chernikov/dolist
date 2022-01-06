namespace Dolist.Api.Db.Options;
public class ConnectionOptions
{
    public string ConnectionString { get; set; } = null!;

    public ConnectionOptions(IConfiguration cfg)
    {

        ConnectionString = cfg.GetConnectionString("DefaultConnection");
    }
}
