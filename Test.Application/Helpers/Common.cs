using Microsoft.Extensions.Configuration;
using System;
namespace Test.Application.Helpers
{
    public class Common
    {
        private readonly IConfiguration _configuration;
        public Common(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
    public static class TypeConverterExtension
    {
        public static byte[] ToByteArray(this string value) =>
        Convert.FromBase64String(value);
    }
}
