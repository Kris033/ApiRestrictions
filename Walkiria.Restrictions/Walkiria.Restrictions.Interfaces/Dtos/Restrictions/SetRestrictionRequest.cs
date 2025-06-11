using Walkiria.Restrictions.DataContext.Enums;

namespace Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

public class SetRestrictionRequest
{
    public long UserTgId { get; set; }

    public long GroupTgId { get; set; }

    public DateTime DateEnd { get; set; }

    public string? Reason { get; set; }

    public EnumTypeResctriction TypeResctriction { get; set; }
}
