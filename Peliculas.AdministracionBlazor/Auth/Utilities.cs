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

        public static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)//RESIVE EL PARAMETRO DE TOKEN
        {

            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];

            var jsonBytes = ParseBase64WithoutPadding(payload); //convierte lo que extrajimos de paylod

            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));//agregamos un rango de valores que mandamos a llamar con keyValueParis
            return claims;

        }

        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
