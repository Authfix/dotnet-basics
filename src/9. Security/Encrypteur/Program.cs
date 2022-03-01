using Encrypteur;
using System.Security.Cryptography;

Console.WriteLine("Begin program");

var lencrypter = new Lencrypteur();
var encryptedHelloWorld = lencrypter.EncryptAes("Hello World !");

var validDecrypt = lencrypter.DecryptAes(encryptedHelloWorld);

try
{
    var lencrypter2 = new Lencrypteur("THE KEY");
    var decryptedHelloWorld = lencrypter2.DecryptAes(encryptedHelloWorld);

}
catch (CryptographicException e)
{
    Console.WriteLine(e.Message);
}

var encryptRsaHelloWorld = lencrypter.EncryptRsa("Hello World !");
var decryptRsaHelloWorld = lencrypter.DecryptRsa(encryptRsaHelloWorld);

    Console.WriteLine(encryptedHelloWorld);