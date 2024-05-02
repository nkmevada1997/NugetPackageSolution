using System.Text;

namespace Ecommerce.Utility
{
    public static class EncodeBase
    {
        public static string EncodeBase64(string value)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
        }
    }
}
