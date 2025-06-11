using Walkiria.Restrictions.DataContext.Enums;

namespace Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

public class RemoveRestrictionsRequest
{
    public long UserTgId { get; set; }

    public long GroupTgId { get; set; }

    public EnumTypeResctriction TypeResctriction { get; set; }
}