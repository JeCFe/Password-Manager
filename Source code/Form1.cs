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
using Newtonsoft.Json;
using System.Threading;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        private static List<AccountData> accounts = new List<AccountData>();
        delegate void GeneratedPasswordDelegate(string message);
        public Form1()
        {

            InitializeComponent();
            InitialiseList();
        }


        private void UpdateGeneratedPassword(string generatedPassword)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new GeneratedPasswordDelegate(UpdateGeneratedPassword), new object[] { generatedPassword });
            }
            else
            {
                txtNewPassword.Clear();
                txtNewPassword.Text = generatedPassword;
            }

        }
        private void InitialiseList()
        {
            try
            {
                using (StreamReader reader = new StreamReader("accounts.json"))
                {
                    string json = reader.ReadToEnd();
                    accounts = JsonConvert.DeserializeObject<List<AccountData>>(json);
                }
                ScreenUpdate();
            }
            catch
            {
                ltBxAccounts.Items.Add("No file found");
            }
        }
        private void WriteToFile()
        {
            using (StreamWriter writer = File.CreateText("accounts.json"))
            {
                JsonSerializer serialiser = new JsonSerializer();
                serialiser.Serialize(writer, accounts);
            }
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
            if (txtBxAccountName.Text != "" && txtBxAccountPassword.Text != "" && txtBxAccountEmail.Text != "")
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
                WriteToFile();
                ScreenUpdate();
                txtBxAccountName.Text = "";
                txtBxAccountEmail.Text = "";
                txtBxAccountPassword.Text = "";
            }
            else
            {
                MessageBox.Show("All fields must be entered", "ERROR");
            }
        }
        private void DeleteAccount()
        {
            try
            {
                AccountData AD;
                int index = ltBxAccounts.SelectedIndex;
                AD = accounts[index];
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Confirm Account Deletion: \nAccount name: " + AD.accountName + "\nEmail: " + AD.accountEmail, "Accounts Deletation", buttons);
                if (result == DialogResult.Yes)
                {
                    accounts.RemoveAt(index);
                    ScreenUpdate();
                    WriteToFile();
                }
                else
                {
                    MessageBox.Show("Account not removed");
                }
            }
            catch { }
         
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
            try
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

                MessageBox.Show("Account Details!\nAccount Name: " + AD.accountName + "\nAccount Email: " + AD.accountEmail + "\nAccount Password: " + password + "\nEncrypted Value: " + AD.accountEncryptedPassword, "Account Details!");
            }
            catch { }
        }
        private void PasswordGenerator()
        {
            Random random = new Random();
            int passwordLength = Decimal.ToInt32(numPasswordLength.Value);
            char[] lowercase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] uppercase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] special = { '!', '@', '-', '_', '/', '$', '£' };
            char[] charArray = { };

            string password = "";
            if (ckBxLowChars.Checked)
            {
                charArray = charArray.Concat(lowercase).ToArray();
            }
            if (ckBxUpperChar.Checked)
            {
               charArray = charArray.Concat(uppercase).ToArray();
            }
            if (ckBxNumbers.Checked)
            {
                charArray = charArray.Concat(numbers).ToArray();
            }
            if(ckBxSpecial.Checked)
            {
                charArray = charArray.Concat(special).ToArray();
            }
            for (int i = 0; i < passwordLength; i++)
            {
                int index = random.Next(charArray.Length);
                password += charArray[index];
            }
            UpdateGeneratedPassword(password);
        }




        private void btnAddAcc_Click(object sender, EventArgs e) { AddAccount(); }
        private void btnShowAccount_Click(object sender, EventArgs e) { ShowData(); }
        private void btnSave_Click(object sender, EventArgs e){ WriteToFile(); }
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            DeleteAccount();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Thread generator = new Thread(new ThreadStart(PasswordGenerator));
            generator.Start();
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
