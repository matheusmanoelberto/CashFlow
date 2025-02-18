using CashFlow.Domain.Enums;

namespace CashFlow.Domain.Entities;

public class User
{
    public long id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Guid UserIdentifier { get; set; }
    public string MyProperty { get; set; } = Roles.TEM_MEMBER;
}