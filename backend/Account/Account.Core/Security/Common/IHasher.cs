namespace Account.Core.Security.Common;

public interface IHasher
{
    string Hash(string data);
    bool Verify(string data, string hash);
}
