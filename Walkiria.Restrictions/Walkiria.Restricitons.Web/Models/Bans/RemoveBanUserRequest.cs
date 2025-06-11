namespace Walkiria.Restricitons.Web.Models.Bans;

public class RemoveBanUserRequest
{
    public long UserTgId { get; set; }

    public long GroupTgId { get; set; }
}