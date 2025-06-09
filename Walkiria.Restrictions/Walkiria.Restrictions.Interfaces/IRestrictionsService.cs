using Walkiria.Restrictions.Interfaces.Dtos;
using Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

namespace Walkiria.Restrictions.Interfaces;

public interface IRestrictionsService
{
    Task<GetRestrictionsResponse> GetRestrictions(GetRestrictionsRequest request);

    Task<BaseResponse> SetRestriction(SetRestrictionRequest request);

    Task<BaseResponse> RemoveRestrictions(RemoveRestrictionsRequest request);
}