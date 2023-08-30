using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers;
[ApiController, Route("api/[controller]")]
public class MemberController : BaseController
{
    public MemberController(SiteProvider provider) : base(provider){}

    public List<Member> Get(){
        return provider.Member.GetMembers();
    }
}