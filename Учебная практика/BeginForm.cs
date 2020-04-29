/*
# Практическая работа по предмету МДК.03.01 "Технология разработки программного обеспечения"
# Название: Библиотека
# Разработал: Смыслов Александр Андреевич, группа ТМП-62,
# Дата и номер версии: 21.04.2020 v1.0
# Язык: C#
# Краткое описание: 
#   Данная программа является информационной системой для библиотеки.
# Задание:
#   Разработать информационную систему, предназначенную для работников библиотеки.
# Такая система должна обеспечивать хранение сведений об имеющихся в библиотеке книгах,
# о читателях и их заказах. Читатели проходят обязательную регистрацию, при которой 
# о них собирается стандартная информация/
# Формы:
# BeginForm - форма основной программы, предоставляет выбор роли;
# LoginForm - форма авторизации пользователя;
# RegForm - форма регистрации пользователя;
# UserProfileForm - форма профиля авторизованного пользователя, предоставляет заказ книг;
# AdminForm - форма администратора;
# AdminFormBook - форма работы с таблицей книг;
# AdminFormReader - форма работы с таблицей читателей;
# AdminFormOrder - форма работы с таблицей заказов;
# AdminFormEtc - форма работы с вспомогательными таблицами.
*/

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
    public partial class BeginForm : Form
    {
        private DataTable dtAdminPass = new DataTable();
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека;Integrated Security=True";
        // Инициализация компонентов окна
        public BeginForm()
        {
            InitializeComponent();
        }

        // Выбор роли администратора
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            sql - запрос выборки пароля администратора;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных;
            reader - выполнение и сохранение результата запроса;
            admin - форма администратора.
        */
        private void btn_admin_Click(object sender, EventArgs e)
        {
            string sql = String.Format("SELECT * FROM ПарольАдмин WHERE пароль='{0}'", textBox1.Text);
            dtAdminPass.Clear();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                dtAdminPass.Load(reader);
            }
            if (dtAdminPass.Rows.Count == 1) // Проверка пароля
            {
                AdminForm admin = new AdminForm();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль()", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        // Выбор роли пользователя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            log - форма пользоватлея.
        */
        private void btn_user_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
        }
    }
}
