using Microsoft.AspNetCore.Mvc;

namespace Walkiria.Restricitons.Web.Models.Bans;

public class GetBannedUserRequest
{
    [FromRoute]
    public long UserTgId { get; set; }

    [FromRoute]
    public long GroupTgId { get; set; }
}