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
    public partial class AdminForm : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека;Integrated Security=True";

        // Инициализация компонентов окна
        public AdminForm()
        {
            InitializeComponent();
        }

        // Открытие формы книг
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            adminBook - форма взаимодействия с таблицей книг.
        */
        private void btn_book_Click(object sender, EventArgs e)
        {
            AdminFormBook adminBook = new AdminFormBook();
            adminBook.Show();
        }

        // Открытие формы вспомогательных таблиц
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            etc - форма взаимодействия с вспомогательными таблицами.
        */
        private void btn_etc_Click(object sender, EventArgs e)
        {
            AdminFormEtc etc = new AdminFormEtc();
            etc.Show();
        }

        // Открытие формы читателей
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            reader - форма взаимодействия с таблицей читателей.
        */
        private void btn_reader_Click(object sender, EventArgs e)
        {
            AdminFromReader reader = new AdminFromReader();
            reader.Show();
        }

        // Открытие формы заказов
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            order - форма взаимодействия с таблией заказов.
        */
        private void btn_order_Click(object sender, EventArgs e)
        {
            AdminFormOrder order = new AdminFormOrder();
            order.Show();
        }

        // Изменение пароля администратора
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            fUp - флаг заглавной буквы;
            fDown - флаг прописной буквы;
            fZ - флаг допустимых символов;
            re - шаблон пароля;
            count - количество обновленных записей;
            sql - запрос смены пароля администратора;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
        private void btn_ChPass_Click(object sender, EventArgs e)
        {

                string sql = String.Format("UPDATE ПарольАдмин Set пароль='{0}'", textFPass.Text);
                int count = 0;
                bool fUp = false, fDown = false, fZ = false;
                Regex re = new Regex("^15");
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
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

