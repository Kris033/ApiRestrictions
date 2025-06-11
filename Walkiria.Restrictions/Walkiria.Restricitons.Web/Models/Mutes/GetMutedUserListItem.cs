namespace Walkiria.Restricitons.Web.Models.Mutes;

public class GetMutedUserListItem
{
    public TimeSpan RemainingDateTimeMuted { get; set; }

    public string? Reason { get; set; }
}