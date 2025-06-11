using Microsoft.AspNetCore.Mvc;

namespace Walkiria.Restricitons.Web.Models.Warns;

public class GetWarnsUserRequest
{
    [FromRoute]
    public long UserTgId { get; set; }

    [FromRoute]
    public long GroupTgId { get; set; }
}
