using System.Threading.Tasks;
using System;
using System.Security.Cryptography;
using System.Text;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonEncryptLucifer_Click(object sender, EventArgs e)
        {
            string result = await Task.Run(() => CryptoMethods.LuciferEncrypt());
            labelResultLucifer.Text = result;
        }

        private async void buttonHashN_Click(object sender, EventArgs e)
        {
            string result = await Task.Run(() => CryptoMethods.NHash());
            labelResultNHash.Text = result;
        }

        private async void buttonEncryptRSA_Click(object sender, EventArgs e)
        {
            string result = await Task.Run(() => CryptoMethods.RSAEncrypt());
            labelResultRSA.Text = result;
        }

        public class CryptoMethods
        {
            public static async Task<string> LuciferEncrypt()
            {
                // Приклад реалізації блокового алгоритму шифрування (LUCIFER)
                string plaintext = "Секретна інформація";
                byte[] key = Encoding.UTF8.GetBytes("Ключ шифрування");

                using (var rijAlg = new RijndaelManaged())
                {
                    rijAlg.GenerateKey();
                    rijAlg.KeySize = 256; // Встановлюємо розмір ключа в 256 біт
                    key = rijAlg.Key;

                    var encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                    byte[] encrypted;

                    // Приклад шифрування тексту
                    using (var msEncrypt = new System.IO.MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plaintext);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                    return Encoding.UTF8.GetString(encrypted);
                }
            }

            public static async Task<string> NHash()
            {
                // Приклад реалізації алгоритму хешування (N-Хэш)
                string plaintext = "Текст для хешування";

                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plaintext));

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }

            public static async Task<string> RSAEncrypt()
            {
                // Приклад реалізації алгоритму RSA
                string plaintext = "Текст для шифрування RSA";

                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plaintext);
                    byte[] encryptedData = rsa.Encrypt(dataToEncrypt, false);
                    return Convert.ToBase64String(encryptedData);
                }
            }
        }
    }
}
