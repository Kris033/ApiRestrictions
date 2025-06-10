namespace Walkiria.Restricitons.Web.Models.Bans;

public class GetBannedUserListItem
{
    public DateTime RemainingDateTimeBanned { get; set; }

    public string? Reason { get; set; }
}