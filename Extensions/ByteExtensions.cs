using System.Collections;
using System.Numerics;
namespace Lab16.Extensions
{
    public static class ByteExtensions
    {
        public static BigInteger ToBigInteger(this byte[] bytes)
        {
            var bits = new BitArray(bytes);
            BigInteger number = 0;
            for (int bitCount = 0; bitCount < bits.Length; bitCount++)
            {
                number += bits[bitCount] ? BigInteger.Pow(2, bitCount) : 0;
            }
            return number;
        }
    }
}