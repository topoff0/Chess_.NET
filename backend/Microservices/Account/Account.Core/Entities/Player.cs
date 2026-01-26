
namespace Account.Core.Entities;

public class Player
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public int Elo { get; private set; }
    public List<Guid> GamesId { get; private set; } = [];
    public List<Guid> TournamentsId { get; private set; } = [];
    public List<Guid> FriendsIds { get; private set; } = [];
}
