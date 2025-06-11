using Walkiria.Restrictions.Interfaces.Dtos;

namespace Walkiria.Restricitons.Web.Models.Mutes;

public class GetMutedUserResponse : BaseResponse
{
    public List<GetMutedUserListItem> Items { get; set; } = [];
}