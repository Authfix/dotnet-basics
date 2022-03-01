using System.Security.Cryptography;
using System.Text;

namespace Encrypteur
{
    internal partial class Lencrypteur
    {
        private readonly string _key;

        public Lencrypteur(string optionalKey = null)
        {
            _key = string.IsNullOrEmpty(optionalKey) ? "THE KEY" : optionalKey;
        }

        public string EncryptAes(string textToEncrypt)
        {
            byte[] result;
            byte[] iv = new byte[32];
            
            using(Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(_key);
                aes.IV = new byte[aes.BlockSize / 8];

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using(MemoryStream memoryStream = new MemoryStream())
                {
                    using(CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using(StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(textToEncrypt);
                        }

                        result = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(result);
        }

        public string DecryptAes(string textToDecrypt)
        {
            byte[] iv = new byte[16];
            byte[] textToDecryptArray = Convert.FromBase64String(textToDecrypt);

            using Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(_key);
            aes.IV = iv;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using MemoryStream memStream = new MemoryStream(textToDecryptArray);
            using CryptoStream cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read);
            using StreamReader streamReader = new StreamReader(cryptoStream);
                        
            return streamReader.ReadToEnd();
        }


    }
}
