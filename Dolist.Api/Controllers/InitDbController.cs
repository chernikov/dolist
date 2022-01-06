using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolist.Api.Controllers
{
    [Route("api/init-db")]
    public class InitDbController   : Controller
    {
        private readonly DoListDbContext context;

        public InitDbController(DoListDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult Post()
        {
            var connectionString = string.Empty;
            var pendingMigration = context.Database.GetPendingMigrations();
            if (pendingMigration.Any())
            {
                connectionString = context.Database.GetConnectionString();
                context.Database.Migrate();
            }
            return Ok(connectionString);
        }
    }
}
