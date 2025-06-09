using Microsoft.EntityFrameworkCore;
using Walkiria.Restrictions.DataContext;
using Walkiria.Restrictions.Interfaces;
using Walkiria.Restrictions.Interfaces.Dtos;
using Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

namespace Walkiria.Restrictions.Services;

public class RestrictionsService(DbContextOptions<RestrictionDataContext> _options) : IRestrictionsService
{
    public async Task<GetRestrictionsResponse> GetRestrictions(GetRestrictionsRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<BaseResponse> RemoveRestrictions(RemoveRestrictionsRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<BaseResponse> SetRestriction(SetRestrictionRequest request)
    {
        throw new NotImplementedException();
    }
}