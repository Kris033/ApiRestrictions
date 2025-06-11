using Microsoft.AspNetCore.Mvc;
using Walkiria.Restricitons.Web.Models.Warns;
using Walkiria.Restrictions.DataContext.Enums;
using Walkiria.Restrictions.Interfaces;
using Walkiria.Restrictions.Interfaces.Dtos;
using Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

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
        var response = await _restrictionsService.GetRestrictions(
            new GetRestrictionsRequest
            {
                UserTgId = request.UserTgId,
                GroupTgId = request.GroupTgId,
                TypeResctriction = _typeResctriction
            });
        return new GetWarnsUserResponse
        {
            Items = response.Items.Select(x => new GetWarnsUserListItem
            {
                Reason = x.Reason,
                RemainingDateTimeWarned = x.DateEnd - DateTime.UtcNow
            }).ToList(),
            ErrorMessage = response.ErrorMessage
        };
    }

    [HttpPost]
    public async Task<BaseResponse> SetUserWarn(SetUserWarnRequest request)
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
    public async Task<BaseResponse> RemoveWarnUser(RemoveWarnUserRequest request)
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
