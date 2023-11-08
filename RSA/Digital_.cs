using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    public class Digital_
    {
        public BigInteger GetHash(string input_str)
        {
            var md5 = MD5.Create();
            // Вычисление хеша
            byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input_str));
            return new BigInteger(hashBytes);

        }
    }
}
