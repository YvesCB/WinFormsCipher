using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCipher
{
    internal interface IEncryptDecrypt
    {
        string Encrypt(string plainText, string key);
        string Decrypt(string cipherText, string key);
    }
}
