namespace Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

public class GetRestrictionsResponse : BaseResponse
{
    public List<GetRestrictionsListItem> Items { get; set; } = [];
}
