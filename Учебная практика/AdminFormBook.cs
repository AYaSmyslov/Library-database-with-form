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
    public partial class AdminFormBook : Form
    {
        private DataTable dtBook = new DataTable();
        private DataTable dtAuthor = new DataTable();
        private DataTable dtGenre = new DataTable();
        private DataTable dtPubHouse = new DataTable();
        private DataTable dtPubLoc = new DataTable();
        private DataTable dtStorLoc = new DataTable();
        private DataTable dtPer = new DataTable();
        private DataTable dtFormat = new DataTable();
        private DataTable dtLang = new DataTable();
        private BindingSource bs = new BindingSource();
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека;Integrated Security=True";
        string book = "SELECT * FROM Книга";
        string author = "SELECT * FROM Автор";
        string genre = "SELECT * FROM Жанр";
        string publicHouse = "SELECT * FROM Издательство";
        string publicationLoc = "SELECT * FROM Место_изд";
        string storageLoc = "SELECT * FROM Место_хран";
        string periodicity = "SELECT * FROM Периодичность";
        string format = "SELECT * FROM Формат";
        string language = "SELECT * FROM Язык";
        string[] table = { "название", "автор", "год_изд", "жанр", "издательство", "место_изд", "язык", "формат_книги", "пер_выхода", "место_хран" };

        // Инициализация компонентов окна
        public AdminFormBook()
        {
            InitializeComponent();
            // Установка кастомного формата даты
            dateTimeCreate.CustomFormat = "dd.MM.yyyy";
            dateTimeCreate.Format = DateTimePickerFormat.Custom;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                UpdateGrid();

                conn.Open();
                
                // Заполнение 8 списков

                // Заполнение списка авторов
                SqlCommand selAuthor = new SqlCommand(author, conn);
                SqlDataReader readAuthor = selAuthor.ExecuteReader();
                dtAuthor.Load(readAuthor);
                comboBoxAuthor.DataSource = dtAuthor;
                comboBoxAuthor.DisplayMember = "название";

                // Заполнение списка жанров
                SqlCommand selGenre = new SqlCommand(genre, conn);
                SqlDataReader readGenre = selGenre.ExecuteReader();
                dtGenre.Load(readGenre);
                comboBoxGenre.DataSource = dtGenre;
                comboBoxGenre.DisplayMember = "название";

                // Заполнение списка издательств
                SqlCommand selPubH = new SqlCommand(publicHouse, conn);
                SqlDataReader readPubH = selPubH.ExecuteReader();
                dtPubHouse.Load(readPubH);
                comboBoxPubH.DataSource = dtPubHouse;
                comboBoxPubH.DisplayMember = "название";

                // Заполнение списка мест издательств
                SqlCommand selPubLoc = new SqlCommand(publicationLoc, conn);
                SqlDataReader readPubLoc = selPubLoc.ExecuteReader();
                dtPubLoc.Load(readPubLoc);
                comboBoxPubLoc.DataSource = dtPubLoc;
                comboBoxPubLoc.DisplayMember = "название";

                // Заполнение списка мест хранения
                SqlCommand selStorLoc = new SqlCommand(storageLoc, conn);
                SqlDataReader readStorLoc = selStorLoc.ExecuteReader();
                dtStorLoc.Load(readStorLoc);
                comboBoxStorL.DataSource = dtStorLoc;
                comboBoxStorL.DisplayMember = "название";

                // Заполнение списка периодичности
                SqlCommand selPer = new SqlCommand(periodicity, conn);
                SqlDataReader readPer = selPer.ExecuteReader();
                dtPer.Load(readPer);
                comboBoxPer.DataSource = dtPer;
                comboBoxPer.DisplayMember = "название";

                // Заполнение списка форматов
                SqlCommand selForm = new SqlCommand(format, conn);
                SqlDataReader readForm = selForm.ExecuteReader();
                dtFormat.Load(readForm);
                comboBoxFormat.DataSource = dtFormat;
                comboBoxFormat.DisplayMember = "название";

                // Заполнение списка языков
                SqlCommand selLang = new SqlCommand(language, conn);
                SqlDataReader readLang = selLang.ExecuteReader();
                dtLang.Load(readLang);
                comboBoxLang.DataSource = dtLang;
                comboBoxLang.DisplayMember = "название";
            }
        }

        // Добавление новой записи в таблицу книг
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            id - id новой книги;
            sql - запрос добавления новой книги;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 id = 0;
                string sql = String.Format("INSERT INTO Книга(название, автор, год_изд, жанр, издательство, место_изд, язык, формат_книги, пер_выхода, место_хран) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}');SELECT CAST(scope_identity() AS int);", textBoxName.Text, comboBoxAuthor.Text, dateTimeCreate.Text, comboBoxGenre.Text, comboBoxPubH.Text, comboBoxPubLoc.Text, comboBoxLang.Text, comboBoxFormat.Text, comboBoxPer.Text, comboBoxStorL.Text);
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(sql, conn);
                    conn.Open();
                    //Выполнение запроса
                    id = (Int32)command.ExecuteScalar();
                }
                    UpdateGrid();
            }
            catch
            {
                MessageBox.Show("Вы ввели данные, которых нет в допустимых списках", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Удаления записи из таблицы книг
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            count - количество удаленных записей;
            sql - запрос удаления книги;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("DELETE FROM Книга WHERE Id={0}", comboBoxChangeID.Text);
                int count = 0;
                DialogResult delAgree = MessageBox.Show("Записи в других таблицах будут также удалены.\nЖелаете удалить эту запись вместе с записями из другой таблицы?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delAgree == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(sql, conn);
                        count = command.ExecuteNonQuery();
                    }
                    // Проверка на ошибку
                    if (count > 0)
                    {
                        UpdateGrid();
                    }
                    else
                    {
                        MessageBox.Show("Запись с этим id не найдена", "Запись не удалена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный ID", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление таблицы книг
        /*
            Локальные параметры:
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных
            reader - выполнение запроса и сохранение результата.
        */
        private void UpdateGrid()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(book, conn);
                SqlDataReader reader = command.ExecuteReader();
                dtBook.Clear();
                dtBook.Load(reader);
                dataGridViewBook.DataSource = dtBook;
                comboBoxChangeID.DataSource = dtBook;
                comboBoxChangeID.DisplayMember = "id";
                reader.Close();
            }       
        }

        // Перезапись поля таблицы книг
        /*
            Формальные параметры:
            val - новое значение поля;
            i - номер столбца.
            Локальные параметры:
            count - количество обновленных записей;
            sql - запрос обновления записи;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        void Upd(string val, int i)
        {
            try
            {
                string sql = String.Format("UPDATE Книга Set {0}='{1}' WHERE Id='{2}'", table[i], val, comboBoxChangeID.Text);
                int count = 0;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    count = command.ExecuteNonQuery();
                }
                if (count == 0)
                    MessageBox.Show(String.Format("Поле {0} не было изменено", table[i]), "ID не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    UpdateGrid();
            }
            catch
            {
                MessageBox.Show("Неверный ID или введены данные не из списка", String.Format("Ошибка изменения колонки {0}",table[i]), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление всех полей записи
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_upd_all_Click(object sender, EventArgs e)
        {
            try
            {
                string[] valTable = { textBoxName.Text, comboBoxAuthor.Text, dateTimeCreate.Text, comboBoxGenre.Text, comboBoxPubH.Text, comboBoxPubLoc.Text, comboBoxLang.Text, comboBoxFormat.Text, comboBoxPer.Text, comboBoxStorL.Text };
                for (int i = 0; i < 10; i++)
                {
                    Upd(valTable[i], i);
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление названия книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_name_Click(object sender, EventArgs e)
        {
            Upd(textBoxName.Text, 0);
        }

        // Обновление автора книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_author_Click(object sender, EventArgs e)
        {
            Upd(comboBoxAuthor.Text, 1);
        }

        // Обновление даты издания книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_date_Click(object sender, EventArgs e)
        {
            Upd(dateTimeCreate.Text, 2);
        }

        // Обновление жанра книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_genre_Click(object sender, EventArgs e)
        {
            Upd(comboBoxGenre.Text, 3);
        }

        // Обновление издания книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_pubHouse_Click(object sender, EventArgs e)
        {
            Upd(comboBoxPubH.Text, 4);
        }

        // Обновление места издания книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_pubLoc_Click(object sender, EventArgs e)
        {
            Upd(comboBoxPubLoc.Text, 5);
        }

        // Обновление места хранения книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_storLoc_Click(object sender, EventArgs e)
        {
            Upd(comboBoxLang.Text, 6);
        }

        // Обновление периодичности издания книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_per_Click(object sender, EventArgs e)
        {
            Upd(comboBoxFormat.Text, 7);
        }

        // Обновление формата книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_fromat_Click(object sender, EventArgs e)
        {
            Upd(comboBoxPer.Text, 8);
        }

        // Обновление языка книги
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_lang_Click(object sender, EventArgs e)
        {
            Upd(comboBoxStorL.Text, 9);
        }
    }
}
