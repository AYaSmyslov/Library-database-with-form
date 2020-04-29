using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Учебная_практика
{
    public partial class AdminFormOrder : Form
    {

        private DataTable dtOrder = new DataTable();
        private DataTable dtReader = new DataTable();
        private DataTable dtBook = new DataTable();
        private DataTable dtDeb = new DataTable();
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека;Integrated Security=True";
        string order_sql = "SELECT * FROM Заказ";
        string deb_sql = "SELECT ч.id, ч.фамилия FROM Читатель ч, Заказ з WHERE (ч.id=з.читатель) AND (DATEDIFF(day, GETDATE(), з.дата_воз)<0)";
        string reader_sql = "SELECT * FROM Читатель";
        string book_sql = "SELECT * FROM Книга";
        string[] table = { "читатель", "книга", "дата_выд", "дата_воз" };

        // Инициализация компонентов окна
        public AdminFormOrder()
        {
            InitializeComponent();
            UpdateGrid();
            // Установка кастомного формата данных
            dateTimeDrop.CustomFormat = "dd.MM.yyyy";
            dateTimeDrop.Format = DateTimePickerFormat.Custom;
            dateTimeReturn.CustomFormat = "dd.MM.yyyy";
            dateTimeReturn.Format = DateTimePickerFormat.Custom;
        }

        // Обновление таблицы заказов
        /*
            Локальные параметры:
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных;
            reader - выполнение запроса и сохранение результата.
        */
        private void UpdateGrid()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(order_sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                dtOrder.Clear();
                dtOrder.Load(reader);
                dataGridView1.DataSource = dtOrder;
                comboBoxID.DataSource = dtOrder;
                comboBoxID.DisplayMember = "id";

                SqlCommand commandR = new SqlCommand(reader_sql, conn);
                SqlDataReader readerR = commandR.ExecuteReader();
                dtReader.Clear();
                dtReader.Load(readerR);
                comboReader.DataSource = dtReader;
                comboReader.DisplayMember = "id";

                SqlCommand commandB = new SqlCommand(book_sql, conn);
                SqlDataReader readerB = commandB.ExecuteReader();
                dtBook.Clear();
                dtBook.Load(readerB);
                comboBook.DataSource = dtBook;
                comboBook.DisplayMember = "id";

                SqlCommand cmndDeb = new SqlCommand(deb_sql, conn);
                reader = cmndDeb.ExecuteReader();
                dtDeb.Load(reader);
                dataGridDebtor.DataSource = dtDeb;
                reader.Close();
            }       
        }

        // Обновление данных заказа
        /*
            Формальные параметры:
            val - новое значение;
            i - номер поля.
            Локальные параметры:
            count - количество обновленных записей;
            sql - запрос обновления заказа;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        void Upd(string val, int i)
        {
            try
            {
                string sql = String.Format("UPDATE Заказ Set {0}='{1}' WHERE Id='{2}'", table[i], val, comboBoxID.Text);
                int count = 0;
                if (dateTimeDrop.Value <= dateTimeReturn.Value)
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(sql, conn);
                        count = command.ExecuteNonQuery();
                    }

                if (count == 0)
                {
                    MessageBox.Show("Дата возврата не может быть раньше даты выдачи!", String.Format("Поле {0} не было изменено", table[i]), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введены данные не из списка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Добавление новой записи в таблицу заказов
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            id - id нового заказа;
            sql - запрос добавления нового заказа;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 id = 0;
                string sql = String.Format("INSERT INTO Заказ(читатель, книга, дата_выд, дата_воз) VALUES ('{0}','{1}','{2}','{3}');SELECT CAST(scope_identity() AS int);", comboReader.Text, comboBook.Text, dateTimeDrop.Text, dateTimeReturn.Text);
                if (dateTimeDrop.Value <= dateTimeReturn.Value)
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        SqlCommand command = new SqlCommand(sql, conn);
                        conn.Open();
                        id = (Int32)command.ExecuteScalar();
                    }
                else
                {
                    MessageBox.Show("Дата возврата не может быть раньше даты выдачи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (id != 0)
                {
                    UpdateGrid();
                }
                
            }
            catch
            {
                MessageBox.Show("Введены данные не из списка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление всех полей заказа
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            valTable - массив изменяемых полей.
        */
        private void btn_upd_Click(object sender, EventArgs e)
        {
            string[] valTable = { comboReader.Text, comboBook.Text, dateTimeDrop.Text, dateTimeReturn.Text };
            for (int i = 0; i < 4; i++)
            {
                Upd(valTable[i], i);
            }
            UpdateGrid();
        }

        // Удаление заказа
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            count - количество удаленных записей;
            sql - запрос обновления заказа;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("DELETE FROM Заказ WHERE id={0}", comboBoxID.Text);
                int count = 0;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    count = command.ExecuteNonQuery();
                }
                if (count > 0)
                {
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("Эта запись не найдена!", "Запись не удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введены данные не из списка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление читателя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_reader_Click(object sender, EventArgs e)
        {
            Upd(comboReader.Text, 0);
            UpdateGrid();
        }

        // Обновление книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_book_Click(object sender, EventArgs e)
        {
            Upd(comboBook.Text, 1);
            UpdateGrid();
        }

        // Обновление даты выдачи
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_drop_Click(object sender, EventArgs e)
        {
            Upd(dateTimeDrop.Text, 2);
            UpdateGrid();
        }

        // Обновление даты возврата
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_return_Click(object sender, EventArgs e)
        {
            Upd(dateTimeReturn.Text, 3);
            UpdateGrid();
        }
    }
}
