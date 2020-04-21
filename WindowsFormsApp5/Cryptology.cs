using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Cryptology
    {

       public static string Encryption(string text,int key)
        {
            char[] x = text.ToCharArray();
            string Encryptedtext = null;
            foreach (char item in x)
            {
                Encryptedtext += Convert.ToChar(item + key);
            }
            return Encryptedtext;
        }   


        public static string Decryption(string text,int key)
        {
            char[] x = text.ToCharArray();
            string decryptedtext = null;
            foreach (char item in x)
            {
                decryptedtext += Convert.ToChar(item + key);
            }
            return decryptedtext;
        }
    }
}
