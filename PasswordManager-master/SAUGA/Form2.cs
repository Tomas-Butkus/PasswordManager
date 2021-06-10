using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace SAUGA
{
    public partial class form : Form
    {
        public string username;
        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
        public form(string user)
        {
            InitializeComponent();
            username = user;
            logged.Text = user;
            listView1.FullRowSelect = true;

            if (new FileInfo(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + username + ".txt").Length == 0)
            {
                return;
            }
            else
            {

                string fileEncrypted = @"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + username + ".txt";
                string password = "abcd1234";

                byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

                byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

                File.WriteAllBytes(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + username + ".txt", bytesDecrypted);
            }

        }

        public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + username + ".txt";
            string password = "abcd1234";

            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            File.WriteAllBytes(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + username + ".txt", bytesEncrypted);

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        public static string Encrypt(string originalString)
        {
            if (String.IsNullOrEmpty(originalString))
            {
                throw new ArgumentNullException
                       ("The string which needs to be encrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        public static string Decrypt(string cryptedString)
        {
            if (String.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException
                   ("The string which needs to be decrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream
                    (Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }


        private void createbtn_Click_1(object sender, EventArgs e)
        {
            string cryptedPass = Encrypt(newpass.Text);
            Console.WriteLine("\nEncrypt Result: {0}", cryptedPass);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + username + ".txt", true))
            {
                sw.WriteLine(newname.Text + "," + cryptedPass + "," + newurl.Text + "," + newcomm.Text);
            }

            newname.Clear();
            newpass.Clear();
            newurl.Clear();
            newcomm.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newpass.Text = Guid.NewGuid().ToString();

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            List<string> data = File.ReadAllLines(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + username + ".txt").ToList();
            foreach (string d in data)
            {

                if (d.StartsWith(searchtxt.Text))
                {

                    string[] items = d.Split(new char[] { ',' },
                       StringSplitOptions.RemoveEmptyEntries);
                    listView1.Items.Add(new ListViewItem(items));
                }
            }

        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            string selectedpass = listView1.SelectedItems[0].SubItems[1].Text;

            string decryptedPass = Decrypt(selectedpass);

            Clipboard.SetText(decryptedPass);
            MessageBox.Show("Copied!");
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string selectedname = listView1.SelectedItems[0].SubItems[0].Text;
            string selectedpass = listView1.SelectedItems[0].SubItems[1].Text;
            string selectedurl = listView1.SelectedItems[0].SubItems[2].Text;
            string selectedcomm = listView1.SelectedItems[0].SubItems[3].Text;

            File.WriteAllLines(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + username + ".txt", File.ReadAllLines(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + username + ".txt").Where(line => !line.Contains(selectedname) && !line.Contains(selectedpass)));

            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
                MessageBox.Show("Deleted!");
                listView1.Refresh();

            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            string selectedname = listView1.SelectedItems[0].SubItems[0].Text;
            string selectedpass = listView1.SelectedItems[0].SubItems[1].Text;
            string selectedurl = listView1.SelectedItems[0].SubItems[2].Text;
            string selectedcomm = listView1.SelectedItems[0].SubItems[3].Text;

            Console.WriteLine(selectedname);
            Console.WriteLine(selectedpass);

            Form3 f3 = new Form3(username,selectedname, selectedpass,selectedurl,selectedcomm);
            f3.Show();
         
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
           string selectedpass = listView1.SelectedItems[0].SubItems[1].Text;
  
           string decryptedPass= Decrypt(selectedpass);
           listView1.SelectedItems[0].SubItems[1].Text = decryptedPass;
        }
    }
}
