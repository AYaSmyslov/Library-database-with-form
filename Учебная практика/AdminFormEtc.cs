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
    public partial class AdminFormEtc : Form
    {
        private DataTable dtBook = new DataTable();
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека;Integrated Security=True";
        // Инициализация компонентов окна
        public AdminFormEtc()
        {
            InitializeComponent();
            // Заполнение списка вспомогательных таблиц
            comboBoxTables.Items.Add("Автор");
            comboBoxTables.Items.Add("Жанр");
            comboBoxTables.Items.Add("Издательство");
            comboBoxTables.Items.Add("Место_изд");
            comboBoxTables.Items.Add("Язык");
            comboBoxTables.Items.Add("Формат");
            comboBoxTables.Items.Add("Периодичность");
            comboBoxTables.Items.Add("Место_хран");
            UpdateCombo();
        }

        // Добавление новой записи в выбранную таблицу
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            sql - запрос добавления новой записи;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных;
            reader - выполнение запроса и сохранение результата.
        */
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("INSERT INTO {0}(название) VALUES ('{1}');", comboBoxTables.Text, textBoxData.Text);
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                }
                UpdateCombo();
            }
            catch
            {
                MessageBox.Show("Такая запись уже есть в БД","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление списка записей выбранной таблицы
        /*
            Локальные параметры:
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных;
            reader - выполнение запроса и сохранение результата.
        */
        private void UpdateCombo()
        {
            string sql = String.Format("SELECT * FROM {0}", comboBoxTables.Text);
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                dtBook.Clear();
                dtBook.Load(reader);
                comboBoxRow.DataSource = dtBook;
                comboBoxRow.DisplayMember = "название";
                reader.Close();
            }        
        }

        // Удаление записи из выбранной таблицы
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            delAgree - предупреждение о каскадном удалении;
            sql - запрос добавления новой записи;
            conn - подключение к базе данных;
            cmndDelThis - инструкция, выполняемая над подключенной базе данных;
            count - количество удаленных записей.
        */
        private void btn_del_Click(object sender, EventArgs e)
        {
           try {
                string sql = String.Format("DELETE FROM {0} WHERE название='{1}'", comboBoxTables.Text, comboBoxRow.Text);
                int count = 0;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    DialogResult delAgree = MessageBox.Show("Записи в других таблицах будут также удалены.\nЖелаете удалить эту запись вместе с записями из другой таблицы?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (delAgree == DialogResult.Yes)
                    {
                        SqlCommand cmdDelThis = new SqlCommand(sql, conn);
                        count = cmdDelThis.ExecuteNonQuery();
                    }
                }
                if (count > 0)
                {
                    UpdateCombo();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить запись", "Запись не удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
                catch
                {
                    MessageBox.Show("Введены данные не из списка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        // Изменение записи записи в выбранной таблице
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            sql - запрос обновления записи;
            conn - подключение к базе данных;
            editAgrree - предупреждение о каскадном изменении;
            cmndUpdThis - инструкция, выполняемая над подключенной базе данных;
            count - количество измененных записей.
        */
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("UPDATE {0} Set название='{1}' WHERE название='{2}'", comboBoxTables.Text, textBoxData.Text, comboBoxRow.Text);
                int count = 0;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    
                    DialogResult editAgree = MessageBox.Show("Записи в других таблицах также будут изменены.\nЖелаете изменить эту запись вместе с записями из другой таблицы?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (editAgree == DialogResult.Yes)
                    {
                        SqlCommand cmndUpdThis = new SqlCommand(sql, conn);
                        count = cmndUpdThis.ExecuteNonQuery();
                    }
                }
                if (count > 0)
                {
                    UpdateCombo();
                }
                else
                {
                    MessageBox.Show("Не удалось изменить запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось изменить запись (введены неверные данные)", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        // Обновление списка записей выбранной таблицы
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCombo();
        }
    }
}
