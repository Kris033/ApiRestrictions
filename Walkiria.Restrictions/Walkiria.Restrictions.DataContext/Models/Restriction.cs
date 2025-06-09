using Walkiria.Restrictions.DataContext.Enums;

namespace Walkiria.Restrictions.DataContext.Models;

public class Restriction
{
    public long TelegramId { get; set; }

    public string? Reason { get; set; }

    public EnumTypeResctriction TypeResctriction { get; set; }

    public DateTime? DateEnd { get; set; }
}
