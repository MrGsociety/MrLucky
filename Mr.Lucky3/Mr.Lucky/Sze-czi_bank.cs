using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Net;


namespace Mr.Lucky
{
    public partial class Sze_czi_bank : Form
    {
        public Sze_czi_bank()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keydata)
        {
            if (keydata == (Keys.Alt | Keys.F4))
            {
                MessageBox.Show("Használd a 'Kilépés' gombot", "ALT+F4 észlelve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keydata);
        }
        static MySqlConnection connection;
        static string server;
        static string database;
        static string uid;
        static string password;
        static string reg_firstname, reg_lastname, reg_email, reg_password;
        public string path = @"C:\Users\Public\Mr.Lucky\user_data.txt";
        public string log_path = @"C:\Users\Public\Mr.Lucky\everything.log";
        static int money = 0;
        static int bank_money = 0;
        static int zsnyetony = 0;
        static int lvllistener = 1;
        List<string> log = new List<string>();
        static string myIp;
        static string accountnumber;
        private void Sze_czi_bank_Load(object sender, EventArgs e)
        {
            register_btn.Enabled = false;
            string[] log_data = File.ReadAllLines(log_path);
            foreach (var item in log_data)
            {
                log.Add(item);
            }
            File.WriteAllLines(log_path, log);
            string hostName = Dns.GetHostName();
            myIp = Dns.GetHostByName(hostName).AddressList[0].ToString();
            MessageBox.Show(myIp);
            server = "remotemysql.com";
            database = "iVn5Bs3UhN";
            uid = "iVn5Bs3UhN";
            password = "dBKiSzLMdR";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            
            try
            {
                connection.Open();
                string select_query = "SELECT * FROM `Mr_Lucky_bank`";
                MySqlCommand cmd = new MySqlCommand(select_query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);                
            }
            connection.Close();
            
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            log.Add("A program " + DateTime.Now + " kor bezáródott.");
            File.WriteAllLines(log_path, log);
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (firstname_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet üres a Vezetéknév...", "Hiányos adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_btn.Enabled = false;
            }
            else if (secondname_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet üres a Keresztnév...", "Hiányos adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_btn.Enabled = false;
            }
            else if (email_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet üres az Email...", "Hiányos adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_btn.Enabled = false;
            }
            else if (password_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet üres a Jelszó...", "Hiányos adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_btn.Enabled = false;
            }
            else if (password2_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet üres a Jelszó ellenörzés...", "Hiányos adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_btn.Enabled = false;
            }
            else if (!(password_txtb.Text == password2_txtb.Text))
            {
                MessageBox.Show("Nem egyezik a két jelszó...", "Helytelen jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_txtb.Clear();
                password2_txtb.Clear();
                register_btn.Enabled = false;
            }
            else
            {
                register_btn.Enabled = true;
            }
        }
        static string bank_email, email_email_xD;
        private void register_btn_Click(object sender, EventArgs e)
        {
            int anya;
            Random rnd = new Random();
            int[] mothers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                anya = rnd.Next(10000, 99999);
                mothers[i] = anya;
            }
            accountnumber = mothers[0].ToString() + "-" + mothers[1].ToString() + "-" + mothers[2].ToString() + "-" + mothers[3].ToString();
            MessageBox.Show(accountnumber);
            reg_email = email_txtb.Text;
            reg_firstname = firstname_txtb.Text;
            reg_lastname = secondname_txtb.Text;
            reg_email = email_txtb.Text;
            reg_password = password_txtb.Text;
            server = "remotemysql.com";
            database = "iVn5Bs3UhN";
            uid = "iVn5Bs3UhN";
            password = "dBKiSzLMdR";
            string connectionString2;
            connectionString2 = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection connection2 = new MySqlConnection(connectionString2);            
            string insert_query = "INSERT INTO `Mr_Lucky_bank`(`email`, `ip_adress`, `computer_name`, `first_name`, `second_name`, `password`, `bank_number`, `bank_money`, `creation_date`, `last_login_date`) VALUES ('" +reg_email+ "','" + myIp + "','" + System.Environment.MachineName + "','" + reg_firstname + "','" + reg_lastname + "','" + password + "','" + accountnumber + "','" + bank_money.ToString() + "','"+DateTime.Now.ToString()+"','"+DateTime.Now.ToString()+"')";
            try
            {
                connection2.Open();
                MySqlCommand cmd2 = new MySqlCommand(insert_query, connection2);
                cmd2.ExecuteNonQuery();
                log.Add("Sikeresen létrehoztad első bankfiókodat " + DateTime.Now + " kor");
                connection.Close();
                string check_email_query = "SELECT `email` FROM `Mr_Lucky_email` WHERE `email` = '" + reg_email + "'";
                connection.Open();
                MySqlCommand bank_email_vaildation_cmd = new MySqlCommand(check_email_query, connection);
                MySqlDataReader datarider = bank_email_vaildation_cmd.ExecuteReader();
                while (datarider.Read())
                {
                    email_email_xD = datarider[0].ToString();
                }
                connection.Close();
                connection.Open();
                string check_email_in_bank = "SELECT `email` FROM `Mr_Lucky_bank` WHERE `email` = '" + reg_email + "'";
                MySqlCommand bank_email_vaildation_in_bank_cmd = new MySqlCommand(check_email_in_bank, connection);
                MySqlDataReader datarider_from_bank = bank_email_vaildation_in_bank_cmd.ExecuteReader();
                while (datarider_from_bank.Read())
                {
                    bank_email = datarider_from_bank[0].ToString();
                }
                connection.Close();
                if (!(email_email_xD == bank_email))
                {
                    MessageBox.Show("Nincs ilyen email cím a rendszerben. Vagy elgépelted, vagy még nem hoztál létre egyet.", "Fiókod törlésre került...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string delete_query = "DELETE FROM `Mr_Lucky_bank` WHERE email = '" + reg_email + "'";
                    try
                    {
                        connection.Open();
                        MySqlCommand juhuigen = new MySqlCommand(delete_query, connection);
                        juhuigen.ExecuteNonQuery();                        
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                log.Add(ex.Message);
            }
        }
    }
}