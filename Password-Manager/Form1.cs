using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        private static List<AccountData> accounts = new List<AccountData>();
        public Form1()
        {
            InitializeComponent();
        }
        private string GenerateSalt()
        {
            string salt = "";
            RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[1024];
            random.GetBytes(buffer);
            salt = BitConverter.ToString(buffer);
            return salt;
        }

        private static void GenerateKeyandIV(string password, string salt, int keySize, int blockSizeBits,ref byte[] key, ref byte[] IV)
        {
            byte[] saltByte = Encoding.Unicode.GetBytes(salt);
            Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, saltByte, 513);
            key = deriveBytes.GetBytes(keySize / 16);
            IV = deriveBytes.GetBytes(blockSizeBits / 8);
        }

        private static string Encrypter(string plainText, byte[] key, byte[] IV)
        {
            byte[] encrypted;
            using (AesManaged aes = new AesManaged())
            {
                aes.Padding = PaddingMode.Zeros;
                aes.Key = key;
                aes.IV = IV;
                ICryptoTransform encrypter = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encrypter, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Encoding.Unicode.GetString(encrypted);
        }

        private void ScreenUpdate()
        {
            ltBxAccounts.Items.Clear();
            for (int i = 0; i < accounts.Count(); i++)
            {
                ltBxAccounts.Items.Add(accounts[i].accountName);
            }
        }
        
        private void AddAccount()
        {
            AesCryptoServiceProvider aes_provider = new AesCryptoServiceProvider();
            AccountData AD = new AccountData();
            AD.accountName = txtBxAccountName.Text;
            AD.accountEmail = txtBxAccountEmail.Text;
            AD.accountSalt = GenerateSalt();

            int keySizeBits = 0;
            for (int i = 1024; i >= 1; i--)
            {
                if (aes_provider.ValidKeySize(i))
                {
                    keySizeBits = i;
                    break;
                }
            }
            Debug.Assert(keySizeBits > 0);
            int blockSizeBits = aes_provider.BlockSize;
            byte[] key = null;
            byte[] IV = null;
            GenerateKeyandIV(txtBxMasterPassword.Text, AD.accountSalt, keySizeBits, blockSizeBits, ref key, ref IV);
            AD.accountEncryptedPassword = Encrypter(txtBxAccountPassword.Text, key, IV);
            accounts.Add(AD);
            ScreenUpdate();
        }
        private string Decryptor(string strCipherText, byte[] key, byte[] iv)
        {
            string plaintext = null;
            byte[] byteCipherText = Encoding.Unicode.GetBytes(strCipherText);
            using (AesManaged aes = new AesManaged())
            {
                aes.Padding = PaddingMode.Zeros;
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream msDecrypt = new MemoryStream(byteCipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private void ShowData()
        {
            AesCryptoServiceProvider aes_provider = new AesCryptoServiceProvider();
            int index = ltBxAccounts.SelectedIndex;
            AccountData AD = new AccountData();
            AD = accounts[index];


            int keySizeBits = 0;
            for (int i = 1024; i >= 1; i--)
            {
                if (aes_provider.ValidKeySize(i))
                {
                    keySizeBits = i;
                    break;
                }
            }
            Debug.Assert(keySizeBits > 0);
            int blockSizeBits = aes_provider.BlockSize;
            byte[] key = null;
            byte[] IV = null;
            GenerateKeyandIV(txtBxMasterPassword.Text, AD.accountSalt, keySizeBits, blockSizeBits, ref key, ref IV);
            string password = Decryptor(AD.accountEncryptedPassword, key, IV);

            MessageBox.Show("Name: " + AD.accountName + "\nEncryptred : " + AD.accountEncryptedPassword + "\nSalt: " + AD.accountSalt + "\nDecrypted: " + password);
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            AddAccount();
            
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
    public class AccountData
    {

        public string accountName;
        public string accountEmail;
        public string accountEncryptedPassword;
        public string accountSalt;
    }

}
