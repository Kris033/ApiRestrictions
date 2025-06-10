namespace Walkiria.Restricitons.Web.Models.Mutes;

public class GetMutedUserListItem
{
    public DateTime RemainingDateTimeWarned { get; set; }

    public string? Reason { get; set; }
}