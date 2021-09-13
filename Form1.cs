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
            
            /*using (var connection = new SqliteConnection(@"Filename=C:\Users\zakor\source\repos\RegForm/database.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;

                SqliteParameter nameParam = new SqliteParameter("@name", NameField);
                command.Parameters.Add(nameParam);
                SqliteParameter surnameParam = new SqliteParameter("@surname", surnameField);
                command.Parameters.Add(surnameParam);
                SqliteParameter middlenameParam = new SqliteParameter("@middlename", middlenameField);
                command.Parameters.Add(middlenameParam);
                SqliteParameter datebirthParam = new SqliteParameter("@dateOfbirth", datebirthField);
                command.Parameters.Add(datebirthParam);
                SqliteParameter phonenumbParam = new SqliteParameter("@phoneNumber", phonefield);
                command.Parameters.Add(phonenumbParam);
                SqliteParameter emailParam = new SqliteParameter("@email", emailField);
                command.Parameters.Add(emailParam);
                command.ExecuteNonQuery();
                MessageBox.Show("БД успешно создана!", "", MessageBoxButtons.OK);
            }*/
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void RegistrationClick_Click(object sender, EventArgs e)
        {


            using (var connection = new SQLiteConnection("Data Source = ./database.db"))
            {
                

                SQLiteCommand command = connection.CreateCommand();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = "INSERT INFO 'Users' ('name', surname', middlename', 'dateOfbirth', 'phoneNumber', 'email') VALUES (@name, @surname, @middlename, @dateOfbirth, @)phoneNumber, @email";


                command.Connection = connection;
                

                SQLiteParameter nameParam = new SQLiteParameter("@name", nnameField);
                command.Parameters.Add(nameParam);
                SQLiteParameter surnameParam = new SQLiteParameter("@surname", surnameField);
                command.Parameters.Add(surnameParam);
                SQLiteParameter middlenameParam = new SQLiteParameter("@middlename", middlenameField);
                command.Parameters.Add(middlenameParam);
                SQLiteParameter datebirthParam = new SQLiteParameter("@dateOfbirth", datebirthField);
                command.Parameters.Add(datebirthParam);
                SQLiteParameter phonenumbParam = new SQLiteParameter("@phoneNumber", phonefield);
                command.Parameters.Add(phonenumbParam);
                SQLiteParameter emailParam = new SQLiteParameter("@email", emailField);
                command.Parameters.Add(emailParam);

                connection.Open();
                command.ExecuteReader();


                MessageBox.Show("БД успешно создана!", "", MessageBoxButtons.OK);

                


                /*using (var connection = new SqliteConnection(@"Filename=C:\Users\zakor\source\repos\RegForm/database.db"))
                {
                    connection.Open();

                    SqliteCommand command = connection.CreateCommand();
                    SqliteCommand cmd = new SqliteCommand();
                    cmd.CommandText = "SELECT * FROM Users";
                    command.Connection = connection;

                    SqliteParameter nameParam = new SqliteParameter("@name", nnameField);
                    command.Parameters.Add(nameParam);
                    SqliteParameter surnameParam = new SqliteParameter("@surname", surnameField);
                    command.Parameters.Add(surnameParam);
                    SqliteParameter middlenameParam = new SqliteParameter("@middlename", middlenameField);
                    command.Parameters.Add(middlenameParam);
                    SqliteParameter datebirthParam = new SqliteParameter("@dateOfbirth", datebirthField);
                    command.Parameters.Add(datebirthParam);
                    SqliteParameter phonenumbParam = new SqliteParameter("@phoneNumber", phonefield);
                    command.Parameters.Add(phonenumbParam);
                    SqliteParameter emailParam = new SqliteParameter("@email", emailField);
                    command.Parameters.Add(emailParam);
                    connection.Open();

                    MessageBox.Show("БД успешно создана!", "", MessageBoxButtons.OK);

                    command.ExecuteNonQuery();*/
                }


                /* SqliteCommand cmd = new SqliteCommand();


                 cmd.Connection = connection;
                 cmd.CommandText = "insert into Student(name, surname, middlename, dateOfbirth, phoneNumber, email) values (" + NameField.Text + ",'" + surnameField.Text + "','" + middlenameField.Text + "', '" + datebirthField.Text + "', '" + phonefield.Text + "', '" + emailField.Text + "',)";
                 cmd.ExecuteNonQuery();
                 connection.Close();*/



            }
    }
}
