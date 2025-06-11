namespace Walkiria.Restricitons.Web.Models.Bans;

public class GetBannedUserListItem
{
    public TimeSpan RemainingDateTimeBanned { get; set; }

    public string? Reason { get; set; }
}