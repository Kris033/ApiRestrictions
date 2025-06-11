using Microsoft.EntityFrameworkCore;
using Walkiria.Restrictions.DataContext;
using Walkiria.Restrictions.DataContext.Models;
using Walkiria.Restrictions.Interfaces;
using Walkiria.Restrictions.Interfaces.Dtos;
using Walkiria.Restrictions.Interfaces.Dtos.Restrictions;

namespace Walkiria.Restrictions.Services;

public class RestrictionsService(DbContextOptions<RestrictionDataContext> _options) : IRestrictionsService
{
    public async Task<GetRestrictionsResponse> GetRestrictions(GetRestrictionsRequest request)
    {
        try
        {
            await using var db = new RestrictionDataContext(_options);

            var restrictionsUser = await db.Restrictions.Where(x =>
                    x.UserTgId == request.UserTgId
                    && x.GroupTgId == request.GroupTgId
                    && x.TypeResctriction == request.TypeResctriction
                    && x.DateEnd > DateTime.UtcNow)
                .Select(x => 
                    new GetRestrictionsListItem
                    {
                        DateEnd = x.DateEnd,
                        Reason = x.Reason
                    })
                .ToListAsync();

            return new GetRestrictionsResponse
            {
                Items = restrictionsUser
            };
        }
        catch (Exception ex)
        {
            return new GetRestrictionsResponse { ErrorMessage = ex.Message };
        }
    }

    public async Task<BaseResponse> RemoveRestrictions(RemoveRestrictionsRequest request)
    {
        try
        {
            await using var db = new RestrictionDataContext(_options);

            var countDeleteRows = await db.Restrictions.Where(x => 
                    x.UserTgId == request.UserTgId 
                    && x.GroupTgId == request.GroupTgId
                    && x.TypeResctriction == request.TypeResctriction)
                .ExecuteDeleteAsync();

            if (countDeleteRows <= 0)
                throw new Exception($"У этого пользователя отсутствует данное ограничение");

            return new BaseResponse();
        }
        catch (Exception ex)
        {
            return new BaseResponse { ErrorMessage = ex.Message };
        }
    }

    public async Task<BaseResponse> SetRestriction(SetRestrictionRequest request)
    {
        try
        {
            await using var db = new RestrictionDataContext(_options);

            var restrictionUser = new Restriction
            {
                UserTgId = request.UserTgId,
                GroupTgId = request.GroupTgId,
                DateEnd = request.DateEnd,
                Reason = request.Reason,
                TypeResctriction = request.TypeResctriction
            };

            await db.Restrictions.AddAsync(restrictionUser);
            await db.SaveChangesAsync();

            return new BaseResponse();
        }
        catch (Exception ex)
        {
            return new GetRestrictionsResponse { ErrorMessage = ex.Message };
        }
    }
}