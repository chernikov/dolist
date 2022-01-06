namespace Dolist.Api.Controllers;

[Route("/api/connection-string")]
public class ConnectionStringController : Controller
{
    private readonly ConnectionOptions options;

    public ConnectionStringController(ConnectionOptions options)
    {
        this.options = options;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var connectionString = options.ConnectionString;
        return Ok(connectionString);
    }

    [HttpPost]
    public IActionResult Post([FromBody]string connectionString)
    {
        options.ConnectionString = connectionString;
        return Ok(options.ConnectionString);
    }
}

