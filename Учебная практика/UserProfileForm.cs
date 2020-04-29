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
using System.Text.RegularExpressions;

namespace Учебная_практика
{
    public partial class UserProfileForm : Form
    {
        private DataTable dtBook = new DataTable();
        private DataTable dtOrder = new DataTable();
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека;Integrated Security=True";
        string[] table = { "id", "название", "автор", "год_изд", "жанр", "издательство", "место_изд", "язык", "формат_книги", "пер_выхода", "место_хран" };
        int UserID = 0;
        // Инициализация компонентов окна
        /*
         Формальные параметры:
         id - id авторизованного пользователя
        */
        public UserProfileForm(int id)
        {
            InitializeComponent();
            UserID = id; 
            // Установка кастомного формата даты
            dateTimeCreate.CustomFormat = "dd.MM.yyyy";
            dateTimeCreate.Format = DateTimePickerFormat.Custom;
            dateTimeDrop.CustomFormat = "dd.MM.yyyy";
            dateTimeDrop.Format = DateTimePickerFormat.Custom;
            dateTimeReturn.CustomFormat = "dd.MM.yyyy";
            dateTimeReturn.Format = DateTimePickerFormat.Custom;
            // Обновление таблиц
            UpdateLib();
            UpdateOrder();
        }

        // Обновление таблицы книг
        /*
            Локальные параметры:
            fAND - флаг нескольких фильтроф;
            sql - запрос выборки пароля читателя и его id;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        private void UpdateLib()
        {
            try
            {
                string sql = "SELECT к.id AS 'ID книги', к.название AS 'Название', к.автор AS 'Автор', к.год_изд AS 'Год издания', к.жанр AS 'Жанр', к.издательство AS 'Издательство', к.место_изд AS 'Место издательства', к.язык AS 'Язык', к.формат_книги AS 'Формат книги', к.пер_выхода AS 'Периодичность', к.место_хран AS 'Место хранения' FROM Книга к";
                //int cnt = 0;
                bool fAND = false;
                // Формирование условия в запросе
                if (chID.Checked || chName.Checked || chAuthor.Checked || chCreate.Checked || chGenre.Checked || chPubH.Checked || chPubLoc.Checked || chLang.Checked || chFromat.Checked || chPer.Checked || chStorageLoc.Checked)
                    if ((textBoxFid.Text != "") || (textBoxFName.Text != "") || (textBoxFAuthor.Text != "") || (dateTimeCreate.Text != "") || (textBoxFGenre.Text != "") || (textBoxFPubH.Text != "") || (textBoxFPubL.Text != "") || (textBoxFLang.Text != "") || (textBoxFFormat.Text != "") || (textBoxFPer.Text != "") || (textBoxFStorL.Text != ""))
                        sql += " WHERE ";
                filter(ref sql, ref fAND, chID.Checked, table[0], textBoxFid.Text);
                filter(ref sql, ref fAND, chName.Checked, table[1], textBoxFName.Text);
                filter(ref sql, ref fAND, chAuthor.Checked, table[2], textBoxFAuthor.Text);
                filter(ref sql, ref fAND, chCreate.Checked, table[3], dateTimeCreate.Text);
                filter(ref sql, ref fAND, chGenre.Checked, table[4], textBoxFGenre.Text);
                filter(ref sql, ref fAND, chPubH.Checked, table[5], textBoxFPubH.Text);
                filter(ref sql, ref fAND, chPubLoc.Checked, table[6], textBoxFPubL.Text);
                filter(ref sql, ref fAND, chLang.Checked, table[7], textBoxFLang.Text);
                filter(ref sql, ref fAND, chFromat.Checked, table[8], textBoxFFormat.Text);
                filter(ref sql, ref fAND, chPer.Checked, table[9], textBoxFPer.Text);
                filter(ref sql, ref fAND, chStorageLoc.Checked, table[10], textBoxFStorL.Text);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    dtBook.Clear();
                    dtBook.Load(reader);
                    dataGridBooks.DataSource = dtBook;
                    comboBoxID.DataSource = dtBook;
                    comboBoxID.DisplayMember = "ID книги";
                    reader.Close();
                }
                if (dtBook.Rows.Count == 0)
                    MessageBox.Show("По вашему запросу ничего не найдено:(", "Ничего не найдетно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Требуется ввести число", "Неверный формат ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Установка фильтра
        /*
            Фактические параметры:
            ord - формируемый sql запрос;
            f - флаг продолжения списка фильтров.
            Формальные параметры:
            ch - флаг установки фильтра;
            col - фильтруемый столбец;
            str - фильтруемое значение.
        */
        void filter(ref string ord, ref bool f, bool ch, string col, string str)
            {
                if (ch && (str != ""))
                {
                    if (f)
                        ord += " AND";
                    else
                        f = true;
                    ord += String.Format("({0}='{1}')", col, str);
                }
            }

