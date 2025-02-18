using CashFlow.Domain.Security.Cryptography;
using BC = BCrypt.Net.BCrypt;

namespace CashFlow.Infrastructure.Secuity;

public class BCrypt : IPasswordEncripter
{
    public string Encrypt(string Password)
    {
        string passwordHash = BC.HashPassword(Password);

        return passwordHash;
    }
}