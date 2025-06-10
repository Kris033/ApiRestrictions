using Microsoft.AspNetCore.Mvc;
using Walkiria.Restricitons.Web.Models.Bans;
using Walkiria.Restricitons.Web.Models.Warns;
using Walkiria.Restrictions.DataContext.Enums;
using Walkiria.Restrictions.Interfaces;
using Walkiria.Restrictions.Interfaces.Dtos;

namespace Walkiria.Restricitons.Web.Controllers;

[ApiController]
public class WarnController : BaseController
{
    private readonly IRestrictionsService _restrictionsService;

    public WarnController(IRestrictionsService restrictionsService) : base(EnumTypeResctriction.Warn)
    {
        _restrictionsService = restrictionsService;
    }

    [HttpGet]
    public async Task<GetWarnsUserResponse> GetWarnsUser([FromRoute] GetWarnsUserRequest request)
    {
        return new GetWarnsUserResponse();
    }

    [HttpPost]
    public async Task<BaseResponse> SetUserWarn(SetUserWarnRequest request)
    {
        return new BaseResponse();
    }

    [HttpDelete]
    public async Task<BaseResponse> RemoveWarnUser(RemoveWarnUserRequest request)
    {
        return new BaseResponse();
    }
}
