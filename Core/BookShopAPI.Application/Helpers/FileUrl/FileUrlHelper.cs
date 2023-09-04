namespace BookShopAPI.Application.Helpers.FileUrl
{
    public static class FileUrlHelper
    {
        public static string Generate(string basePath, string fileName)
        {
            if (basePath == null || fileName == null)
                return string.Empty;

            int index = basePath.LastIndexOf("wwwroot");
            string newPath = basePath.Remove(0, index + 8);
            string url = "https://localhost:7297/" + newPath + "/" + fileName;

            return url;
        }

        public static string Generate(string filePath)
        {
            if (filePath == null)
                return string.Empty;

            int index = filePath.LastIndexOf("wwwroot");
            string newPath = filePath.Remove(0, index + 8);
            string url = "https://localhost:7297/" + newPath;

            return url;
        }
    }
}