using Walkiria.Restrictions.DataContext.Enums;

namespace Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

public class RemoveRestrictionsRequest
{
    public long TelegramId { get; set; }

    public EnumTypeResctriction TypeResctriction { get; set; }
}