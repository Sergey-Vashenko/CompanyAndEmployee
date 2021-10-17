using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lift_Complex_Test
{
    class DataBaseConnect
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapterTableCompany;
        private MySqlDataAdapter adapterTableEmployee;
        private string curTableName;
        private string nameDataBase;
        private int curIdEmployee = 0;
        private int curIdCompany = 0;
        object locker = new object();

        public DataBaseConnect(string ipServer, string port, string userName, string password)
        {
            connection = new MySqlConnection("server = " + ipServer + 
                                            ";port = " + port + 
                                            ";username = " + userName + 
                                            ";password = " +password);
            adapterTableCompany = new MySqlDataAdapter();
            adapterTableEmployee = new MySqlDataAdapter();
            connection.Open();
            nameDataBase = "СompaniesAndEmployees";
            MySqlCommand command = new MySqlCommand("show databases like '" + nameDataBase +"';" ,connection);
            adapterTableCompany.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapterTableCompany.Fill(dataTable);
            if (dataTable.Rows.Count == 0)
            {
                try
                {
                    command.CommandText = "CREATE DATABASE " + nameDataBase + ";";
                    command.ExecuteNonQuery();
                    connection.ChangeDatabase(nameDataBase);
                    command.CommandText = "CREATE TABLE IF NOT EXISTS Company " +
                        "(id_company INT UNSIGNED NOT NULL, " +
                        "title VARCHAR(20) NULL, " +
                        "address VARCHAR(60) NULL, " +
                        "contact_number VARCHAR(20) NULL, " +
                        "branch_of_work VARCHAR(40) NULL, " +
                        "PRIMARY KEY(`id_company`))";
                    command.ExecuteNonQuery();
                    command.CommandText = "CREATE TABLE IF NOT EXISTS Employee " +
                        "(id INT UNSIGNED NOT NULL, " +
                        "name VARCHAR(15) NULL, " +
                        "surname VARCHAR(20) NULL, " +
                        "patronymic VARCHAR(25) NULL, " +
                        "gender VARCHAR(1) NULL, " +
                        "photo LONGBLOB NULL, " +
                        "id_company INT UNSIGNED NOT NULL, " +
                        "position VARCHAR(40) NULL, " +
                        "salary MEDIUMINT(8) UNSIGNED NULL, " +
                        "PRIMARY KEY(id),INDEX Company_idx (id_company ASC) VISIBLE, " +
                        "CONSTRAINT Company FOREIGN KEY(id_company) " +
                        "REFERENCES Company (id_company) " +
                        "ON DELETE CASCADE ON UPDATE CASCADE)";
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка при создании базы данных");
                    connection.Close();
                    return;
                }
                    
                
            }
            
        }

        public DataTable GetCurrentTable(string table)
        {
            curTableName = table;
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + nameDataBase + "." + table, connection);
            DataTable curTable = new DataTable();
            try
            {
                if (table == "Company")
                {
                    adapterTableCompany.SelectCommand = command;
                    adapterTableCompany.Fill(curTable);
                }
                else if (curTableName == "Employee")
                {
                    adapterTableEmployee.SelectCommand = command;
                    adapterTableEmployee.Fill(curTable);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Невозможно получить данные из базы данных");
                return null;
            }
            return curTable;
        }

        public void UpdateTable(DataTable table)
        {
            try
            {
                if (curTableName == "Company")
                {
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapterTableCompany);
                    adapterTableCompany.UpdateCommand = commandBuilder.GetUpdateCommand();
                    adapterTableCompany.Update(table);
                }
                else if (curTableName == "Employee")
                {
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapterTableEmployee);
                    adapterTableEmployee.UpdateCommand = commandBuilder.GetUpdateCommand();
                    adapterTableEmployee.Update(table);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Невозможно применить изменения. Пожалуйста проверьте правильность введенных данных");
            }
        }

        public DataTable SearchEmployee(string id, string name, string surname, string id_company, string position, string salary)
        {
            string command = "SELECT * FROM " + nameDataBase + ".Employee WHERE ";
            if (id != "")
                    command += "id = " + id + " AND ";
            if (name != "")
                command += "name = " + name + " AND ";
            if (surname != "")
                command += "surname = " + surname + " AND ";
            if (id_company != "")
                command += "id_company = " + id_company + " AND ";
            if (position != "")
                command += "position = " + position + " AND ";
            if (salary != "")
                command += "salary = " + salary + " AND ";
            command += "1;";
            adapterTableEmployee.SelectCommand = new MySqlCommand(command, connection);
            DataTable table = new DataTable();
            try
            {
                adapterTableEmployee.Fill(table);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно получить данные из базы данных");
                return null;
            }
            return table;
        }

        public void CreateCompanyWith100Employees()
        {
            lock(locker)
            {
                string command;
                MySqlCommand sqlCommand;
                try
                {
                    command = "INSERT INTO " + nameDataBase + ".Company (id_company, title, address, " +
                                    "contact_number, branch_of_work) " +
                                    "VALUES (" + curIdCompany.ToString() + ", 'a', 'b', 'c', 'd');";
                    sqlCommand = new MySqlCommand(command, connection);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    curIdCompany++;
                    CreateCompanyWith100Employees();
                }
                try 
                {
                    for (int i = 0; i < 100; i++)
                    {
                        command = "INSERT INTO " + nameDataBase + ".Employee (id, name, surname, patronymic, " +
                                    "gender, photo, id_company, position, salary) " +
                                    "VALUES (" + curIdEmployee.ToString() + ", 'e', 'f', 'g', 'm', null, " +
                                    curIdCompany.ToString() + " , 'h', 100000);";
                        sqlCommand = new MySqlCommand(command, connection);
                        sqlCommand.ExecuteNonQuery();
                        curIdEmployee++;
                    }
                    curIdCompany++;
                }
                catch (Exception)
                {
                    curIdEmployee++;
                }
            }            
        }

        ~DataBaseConnect()
        {
            connection.Close();
        }
    }
}
