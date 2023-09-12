using System.Security.Claims;

namespace BookShopAPI.Infrastructure.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal,string claimType)
        {
            var resultClaim = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();

            return resultClaim;
        }

        public static List<string> GetRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }

        public static string GetName(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Name).SingleOrDefault();
        }
    }
}