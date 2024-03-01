using System.Text.Json;

namespace SharedExtensions
{
    public static class ObjectExtension
    {
        public static T Clone<T>(this T source) =>
            JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(source));
    }
}
