using Microsoft.AspNetCore.Mvc;
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
    public async Task<BaseResponse> GetWarnsUser()
    {

    }

    [HttpPost]
    public async Task<BaseResponse> SetUserWarn()
    {

    }

    [HttpDelete]
    public async Task<BaseResponse> RemoveWarnUser()
    {

    }
}
