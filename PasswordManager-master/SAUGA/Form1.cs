using Scrypt;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SAUGA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            regpass.PasswordChar = '*';
            passtxt.PasswordChar = '*';
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            ScryptEncoder encoder = new ScryptEncoder();
            string hashsedPassword = encoder.Encode(regpass.Text);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\users.txt", true))
            {
                sw.WriteLine(reguser.Text + "," + hashsedPassword);
            }

            FileStream fs = File.Create(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\" + reguser.Text + ".txt");

            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            string[] str = File.ReadLines(@"C:\Users\Game PC\Desktop\PasswordManager-master\SAUGA\users.txt").ToArray(); ;
            
            string[] lineValues = new string[] { };

            foreach (var li in str)
            {
                if (li.Contains(usertxt.Text))
                {
                    lineValues = li.Split(',');
                    Console.WriteLine(lineValues[1]);
                    Console.WriteLine(lineValues[0]);
                }
            } 
            ScryptEncoder encoder = new ScryptEncoder();
          
            bool areEquals = encoder.Compare(passtxt.Text, lineValues[1]);
            Console.WriteLine(areEquals);

            if (areEquals == true)
            {
                Console.WriteLine("user exists");
                this.Hide();
                form f2 = new form(usertxt.Text);
                f2.Show();
            }
            else if (areEquals == false)
            {
                MessageBox.Show("this user doesnt exist");
            }
        }
    }
}
