using Walkiria.Restrictions.Interfaces.Dtos;

namespace Walkiria.Restricitons.Web.Models.Bans;

public class GetBannedUserResponse : BaseResponse
{
    public List<GetBannedUserListItem> Items { get; set; } = [];
}