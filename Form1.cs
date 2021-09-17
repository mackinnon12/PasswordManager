using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using EncrypterProgram;
using PasswordManager;
using System.Data.OleDb;

namespace ManksEncrypter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            btnHidePass.Visible = false;

            table.Columns.Add("Website", typeof(string));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            dataGridView1.DataSource = table;
        }
        private void btnPanelPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnPanelEncrypter_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            char delimiter = ',';
            string Website = txtWebsite.Text;
            string Username = txtUserName.Text;
            string Password = txtPassword.Text;
            string filePath = @"data.txt";
            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                fs.Close();
            }

            if (txtWebsite.Text == "")
            {
                MessageBox.Show("Website Required", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWebsite.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Username Required", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password Required", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                lines.Add(Website + delimiter + Username + delimiter + Password);
                File.WriteAllLines(filePath, lines);
                //Refresh DataGrid
                btnHidePass_Click(sender, e);
                btnShowPass_Click(sender, e);
                //Clear Text Boxes
                txtWebsite.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }
        private void btnRandomPassword_Click(object sender, EventArgs e)
        {
            //Generates Random Password
            var chars = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789!@#$%^&*.";
            var stringChars = new char[32];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            txtPassword.Text = finalString;
        }
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtWebsite.Focus();
            string filePath = @"data.txt";
            char delimiter = ',';
            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                fs.Close();
            }
            btnHidePass_Click(sender, e);
            string[] lines = File.ReadAllLines(filePath);
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(delimiter);
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
            btnHidePass.Visible = true;
            btnShowPass.Visible = false;
        }
        private void btnHidePass_Click(object sender, EventArgs e)
        {
            btnShowPass.Visible = true;
            btnHidePass.Visible = false;
            txtWebsite.Focus();
            DataTable DT = (DataTable)dataGridView1.DataSource;
            if (DT != null)
                DT.Clear();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string filePath = @"data.txt";
            string remove = txtRemove.Text.ToLower();
            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                fs.Close();
            }
            if (txtRemove.Text == "")
            {
                MessageBox.Show("Input Required", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRemove.Focus();
            }
            else
            {
                string[] Lines = File.ReadAllLines(filePath);
                File.Delete(filePath);// Deleting the file
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    foreach (string line in Lines)
                    {
                        if (line.ToLower().IndexOf(remove) >= 0)
                        {
                            continue;
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                txtRemove.Clear();
                btnHidePass_Click(sender, e);
                btnShowPass_Click(sender, e);
            }
        }
    }
}
