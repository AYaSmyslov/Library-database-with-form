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
    public partial class LoginForm : Form
    {
        private DataTable dtReader = new DataTable();
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека;Integrated Security=True";
        // Инициализация компонентов окна
        public LoginForm()
        {
            InitializeComponent();
        }

        // Переход к регистрации пользователя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            reg - форма регистрации пользоватлея.
        */
        private void btn_reg_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.Show();
        }

        // Переход в профиль пользователя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            sql - запрос выборки пароля читателя и его id;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных;
            reader - выполнение и сохранение результата запроса;
            profile - форма профиля пользоватлея.
        */
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("SELECT * FROM Читатель WHERE (id='{0}') AND (пароль='{1}')", textID.Text, textPass.Text);
                dtReader.Clear();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    dtReader.Load(reader);
                    reader.Close();
                }
                if (dtReader.Rows.Count == 1) // Проверка пароля пользователя
                {
                    UserProfileForm profile = new UserProfileForm(int.Parse(textID.Text));
                    profile.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
