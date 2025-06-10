namespace Walkiria.Restricitons.Web.Models.Mutes;

public class SetUserMuteRequest
{
    public long TelegramId { get; set; }

    public DateTime DateEnd { get; set; }

    public string? Reason { get; set; }
}
