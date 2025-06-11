using Microsoft.AspNetCore.Mvc;
using Walkiria.Restricitons.Web.Models.Bans;
using Walkiria.Restrictions.DataContext.Enums;
using Walkiria.Restrictions.Interfaces;
using Walkiria.Restrictions.Interfaces.Dtos;
using Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

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
    public async Task<GetBannedUserResponse> GetBannedUser([FromRoute] GetBannedUserRequest request)
    {
        var response = await _restrictionsService.GetRestrictions(
            new GetRestrictionsRequest
            {
                UserTgId = request.UserTgId,
                GroupTgId = request.GroupTgId,
                TypeResctriction = _typeResctriction
            });
        return new GetBannedUserResponse
        {
            Items = response.Items.Select(x => new GetBannedUserListItem
            {
                Reason = x.Reason,
                RemainingDateTimeBanned = x.DateEnd - DateTime.UtcNow
            }).ToList(),
            ErrorMessage = response.ErrorMessage
        };
    }

    [HttpPost]
    public async Task<BaseResponse> SetUserBan(SetUserBanRequest request)
    {
        return await _restrictionsService.SetRestriction(
            new SetRestrictionRequest 
            { 
                UserTgId = request.UserTgId, 
                GroupTgId = request.GroupTgId,
                DateEnd = request.DateEnd, 
                Reason = request.Reason, 
                TypeResctriction = _typeResctriction
            });
    }

    [HttpDelete]
    public async Task<BaseResponse> RemoveBanUser(RemoveBanUserRequest request)
    {
        return await _restrictionsService.RemoveRestrictions(
            new RemoveRestrictionsRequest 
            { 
                UserTgId = request.UserTgId,
                GroupTgId = request.GroupTgId,
                TypeResctriction = _typeResctriction
            });
    }
}