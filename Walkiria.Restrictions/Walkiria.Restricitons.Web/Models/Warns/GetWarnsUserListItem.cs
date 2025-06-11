namespace Walkiria.Restricitons.Web.Models.Warns;

public class GetWarnsUserListItem
{
    public TimeSpan RemainingDateTimeWarned { get; set; }

    public string? Reason { get; set; }
}