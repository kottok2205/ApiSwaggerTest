namespace ApiSwaggerTest
{
    public class ResourceManage
    {
        public static string GetResource(string resourceName)
        {
            var assembly = typeof(BaseTest).Assembly;
            using (var stream = assembly.GetManifestResourceStream($"ApiSwaggerTest.Data.{resourceName}"))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
