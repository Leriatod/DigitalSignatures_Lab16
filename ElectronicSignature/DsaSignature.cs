using System.Numerics;
using Lab16.Extensions;

namespace Lab16.ElectronicSignature
{
    public class DsaSignature
    {
        public BigInteger P => 271;
        public BigInteger Q => 27;
        public BigInteger Y => 160; //BigInteger.ModPow(g, x, P);

        private readonly BigInteger k = 13;
        private readonly BigInteger x = 8;
        private readonly BigInteger g = 217;
        

        public BigInteger[] SignText(BigInteger text)
        {
            BigInteger hash = 17;

            BigInteger r    = BigInteger.ModPow(g, k, P) % Q;
            BigInteger s    =  k.ModInverse(Q) * (hash + x * r ) % Q;

            return new BigInteger[] { r, s };
        }

        public bool VerifyText(BigInteger text, BigInteger r, BigInteger s)
        {
            BigInteger hash = 13;

            BigInteger w    = s.ModInverse(Q);
            int u1   = (int) ( hash * w % Q );
            int u2   = (int) ( r * w % Q );
            BigInteger v    = ( BigInteger.Pow(g, u1) * BigInteger.Pow(Y, u2) % P ) % Q;

            return v == r;
        }

    }
}