using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Lift_Complex_Test
{
    public partial class Form1 : Form
    {
        static DataBaseConnect dataBase;
        public Form1()
        {
            InitializeComponent();
            dataBase = new DataBaseConnect("localhost", "3306", "root", "12345");
        }

        private void getTable(object sender, EventArgs e)
        {
            string tableName = ((Button)sender).Tag.ToString();
            dataGridView.DataSource = dataBase.GetCurrentTable(tableName);
        }

        private void setDataTable_Click(object sender, EventArgs e)
        {
            dataBase.UpdateTable((DataTable)dataGridView.DataSource);
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell curCell = ((DataGridView)sender).CurrentCell;
            if (curCell.OwningColumn.Name == "photo")
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    curCell.Value = binaryReader.ReadBytes((int)fileStream.Length);
                    fileStream.Close();
                }
                
            }
                

        }

        private void buttSearch_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string id_company = textBoxIdCompany.Text;
            string position = textBoxPosition.Text;
            string salary = textBoxSalary.Text;
            dataGridView.DataSource = dataBase.SearchEmployee(id, name, surname, id_company, position, salary);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttInsert1000Records_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartThread);
            thread.Start();
        }

        private static void StartThread()
        {
            for(int i = 0; i < 10; i++)
            {
                dataBase.CreateCompanyWith100Employees();
            }
        }
    }
}
