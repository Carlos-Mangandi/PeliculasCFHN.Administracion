using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Peliculas.AdministracionBlazor.Auth
{
    public class Utilities
    {
        //GenerateMD5
        public static string GenerateMD5(string str)
        {
            string hashed;
            using (MD5 md5 = MD5.Create())
            {
                hashed = string.Join(string.Empty, md5.ComputeHash(Encoding.UTF8.GetBytes(str)).Select(b => b.ToString("x2")));
            }
            return hashed;
        }

        
    }
}
