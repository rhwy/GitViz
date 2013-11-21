using System.IO;
using Newtonsoft.Json;

namespace GitViz.Tests
{
    static class JsonExtensions
    {
        /// <summary>
        /// Converts object to JSON
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static string ToJson(this object value)
        {
            using (var stringWriter = new StringWriter())
            {
                var jsonSerializer = new JsonSerializer { NullValueHandling = NullValueHandling.Ignore };
                jsonSerializer.Serialize(stringWriter, value);
                return stringWriter.ToString().Replace("\"", "");
            }
        }
    }
}
