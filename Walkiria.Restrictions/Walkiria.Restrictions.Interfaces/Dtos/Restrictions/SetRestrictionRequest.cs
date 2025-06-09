using Walkiria.Restrictions.DataContext.Enums;

namespace Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

public class SetRestrictionRequest
{
    public long TelegramId { get; set; }

    public DateTime? DateEnd { get; set; }

    public string? Reason { get; set; }

    public EnumTypeResctriction TypeResctriction { get; set; }
}
