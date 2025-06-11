using Walkiria.Restrictions.Interfaces.Dtos;

namespace Walkiria.Restricitons.Web.Models.Warns;

public class GetWarnsUserResponse : BaseResponse
{
    public List<GetWarnsUserListItem> Items { get; set; } = [];
}
