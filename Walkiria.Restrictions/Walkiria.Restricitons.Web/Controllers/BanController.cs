using Microsoft.AspNetCore.Mvc;
using Walkiria.Restricitons.Web.Models.Bans;
using Walkiria.Restrictions.DataContext.Enums;
using Walkiria.Restrictions.Interfaces;
using Walkiria.Restrictions.Interfaces.Dtos;

namespace Walkiria.Restricitons.Web.Controllers;

[ApiController]
public class BanController : BaseController
{
    private readonly IRestrictionsService _restrictionsService;

    public BanController(IRestrictionsService restrictionsService) : base(EnumTypeResctriction.Ban)
    {
        _restrictionsService = restrictionsService;
    }

    [HttpGet]
    public async Task<BaseResponse> GetBannedUser(GetBannedUserRequest request)
    {
        
    }

    [HttpPost]
    public async Task<BaseResponse> SetUserBan(SetUserBanRequest request)
    {

    }

    [HttpDelete]
    public async Task<BaseResponse> RemoveBanUser(RemoveBanUserRequest request)
    {

    }
}