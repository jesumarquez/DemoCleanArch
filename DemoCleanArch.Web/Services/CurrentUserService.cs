using DemoCleanArch.Domain.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DemoCleanArch.Web.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            //this.UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            this.UserId = httpContextAccessor.HttpContext?.User?.Identity.Name;
        }
        public string UserId { get; }
    }
}
