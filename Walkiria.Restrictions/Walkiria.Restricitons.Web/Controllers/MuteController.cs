using Microsoft.AspNetCore.Mvc;
using Walkiria.Restricitons.Web.Models.Bans;
using Walkiria.Restrictions.DataContext.Enums;
using Walkiria.Restrictions.Interfaces;
using Walkiria.Restrictions.Interfaces.Dtos;

namespace Walkiria.Restricitons.Web.Controllers;

[ApiController]
public class MuteController : BaseController
{
    private readonly IRestrictionsService _restrictionsService;

    public MuteController(IRestrictionsService restrictionsService) : base(EnumTypeResctriction.Mute)
    {
        _restrictionsService = restrictionsService;
    }

    [HttpGet]
    public async Task<BaseResponse> GetMutedUser()
    {

    }

    [HttpPost]
    public async Task<BaseResponse> SetUserMute()
    {

    }

    [HttpDelete]
    public async Task<BaseResponse> RemoveMuteUser()
    {

    }
}
