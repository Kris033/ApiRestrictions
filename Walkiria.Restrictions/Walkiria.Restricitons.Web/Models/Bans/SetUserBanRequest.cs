namespace Walkiria.Restricitons.Web.Models.Bans;

public class SetUserBanRequest
{
    public long TelegramId { get; set; }

    public DateTime DateEnd { get; set; }

    public string? Reason { get; set; }
}