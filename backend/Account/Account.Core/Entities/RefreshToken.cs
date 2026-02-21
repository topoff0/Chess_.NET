using System.Security.Cryptography;

namespace Account.Core.Entities;

public sealed class RefreshToken
{
    public Guid Id { get; set; }
    public string Token { get; private set; } = string.Empty;

    public Guid UserId { get; private set; }
    public User User { get; private set; } = null!;

    public DateTime Expires { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public DateTime? RevokedAt { get; private set; }
    public string? ReplacedByToken { get; private set; }

    public bool IsExpired => DateTime.UtcNow >= Expires;
    public bool IsActive => RevokedAt is null && !IsExpired;


    private RefreshToken() { }


    public static RefreshToken Create(Guid userId, int expiryDays)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty", nameof(userId));

        if (expiryDays <= 0)
            throw new ArgumentException("Expiry days must be positive");

        return new RefreshToken
        {
            Id = Guid.NewGuid(),
            Token = GenerateSecurityToken(),
            UserId = userId,
            Expires = DateTime.UtcNow.AddDays(expiryDays),
            CreatedAt = DateTime.UtcNow
        };
    }

    public void Revoke(string? replacedByToken = null)
    {
        if (!IsActive)
            return;

        RevokedAt = DateTime.UtcNow;
        ReplacedByToken = replacedByToken;
    }


    private static string GenerateSecurityToken()
    {
        var randomBytes = new byte[64];

        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomBytes);

        return Convert.ToBase64String(randomBytes)
            .Replace('/', '_')
            .Replace('+', '-')
            .Replace("=", "");
    }
}
