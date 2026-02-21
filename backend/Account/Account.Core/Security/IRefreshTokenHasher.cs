namespace Account.Core.Security;

public interface IRefreshTokenHasher
{
    string Hash(string refreshToken);
}
