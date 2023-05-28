using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsStore
{     
    public partial class CarBrandForm : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=test.accdb";
        OleDbConnection connection = new OleDbConnection(connectionString);//соединение

        public CarBrandForm()
        {
            InitializeComponent();
            connection.Open();
            string query = "SELECT * FROM car_brand";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);
            DataSet ds = new DataSet();// создаем объект DataSet
            dataAdapter.Fill(ds, "car_brand");// заполняем таблицу данными из базы данных
            table.DataSource = ds.Tables[0].DefaultView;
            connection.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = table.SelectedRows[0].Index;//Запомним выбранную строку

            //if (table.Rows[index].Cells[1].Value == null)//Проверим данные в таблицы
            //{
            //    MessageBox.Show("Не все данные введены!", "Внимание!");
            //    return;
            //}

            string name = table.Rows[index].Cells[1].Value.ToString();

            try
            {
                // Выполянем запрос к БД
                connection.Open();//открываем соеденение
                string query = $"INSERT INTO car_brand(Brand_name) VALUES ({name})";//строка запроса
                //query = "SELECT MAX(ID) FROM car_brand";
                OleDbCommand command = new OleDbCommand(query, connection);//команда

                // Выполняем запрос
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                    MessageBox.Show("Данные добавлены!", "Внимание!");
            }
            catch (Exception ex)//throw ex;
            {
                MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
            }
            finally
            {
                connection.Close();// Закрываем соеденение с БД
            }
        }
    }
}
