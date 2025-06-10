using Microsoft.AspNetCore.Mvc;
using Walkiria.Restricitons.Web.Models.Bans;
using Walkiria.Restricitons.Web.Models.Mutes;
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
    public async Task<GetMutedUserResponse> GetMutedUser([FromRoute] GetMutedUserRequest request)
    {
        return new GetMutedUserResponse();
    }

    [HttpPost]
    public async Task<BaseResponse> SetUserMute(SetUserMuteRequest request)
    {
        return new BaseResponse();
    }

    [HttpDelete]
    public async Task<BaseResponse> RemoveMuteUser(RemoveMuteUserRequest request)
    {
        return new BaseResponse();
    }
}
