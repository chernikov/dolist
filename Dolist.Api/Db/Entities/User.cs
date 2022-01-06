
namespace Dolist.Api.Db.Entities;

public record User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = default!;
}