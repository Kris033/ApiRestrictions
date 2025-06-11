using Microsoft.AspNetCore.Mvc;
using Walkiria.Restricitons.Web.Models.Mutes;
using Walkiria.Restrictions.DataContext.Enums;
using Walkiria.Restrictions.Interfaces;
using Walkiria.Restrictions.Interfaces.Dtos;
using Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

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
        var response = await _restrictionsService.GetRestrictions(
            new GetRestrictionsRequest
            {
                UserTgId = request.UserTgId,
                GroupTgId = request.GroupTgId,
                TypeResctriction = _typeResctriction
            });
        return new GetMutedUserResponse
        {
            Items = response.Items.Select(x => new GetMutedUserListItem
            {
                Reason = x.Reason,
                RemainingDateTimeMuted = x.DateEnd - DateTime.UtcNow
            }).ToList(),
            ErrorMessage = response.ErrorMessage
        };
    }

    [HttpPost]
    public async Task<BaseResponse> SetUserMute(SetUserMuteRequest request)
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
    public async Task<BaseResponse> RemoveMuteUser(RemoveMuteUserRequest request)
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
