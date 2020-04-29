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
    public partial class AdminFromReader : Form
    {
        private DataTable dtReader = new DataTable();
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека;Integrated Security=True";
        string reader_sql = "SELECT * FROM Читатель";
        string[] table = { "фамилия", "имя", "отчество", "адрес", "телефон", "пароль"};
        // Инициализация компонентов окна
        public AdminFromReader()
        {
            InitializeComponent();
            UpdateGrid();
        }

        // Обновление таблицы читателей
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
                SqlCommand command = new SqlCommand(reader_sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                dtReader.Clear();
                dtReader.Load(reader);
                dataGridView1.DataSource = dtReader;
                comboBoxID.DataSource = dtReader;
                comboBoxID.DisplayMember = "id";
                reader.Close();
            }      
        }

        // Обновление данных читателя
        /*
            Формальные параметры:
            val - новое значение;
            i - номер поля.
            Локальные параметры:
            fUp - флаг заглавной буквы;
            fDown - флаг прописной буквы;
            fZ - флаг допустимых символов;
            re - шаблон пароля;
            count - количество обновленных записей;
            sql - запрос обновления читателя;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        void Upd(string val, int i)
        {
            try
            {
                string sql = String.Format("UPDATE Читатель Set {0}='{1}' WHERE id='{2}'", table[i], val, comboBoxID.Text);
                int count = 0;
                bool fUp = false, fDown = false, fZ = false;
                Regex re = new Regex("^15");
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    if ((i == 5) && (textFPassword.Text != textSPassword.Text))
                        MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (i == 5)
                        {
                            if ((textFPassword.Text).Length >= 7)
                            {
                                if (re.IsMatch(textFPassword.Text))
                                {
                                    foreach (char j in textFPassword.Text)
                                    {
                                        if (Char.IsUpper(j))
                                            fUp = true;
                                        if (Char.IsLower(j))
                                            fDown = true;
                                        if ((j == '!') || (j == '@') || (j == '#') || (j == '$') || (j == '%'))
                                            fZ = true;
                                    }
                                    if (fUp && fDown && fZ)
                                    {
                                        count = command.ExecuteNonQuery();
                                        UpdateGrid();
                                    }
                                    else
                                        MessageBox.Show("Пароль должен содержать минимум 1 заглавную букву/nминимум одну строчную букву/nи минимум один из символов !,@,#,$,%", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MessageBox.Show("Пароль должен начинаться с 15", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Пароль должен быть не короче 7 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            count = command.ExecuteNonQuery();
                            UpdateGrid();
                        }
                    }
                }
                if (count == 0)
                    MessageBox.Show("Не удалось изменить запись", String.Format("Поле {0} не было изменено", table[i]), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Неверный id или введенны данные не из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Добавление новой записи в таблицу читателей
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            fUp - флаг заглавной буквы;
            fDown - флаг прописной буквы;
            fZ - флаг допустимых символов;
            re - шаблон пароля;
            id - id нового читателя;
            sql - запрос добавления нового читателя;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 id = 0;
                bool fUp = false, fDown = false, fZ = false;
                Regex re = new Regex("^15");
                string sql = String.Format("INSERT INTO Читатель(фамилия, имя, отчество, адрес, телефон, пароль) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');SELECT CAST(scope_identity() AS int);", textSName.Text, textName.Text, textDName.Text, richTextStreet.Text, textPhone.Text, textFPassword.Text);
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(sql, conn);
                    conn.Open();
                    if (textFPassword.Text == textSPassword.Text)
                    {
                        if ((textFPassword.Text).Length >= 7)
                        {
                            if (re.IsMatch(textFPassword.Text))
                            {
                                foreach (char i in textFPassword.Text)
                                {
                                    if (Char.IsUpper(i))
                                        fUp = true;
                                    if (Char.IsLower(i))
                                        fDown = true;
                                    if ((i == '!') || (i == '@') || (i == '#') || (i == '$') || (i == '%'))
                                        fZ = true;
                                }
                                if (fUp && fDown && fZ)
                                    id = (Int32)command.ExecuteScalar();
                                else
                                    MessageBox.Show("Пароль должен содержать минимум 1 заглавную букву/nминимум одну строчную букву/nи минимум один из символов !,@,#,$,%", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Пароль должен начинаться с 15", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Пароль должен быть не короче 7 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateGrid();

            }
            catch
            {
                MessageBox.Show("Введены данные не из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление всех полей читателя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            valTable - массив изменяемых полей.
        */
        private void btn_upd_Click(object sender, EventArgs e)
        {
            string[] valTable = { textSName.Text, textName.Text, textDName.Text, richTextStreet.Text, textPhone.Text, 
                textFPassword.Text};
            for (int i = 0; i < 6; i++)
            {
                Upd(valTable[i], i);
            }
        }

        // Удаление читателя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            count - количество удаленных записей;
            sql - запрос обновления читателя;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("DELETE FROM Читатель WHERE id={0}", comboBoxID.Text);
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

                    if (count == 0)
                        MessageBox.Show("Не удалось удалить запись", "Запись не удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        UpdateGrid();
                }
            }
            catch
            {
                MessageBox.Show("Неверный id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление фамилии читателя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_second_name_Click(object sender, EventArgs e)
        {
            Upd(textSName.Text, 0);
        }

        // Обновление имени читателя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_name_Click(object sender, EventArgs e)
        {
            Upd(textName.Text, 1);
        }

        // Обновление отчества читателя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_dads_name_Click(object sender, EventArgs e)
        {
            Upd(textDName.Text, 2);
        }

        // Обновление адреса читателя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_street_Click(object sender, EventArgs e)
        {
            Upd(richTextStreet.Text, 3);
        }

        // Обновление телефона читателя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_phone_Click(object sender, EventArgs e)
        {
            Upd(textPhone.Text, 4);
        }

        // Обновление пароля читателя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void btn_password_Click(object sender, EventArgs e)
        {
            Upd(textFPassword.Text, 5);
        }
    }
}
