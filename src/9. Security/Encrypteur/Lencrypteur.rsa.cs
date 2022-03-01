using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace Encrypteur
{
    internal partial class Lencrypteur
    {
        #region Clé NSA, ne pas ouvrir
        private string _cert = @"THE KEY";
        #endregion

        public byte[] EncryptRsa(string textToEncrypt)
        {
            var byteConverter = new UnicodeEncoding();
            var bytesToEncrypt = byteConverter.GetBytes(textToEncrypt);

            using RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(2048);
            cryptoServiceProvider.ImportFromPem(_cert.ToArray());

            var privateBytes = cryptoServiceProvider.ExportRSAPrivateKey();
            var publicBytes = cryptoServiceProvider.ExportRSAPublicKey();

            var privateKeyString = Convert.ToBase64String(privateBytes);
            var publicKeyString = Convert.ToBase64String(publicBytes);

            var encryptBytes = cryptoServiceProvider.Encrypt(bytesToEncrypt, true);

            return encryptBytes;
        }

        public string DecryptRsa(byte[] bytesToDecrypt)
        {
            using RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(2048);
            cryptoServiceProvider.ImportFromPem(_cert.ToArray());

            var decryptBytes = cryptoServiceProvider.Decrypt(bytesToDecrypt, true);

            return Encoding.Unicode.GetString(decryptBytes);
        }
    }
}