        // Обновление таблицы заказов
        /*
            sql - запрос выборки заказов текущего пользователя;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных;
            read - выполнение и сохранение результата запроса.
        */
        private void UpdateOrder()
        {
            string sql = String.Format("SELECT к.название AS 'Выданные вам книги', DATEDIFF(day, з.дата_выд, з.дата_воз) AS 'Осталось дней' FROM Заказ з, Книга к WHERE (читатель='{0}') AND (з.книга=к.id)", UserID);
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                dtOrder.Clear();
                dtOrder.Load(reader);
                dataGridOrders.DataSource = dtOrder;
                reader.Close();
            }
        }

        // Применение фильтра таблицы книг
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_filter_Click(object sender, EventArgs e)
        {
            UpdateLib();
        }

        // Создание заказа
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
        private void btn_makeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 id = 0;
                string sql = String.Format("INSERT INTO Заказ(читатель, книга, дата_выд, дата_воз) VALUES ('{0}','{1}','{2}','{3}');SELECT CAST(scope_identity() AS int);", UserID, comboBoxID.Text, dateTimeDrop.Text, dateTimeReturn.Text);
                if (dateTimeDrop.Value <= dateTimeReturn.Value)
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        SqlCommand command = new SqlCommand(sql, conn);
                        conn.Open();
                        id = (Int32)command.ExecuteScalar();
                    }
                }
                    if (id != 0)
                    {
                        UpdateOrder();
                    }
                    else
                    {
                        MessageBox.Show("Дата возврата не может быть раньше даты заказа","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                
            }
            catch
            {
                MessageBox.Show("Неверный ID книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Смена пароля
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            count - количество обновленных записей;
            sql - запрос обновления пароля текущего пользователя;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        private void btn_ChPass_Click(object sender, EventArgs e)
        {
            string sql = String.Format("UPDATE Читатель Set пароль='{0}' WHERE id='{1}'", textFPass.Text, UserID);
            int count = 0;
            bool fUp = false, fDown = false, fZ = false;
            Regex re = new Regex("^15");
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                // Проверка пароля
                if (textFPass.Text != textSPass.Text)
                    MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if ((textFPass.Text).Length >= 7)
                    {
                        if (re.IsMatch(textFPass.Text))
                        {
                            foreach (char i in textFPass.Text)
                            {
                                if (Char.IsUpper(i))
                                    fUp = true;
                                if (Char.IsLower(i))
                                    fDown = true;
                                if ((i == '!') || (i == '@') || (i == '#') || (i == '$') || (i == '%'))
                                    fZ = true;
                            }
                            if (fUp && fDown && fZ)
                                count = command.ExecuteNonQuery();
                            else
                                MessageBox.Show("Пароль должен содержать минимум 1 заглавную букву/nминимум одну строчную букву/nи минимум один из символов !,@,#,$,%", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Пароль должен начинаться с 15", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Пароль должен быть не короче 7 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (count != 0)
                MessageBox.Show("Пароль усмешно изменен", String.Format("Успех"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
