using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCipher
{
    internal class Vigenere : IEncryptDecrypt
    {
        static string[] Characters =
            {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "ä", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "q", "r", "s", "t", "u", "ü", "v", "w", "x", "y", "z", "A", "Ä", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "Ö", "P", "Q", "R", "S", "T", "U", "Ü", "V", "W", "X", "Y", "Z", ",", ".", ";", ":", "'", "\"", "!", "?", "+", "-", " "};
        static int CharLen = Characters.Length;

        public string Decrypt(string cipherText, string key)
        {
            string plain = "";

            if (key.Length == 0) { return cipherText; }

            for (int i = 0; i < cipherText.Length; i++)
            {
                char cipherChar = cipherText[i];
                char keyChar = key[i % key.Length];

                int ciperIndex = Array.IndexOf(Characters, cipherChar.ToString());
                int keyIndex = Array.IndexOf(Characters, keyChar.ToString());

                if (ciperIndex == -1 || keyIndex == -1)
                {
                    throw new ArgumentException("All characters from the input strings must be in the char array. Cannot parse: " + cipherChar);
                }

                int plainIndex = (ciperIndex - keyIndex) % CharLen;

                if (plainIndex < 0)
                {
                    plainIndex += CharLen;
                }

                plain += Characters[plainIndex];
            }

            return plain;
        }

        public string Encrypt(string plainText, string key)
        {
            string cipher = "";

            if (key.Length == 0) { return plainText; }

            for (int i = 0; i < plainText.Length; i++)
            {
                char plainChar = plainText[i];
                char keyChar = key[i % key.Length];

                int plainIndex = Array.IndexOf(Characters, plainChar.ToString());
                int keyIndex = Array.IndexOf(Characters, keyChar.ToString());

                if (plainIndex == -1 || keyIndex == -1)
                {
                    throw new ArgumentException("All characters from the input strings must be in the char array. Cannot parse: " + plainChar);
                }

                int cipherIndex = (plainIndex + keyIndex) % CharLen;

                cipher += Characters[cipherIndex];
            }

            return cipher;
        }
    }
}
