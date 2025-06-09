using Walkiria.Restrictions.DataContext.Enums;

namespace Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

public class GetRestrictionsRequest
{
    public long TelegramId { get; set; }

    public EnumTypeResctriction TypeResctriction { get; set; }
}
