using Microsoft.AspNetCore.Mvc;
using Walkiria.Restrictions.DataContext.Enums;

namespace Walkiria.Restricitons.Web.Controllers;

[Route("api/v0.1/[controller]/[action]")]
[ApiController]
public class BaseController : ControllerBase
{
    public BaseController(EnumTypeResctriction typeResctriction)
    {
        _typeResctriction = typeResctriction;
    }

    protected readonly EnumTypeResctriction _typeResctriction;
}