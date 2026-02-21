using System.Security.Cryptography;
using System.Text;
using Account.Core.Security;

namespace Account.Infrastructure.Security;

public class RefreshTokenHasher : IRefreshTokenHasher
{
    public string Hash(string refreshToken)
    {
        //HACK: Make better algorithm
        var bytes = Encoding.UTF8.GetBytes(refreshToken);
        return Convert.ToHexString(SHA256.HashData(bytes));
    }
}
