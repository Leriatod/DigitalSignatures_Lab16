using System.Numerics;
using Lab16.Extensions;

namespace Lab16.ElectronicSignature
{
    public class GostSignature
    {
        public BigInteger Q => 11;
        public BigInteger P => 67;
        public BigInteger G => 25;


        public BigInteger Y => 40;//BigInteger.ModPow(G, x, P);

        private readonly BigInteger k = 5;
        private readonly BigInteger x = 9;

        public BigInteger[] SignText(BigInteger text)
        {
            BigInteger hash = text;

            BigInteger r = BigInteger.ModPow(G, k, P) % Q;
            BigInteger s = ( k * hash + x * r ) % Q;

            return new BigInteger[] { r, s };
        }

        public bool VerifyText(BigInteger text, BigInteger r, BigInteger s)
        {
            BigInteger hash = text;
            BigInteger hashModInverse = hash.ModInverse(Q);
            int z1 = (int) ( s * hashModInverse % Q );
            int z2 = (int) ( ( Q - r ) * hashModInverse % Q );
            BigInteger v = ( BigInteger.Pow(G, z1) * BigInteger.Pow(Y, z2) % P ) % Q;
            return r == v;
        }
    }
}