using System.Numerics;
namespace Lab16.Extensions
{
    public static class BigIntExtensions
    {
        public static BigInteger ModInverse(this BigInteger number, BigInteger prime)
        {
            number = number % prime; 
            BigInteger modInverse = -1;
            for (BigInteger i = 1; i < prime; i++) 
            {
                if ((number * i) % prime == 1)
                {
                    modInverse = i;
                    break;
                }     
            }
            return modInverse; 
        }
    }
}