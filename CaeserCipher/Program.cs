using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string encryptMessage = "";
            //Ask user for secret message
            Console.WriteLine("Enter the message:");
            string message = Console.ReadLine().ToLower();
            //Convert this string to char array
            char[] secretMessage = message.ToCharArray();
            int msglength = secretMessage.Length;
            //Character array to hold encrypted message
            char[] encryptedMessage = new char[msglength];

            //Encryption of message
            for (int i = 0; i < msglength; i++)
            {
                char c = secretMessage[i];
                int pos = Array.IndexOf(alphabet, c);
                int newPos = (pos + 3) % 26;
                //get the encrypted char with newPos
                char e = alphabet[newPos];
                encryptedMessage[i] = e;
                //Convert char array to string
                encryptMessage = String.Join("", encryptedMessage);

            }
            Console.WriteLine(encryptMessage);
            Console.ReadLine();
        }
    }
}
/* TO_DO:
Rewrite the loop as a method Encrypt() which takes a character array and key and returns an encrypted character array .
Write a Decrypt() method which takes a character array and key and returns a decrypted character array.*/
