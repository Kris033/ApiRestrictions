namespace Walkiria.Restricitons.Web.Models.Warns;

public class SetUserWarnRequest
{
    public long UserTgId { get; set; }

    public long GroupTgId { get; set; }

    public DateTime DateEnd { get; set; }

    public string? Reason { get; set; }
}
