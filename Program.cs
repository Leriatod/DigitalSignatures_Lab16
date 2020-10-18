using System;
using Lab16.ElectronicSignature;
using System.Numerics;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            RsaSignature rsaSignature  = new RsaSignature();
            DsaSignature dsaSignature  = new DsaSignature();
            GostSignature gostSignature = new GostSignature();

            // RSA 

            // string text = "Geralt of Rivia was a legendary witcher of the School of the Wolf active throughout the 13th century.";
            // string text = "In cryptography, a cipher (or cypher) is an algorithm for performing encryption or decryption—a series of well-defined steps that can be followed as a procedure.";
            
            // var text = 26;
            // var signature = rsaSignature.SignText(text);
            // bool verified = rsaSignature.VerifyText(text, signature);

            // Console.WriteLine("Text: {0}", text);
            // Console.WriteLine();
            // Console.WriteLine("Signature: {0}", signature);
            // Console.WriteLine();

            // Console.WriteLine("Text to verify: {0}", text);
            // Console.WriteLine();
            // Console.WriteLine("Signature: {0}", signature);
            // Console.WriteLine();
            // Console.WriteLine("Verified: {0}", verified? "Yes": "No");
            

            // DSA

            //var signature = dsaSignature.SignText(83);
            //Console.WriteLine("Hash is {0}", 17);
           // Console.WriteLine();
            // Console.WriteLine("Signature: ({0}, {1})", signature[0], signature[1]);
            // Console.WriteLine();
            // Console.WriteLine("Open key Y: {0}", dsaSignature.Y);

            // Console.WriteLine("Hash: {0}", 13);
            // Console.WriteLine("Signature: ({0}, {1})", 16, 23);
            // Console.WriteLine("Verified: {0}", dsaSignature.VerifyText(5, 16, 23)? "Yes": "No");

            // GOST 
           // (1; 3, 5), (1; 4, 3), (1; 4, 5)
           //(7; 7, 4), (7; 9, 2), (5; 9, 2)
           // (10; 7, 3), (7; 7, 10), (8; 7, 5)
            BigInteger text = 5;
            BigInteger r = 9;
            BigInteger s = 2;
            Console.WriteLine("Text: {0}", text);
            Console.WriteLine("Signature: ({0}, {1})", r, s);
            Console.WriteLine("Open key Y: {0}", 40);

            Console.WriteLine("Verified: {0}", gostSignature.VerifyText(text, r, s)? "Yes": "No");


            // BigInteger text = 5;
            // Console.WriteLine("Text: {0}", text);

            // BigInteger[] signature = gostSignature.SignText(text);
            // Console.WriteLine("Signature: ({0}, {1})", signature[0], signature[1]);
            // Console.WriteLine("Open Key Y: {0}", gostSignature.Y);


            Console.ReadLine();
        }
    }
      
}
