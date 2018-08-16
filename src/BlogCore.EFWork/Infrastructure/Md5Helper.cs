using System;
using System.Security.Cryptography;
using System.Text;

namespace BlogCore.EFWork.Infrastructure
{
    public class Md5Helper
    {
        public static string Md5(string text)
        {
            var result = Encoding.Default.GetBytes(text);
            MD5 md5 = new MD5CryptoServiceProvider();
            var output = md5.ComputeHash(result);
            return BitConverter.ToString(output).ToUpper();
        }
    }
}
