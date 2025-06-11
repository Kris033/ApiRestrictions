namespace Walkiria.Restricitons.Web.Models.Bans;

public class SetUserBanRequest
{
    public long UserTgId { get; set; }

    public long GroupTgId { get; set; }

    public DateTime DateEnd { get; set; }

    public string? Reason { get; set; }
}