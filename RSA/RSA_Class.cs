using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    public class RSA_Class
    {
        BigInteger firstSimple;
        BigInteger secondSimple;

        public bool Test_Miller(BigInteger n, int k)
        {
            if (n == 2 || n == 3)
                return true;

            if (n < 2 || n % 2 == 0)
            {
                return false;
            }

            BigInteger d = n - 1;

            int s = 0;

            while(d % 2 == 0)
            {
                d /= 2;
                s++;
            }
            
            for(int i = 0; i < k; i++)
            {
                RandomNumberGenerator rng1 = RandomNumberGenerator.Create();
                //RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] _a = new byte[n.ToByteArray().LongLength];

                BigInteger a;
                do
                {
                    rng1.GetBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a > n - 2);
                
                BigInteger x = BigInteger.ModPow(a, d, n);
                
                if (x == 1 || x == n - 1)
                    continue;

                for (int ls = 1; ls < s; ls ++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }
                if (x != n - 1)
                    return false;
            }

            return true;
        }
        public int e_find(int n, int phiN)
        {
            int e;
            do
            {
                e = RandomNumberGenerator.GetInt32(2, phiN); // Генерируем случайное число в диапазоне (2, Ф(n))
            } while (!Is_e_(e, phiN)); // Проверяем взаимную простоту

            return e;
        }
        static bool Is_e_(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a == 1;
        }


        static int ExtendedGCD(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int x1, y1;
            int gcd = ExtendedGCD(b % a, a, out x1, out y1);

            x = y1 - (b / a) * x1;
            y = x1;

            return gcd;
        }

        public int ModInverse(int e, int phiN)
        {
            int x, y;
            int gcd = ExtendedGCD(e, phiN, out x, out y);

            if (gcd != 1)
            {
                throw new Exception("Обратное число не существует, так как числа не взаимно просты.");
            }

            //int d = x % phiN;
            //return d;
            x = (x % phiN + phiN) % phiN;
            return x;
        }

        // Функция для шифрования блока mi
        public BigInteger Encrypt(long mi, long e, long n)
        {
            return BigInteger.ModPow(mi, e, n);
        }

        // Функция для дешифрования блока ci
        public BigInteger Decrypt(long ci, long d, long n)
        {
            return BigInteger.ModPow(ci, d, n);
        }

    }
}
