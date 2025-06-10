using Microsoft.AspNetCore.Mvc;

namespace Walkiria.Restricitons.Web.Models.Warns;

public class GetWarnsUserRequest
{
    [FromRoute]
    public long TelegramId { get; set; }
}
