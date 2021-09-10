using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.Data.Common;
using System.Data.Entity;



namespace RegForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetList();
            using (var connection = new SqliteConnection("Data Source=./database.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "CREATE TABLE Users(_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Name TEXT NOT NULL, Surname TEXT NOT NULL, Middlename TEXT NOT NULL, phoneNumber INTEGER NOT NULL UNIQUE, email TEXT NOT NULL UNIQUE, birthDate INTEGER NOT NULL)";
                command.ExecuteNonQuery();
                MessageBox.Show("БД успешно создана!", "", MessageBoxButtons.OK);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void RegistrationClick_Click(object sender, EventArgs e)
        {


            SqliteCommand cmd = new SqliteCommand;
            SqliteCommand command = connection.CreateCommand();
            command.Connection = new con;

            cmd.Connection = con;
            cmd.CommandText = "insert into Student(ID,FirstName,LastName) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();

        }
    }
}
