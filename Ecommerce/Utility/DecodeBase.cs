using System.Text;

namespace Ecommerce.Utility
{
    public static class DecodeBase
    {
        public static string DecodeBase64(string value)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(value));
        }
    }
}
