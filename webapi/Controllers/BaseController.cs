using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers;

public abstract class BaseController : ControllerBase
{
    protected SiteProvider provider;
    public BaseController(SiteProvider provider) => this.provider = provider;
}