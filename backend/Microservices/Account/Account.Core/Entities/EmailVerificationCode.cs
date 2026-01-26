namespace Account.Core.Entities;

public class EmailVerificationCode
{
    public Guid Id { get; private set; }
    public string Email { get; private set; } = string.Empty;
    public string HashedCode { get; private set; } = string.Empty;
    public DateTime CreatedAt { get; private set; }
    public DateTime ExpiryAt { get; private set; }

    public bool IsExpired => CreatedAt >= ExpiryAt;
    public bool IsActive => !IsExpired;
    
    private EmailVerificationCode() { }

    public static EmailVerificationCode Create(string email, string hashedCode) 
        => new()
        {
            Id = Guid.NewGuid(),
            Email = email,
            HashedCode = hashedCode,
            CreatedAt = DateTime.UtcNow,
            ExpiryAt = DateTime.UtcNow.AddMinutes(10)
        };
}
