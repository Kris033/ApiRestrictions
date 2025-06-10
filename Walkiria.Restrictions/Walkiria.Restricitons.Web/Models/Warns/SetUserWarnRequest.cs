namespace Walkiria.Restricitons.Web.Models.Warns;

public class SetUserWarnRequest
{
    public long TelegramId { get; set; }

    public DateTime DateEnd { get; set; }

    public string? Reason { get; set; }
}
