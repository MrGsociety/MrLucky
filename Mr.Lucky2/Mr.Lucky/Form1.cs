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

namespace Mr.Lucky
{
    public partial class Mr_Lucky_main_menu : Form
    {
        public Mr_Lucky_main_menu()
        {
            InitializeComponent();
            register_btn.Enabled = false;
            login_btn.Enabled = false;
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
        public string path = @"C:\Users\Public\Mr.Lucky\user_data.txt";
        public string log_path = @"C:\Users\Public\Mr.Lucky\everything.log";
        List<string> log = new List<string>();
        static string reg_namenome, reg_password, log_namenome, log_password;
        static string[] password_hash = new string[200];
        static int money = 0;
        static int bank_money = 0;
        static int zsnyetony = 0;
        static int lvllistener = 1;


        private void exit_btn_Click(object sender, EventArgs e)
        {
            log.Add("A program " + DateTime.Now + " kor bezáródott.");
            File.WriteAllLines(log_path, log);
            Application.Exit();
        }

        private void Mr_Lucky_main_menu_Load(object sender, EventArgs e)
        {
            log.Add("------------------/| " + System.Environment.MachineName + @"  |\------------------");
            if (!(Directory.Exists(@"C:\Users\Public\Mr.Lucky")))
            {
                Directory.CreateDirectory(@"C:\Users\Public\Mr.Lucky");
                log.Add("Path sikeresen létrehozva " + DateTime.Now);
            }
            log.Add("Az alkalmazás elindúlt " + DateTime.Now+" kor.");
                File.WriteAllLines(log_path, log);
                computer_name_lbl.Text = System.Environment.MachineName;            
        }

        private void reg_rechapta_chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!(register_password.Text == register_password_again.Text))
            {
                MessageBox.Show("A két jelszó nem egyezik...", "Helytelen jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reg_rechapta_chbox.Checked == false)
            {
                register_btn.Enabled = false;
            }
            else
            {
                register_btn.Enabled = true;

            }
            if (!(File.Exists(path)))
            {
                string[] outp = { System.Environment.MachineName, DateTime.Now.ToString("yyyy-mm-dd") };
                File.WriteAllLines(path, outp);
                log.Add("Felhasználói fiók létrehozva " + DateTime.Now);
                File.WriteAllLines(log_path, log);
                File.GetAttributes(path);
            }
        }

        private void log_rechapta_chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (login_username.Text == "")
            {
                 MessageBox.Show("Nem lehet üres a felhasználónév", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (login_pasword.Text == "")
            {
                MessageBox.Show("Nem lehet üres a jelszó mező", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (log_rechapta_chbox.Checked == false)
            {
                login_btn.Enabled = false;
            }
            else
            {
                login_btn.Enabled = true;
            }
        }
        static MySqlConnection connection;
        static string server;
        static string database;
        static string uid;
        static string password;
        private void register_btn_Click(object sender, EventArgs e)
        {
            DirectoryInfo dc = new DirectoryInfo(path);
            dc.Attributes = FileAttributes.Normal;
            reg_namenome = Convert.ToString(register_username.Text);
            reg_password = Convert.ToString(register_password.Text);
            string[] user_data_i = File.ReadAllLines(path);
            if (reg_namenome == user_data_i[0])
            {
                MessageBox.Show("Ilyen nevű felhasználó már létezik. Kérlek adj meg egy másik felhasznáálónevet.", "Felhasználó már létezik.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_username.Clear();
            }
            else
            {
                register_password.MaxLength = 50;
                if (reg_password.Length > 50)
                {
                    MessageBox.Show("50 karatkernél NEM nagyobb jelszót írj be");
                }
                else
                {
                    if (!(Directory.Exists(@"C:\Users\Public\Blackjack")))
                    {
                        Directory.CreateDirectory(@"C:\Users\Public\Blackjack");
                    }
                    SHA1 sha = new SHA1CryptoServiceProvider();
                    string text = reg_password;
                    byte[] hashedData = sha.ComputeHash(Encoding.Unicode.GetBytes(text));
                    StringBuilder stringBuilder = new StringBuilder();
                    int i = 0;
                    foreach (byte b in hashedData)
                    {
                        stringBuilder.Append(String.Format("{0,2:X2}", b));
                        password_hash[i] = Convert.ToString(b);
                        i++;
                    }
                    string sh = string.Join("", password_hash);
                    string[] user_data_e = { reg_namenome, sh };
                    File.WriteAllLines(path, user_data_e);
                    DirectoryInfo hide = new DirectoryInfo(path);
                    hide.Attributes = FileAttributes.Hidden;
                    MessageBox.Show("" + reg_namenome + " sikeresen létrehozva!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    register_panel.Hide();
                    login_panel.Show();
                    log.Add(reg_namenome + " felhasználó sikeresen létrehozva " + DateTime.Now + " kor");
                    File.WriteAllLines(log_path, log);

                    server = "remotemysql.com";
                    database = "iVn5Bs3UhN";
                    uid = "iVn5Bs3UhN";
                    password = "dBKiSzLMdR";
                    string connectionString;
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    string query = "INSERT INTO Mr_Lucky (`computer_name`,`username`, `password`, `money`, `bank_money`, `lvllistener`, `creation_date`,`last_login`) VALUES('"+System.Environment.MachineName+"','" + reg_namenome + "','" + reg_password + "','" + money.ToString() + "','" + bank_money.ToString() + "','" + lvllistener.ToString() + "','" + DateTime.Now.ToString() + "','"+DateTime.Now.ToString() +"')";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Kérlek nézd meg a log file-t bővebb információért: "+log_path+"\n"+ex.Message);
                        File.Delete(path);
                        log.Add(reg_namenome + " nevü felhasználói fiók törölve, mivel ilyen név van már az adatbázisban. " + DateTime.Now);
                    }
                    connection.Close();
                }
            }
        }
        static int loggedin = 0;
        static string last_login;
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (!(File.Exists(path)))
            {
                MessageBox.Show("Elöbb regisztrálj!");
                login_panel.Hide();
            }
            else
            {
                DirectoryInfo dcc = new DirectoryInfo(path);
                dcc.Attributes = FileAttributes.Normal;
                string[] user_data_i = File.ReadAllLines(path);
                log_namenome = Convert.ToString(login_username.Text);
                log_password = Convert.ToString(login_pasword.Text);
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                string texty = log_password;
                byte[] hashedDatalog = sha1.ComputeHash(Encoding.Unicode.GetBytes(texty));
                StringBuilder stringBuilderL = new StringBuilder();
                string[] pswd_hsh = new string[200];
                int ei = 0;
                foreach (byte c in hashedDatalog)
                {
                    stringBuilderL.Append(String.Format("{0,2:X2}", c));
                    pswd_hsh[ei] = Convert.ToString(c);
                    ei++;
                }
                string sha = string.Join("", pswd_hsh);
                server = "remotemysql.com";
                database = "iVn5Bs3UhN";
                uid = "iVn5Bs3UhN";
                password = "dBKiSzLMdR";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(connectionString);
                connection.Open();

                string log_query = "SELECT `computer_name`,`username`,`password`,`creation_date`,`last_login` FROM `Mr_Lucky`";
                MySqlCommand cmd = new MySqlCommand(log_query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();                
                List<string> sql_uname = new List<string>();
                List<string> sql_password = new List<string>();
                while (dataReader.Read())
                {
                    if (dataReader[1].ToString() == log_namenome && dataReader[2].ToString() == log_password)
                    {
                        last_login = "UPDATE `Mr_Lucky` SET `last_login` = '"+DateTime.Now.ToString()+"' WHERE `username` ='"+log_namenome+"'";
                        MessageBox.Show("Sikeres bejelentkezés", "Engedélyezve", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        log.Add("Sikeres bejelentkezés az adatbázisba " + log_namenome + " néven " + DateTime.Now + " kor");
                        loggedin = 0;
                        break;
                    }
                    else
                    {
                        loggedin = 2;
                    }
                }
                if (loggedin == 2)
                {
                    MessageBox.Show("Helytelen felhasználónév/jelszó", "Nem engedélyezett belépés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    login_username.Clear();
                    login_pasword.Clear();
                    loggedin = 0;
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    MySqlCommand last_login_cmd = new MySqlCommand(last_login, connection); 
                    last_login_cmd.ExecuteNonQuery();
                    connection.Close();
                    File.WriteAllLines(log_path, log);
                    dcc.Attributes = FileAttributes.Hidden;
                    loggedin = 1;
                    dataReader.Close();
                    connection.Close();
                    lvlchoose lvlchoose = new lvlchoose();
                    this.Hide();
                    lvlchoose.Show();
                }
                /*if (!(user_data_i[0] == log_namenome))
                {
                    MessageBox.Show("Helytelen felhasználónév", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    login_username.Clear();
                }
                else if (!(user_data_i[1] == sha))
                {
                    MessageBox.Show("Helytelen jelszó", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    login_pasword.Clear();
                }
                else 
                if (!(sql_uname.Contains(log_namenome)))
                {
                    MessageBox.Show("Nincs ilyen felhasználó az adatbázisban", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    login_username.Clear();
                }
                else if (!(sql_password.Contains(log_password)))
                {
                    MessageBox.Show("Nincs ilyen jelszó az adatbázisban", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    login_pasword.Clear();
                }
                else
                {
                    MessageBox.Show("Sikeres bejelentkezés", "Engedélyezve", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Add("Sikeres bejelentkezés " + log_namenome + " néven " + DateTime.Now + " kor");
                    File.WriteAllLines(log_path, log);
                }
                connection.Close();
                dcc.Attributes = FileAttributes.Hidden;*/
                
            }
            
        }
    }
}
