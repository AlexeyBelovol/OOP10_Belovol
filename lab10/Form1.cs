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
                // ������� ��������� ��������� ��������� ���������� (LUCIFER)
                string plaintext = "�������� ����������";
                byte[] key = Encoding.UTF8.GetBytes("���� ����������");

                using (var rijAlg = new RijndaelManaged())
                {
                    rijAlg.GenerateKey();
                    rijAlg.KeySize = 256; // ������������ ����� ����� � 256 ��
                    key = rijAlg.Key;

                    var encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                    byte[] encrypted;

                    // ������� ���������� ������
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
                // ������� ��������� ��������� ��������� (N-���)
                string plaintext = "����� ��� ���������";

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
                // ������� ��������� ��������� RSA
                string plaintext = "����� ��� ���������� RSA";

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
