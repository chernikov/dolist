
using Dolist.Api.Db;
using Dolist.Api.Db.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dolist.Api.Controllers;

[Route("/api/users")]
public class UserController : Controller
{
    private readonly IDoListDbContext dolistDbContext;

    public UserController(IDoListDbContext dolistDbContext)
    {
        this.dolistDbContext = dolistDbContext;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = dolistDbContext.Users.ToList();
        return Ok(users);
    }


    [HttpPost]
    public IActionResult Post([FromForm] string userName, [FromForm] string password)
    {

        var user = new User
        {
            UserName = userName,
            Password = password
        };

        dolistDbContext.Users.Add(user);
        dolistDbContext.SaveChanges();

        return Ok(user); 

    }
    

}
