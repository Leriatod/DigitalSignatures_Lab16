using System.Security.Cryptography;
using System.Numerics;
using System.Text;
using System;
using Lab16.Extensions;

namespace Lab16.ElectronicSignature
{
    public class RsaSignature
    {
        // p - some long prime number
        private readonly BigInteger p = 17;

        // q - some long prime number
        private readonly BigInteger q = 23;

        // d stands for signing messeges, d is mod inverse of e
        private readonly BigInteger d = 145;

        // Modulus ( mod n )
        public BigInteger N => BigInteger.Multiply(p, q); 

        // e stands for text verification, e is coprime to (p - 1) * (q - 1)
        public BigInteger E => 17;


        public BigInteger SignText(BigInteger text)
        {
            return BigInteger.ModPow(text, d, N);
        }

        public bool VerifyText(BigInteger text, BigInteger digitalSignature)
        {
            BigInteger hashFromSignature = BigInteger.ModPow(digitalSignature, E, N);
            return hashFromSignature == text;
        }
    }





    // p - some long prime number
    // private readonly BigInteger p = BigInteger.Parse("1187966442598120830372881");
    // // q - some long prime number
    // private readonly BigInteger q = BigInteger.Parse("903514052476711950812101");


    // // Modulus ( mod n )
    // public BigInteger N => BigInteger.Multiply(p, q); 

    // // d stands for signing messeges, d is mod inverse of e
    // private readonly BigInteger d = BigInteger.Parse("790878432901599019557702373099964116487832633473");


    // // e stands for text verification, e is coprime to (p - 1) * (q - 1)
    // public BigInteger E => 65537;

    // public BigInteger SignText(string text)
    // {
    //     BigInteger hashNumber = getHashNumberFromText(text);
    //     return BigInteger.ModPow(hashNumber, d, N);
    // }

    // public bool ConfirmText(string text, BigInteger digitalSignature)
    // {
    //     BigInteger hashFromSignature =  BigInteger.ModPow(digitalSignature, E, N);
    //     return hashFromSignature == getHashNumberFromText(text);
    // }

    // private BigInteger getHashNumberFromText(string text)
    // {
    //     byte[] hashBytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(text));        
    //     return hashBytes.ToBigInteger();
    // }
}