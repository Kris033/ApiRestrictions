using Microsoft.AspNetCore.Mvc;

namespace Walkiria.Restricitons.Web.Models.Mutes;

public class GetMutedUserRequest
{
    [FromRoute]
    public long UserTgId { get; set; }

    [FromRoute]
    public long GroupTgId { get; set; }
}
