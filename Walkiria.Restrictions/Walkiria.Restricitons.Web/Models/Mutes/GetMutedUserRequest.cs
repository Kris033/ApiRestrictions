using Microsoft.AspNetCore.Mvc;

namespace Walkiria.Restricitons.Web.Models.Mutes;

public class GetMutedUserRequest
{
    [FromRoute]
    public long TelegramId { get; set; }
}
