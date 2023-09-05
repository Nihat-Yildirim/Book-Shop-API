using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.Validators
{
    public static class CommonRules
    {
        public static bool CheckPictureExtension(IFormFile file)
        {
            List<string> extensions = new()
            {
                ".jpg",
                ".jpeg",
                ".png",
            };

            if (extensions.Contains(Path.GetExtension(file.FileName)))
                return true;

            return false;
        }
    }
}
