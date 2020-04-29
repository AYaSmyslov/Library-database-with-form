namespace Учебная_практика
{
    partial class AdminFormBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxPubH = new System.Windows.Forms.ComboBox();
            this.comboBoxPubLoc = new System.Windows.Forms.ComboBox();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.comboBoxPer = new System.Windows.Forms.ComboBox();
            this.comboBoxStorL = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_upd_all = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.comboBoxChangeID = new System.Windows.Forms.ComboBox();
            this.btn_name = new System.Windows.Forms.Button();
            this.btn_author = new System.Windows.Forms.Button();
            this.btn_date = new System.Windows.Forms.Button();
            this.btn_genre = new System.Windows.Forms.Button();
            this.btn_pubHouse = new System.Windows.Forms.Button();
            this.btn_pubLoc = new System.Windows.Forms.Button();
            this.btn_storLoc = new System.Windows.Forms.Button();
            this.btn_per = new System.Windows.Forms.Button();
            this.btn_fromat = new System.Windows.Forms.Button();
            this.btn_lang = new System.Windows.Forms.Button();
            this.dateTimeCreate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.Size = new System.Drawing.Size(1149, 243);
            this.dataGridViewBook.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(48, 289);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Название";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(395, 400);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Год издания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Жанр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Издательство";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Место издания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Язык";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(806, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Формат книги";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(912, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "Периодичность\r\n         выхода";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1017, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Место хранения";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(154, 289);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAuthor.TabIndex = 22;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(379, 287);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGenre.TabIndex = 23;
            // 
            // comboBoxPubH
            // 
            this.comboBoxPubH.FormattingEnabled = true;
            this.comboBoxPubH.Location = new System.Drawing.Point(485, 289);
            this.comboBoxPubH.Name = "comboBoxPubH";
            this.comboBoxPubH.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPubH.TabIndex = 24;
            // 
            // comboBoxPubLoc
            // 
            this.comboBoxPubLoc.FormattingEnabled = true;
            this.comboBoxPubLoc.Location = new System.Drawing.Point(591, 289);
            this.comboBoxPubLoc.Name = "comboBoxPubLoc";
            this.comboBoxPubLoc.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPubLoc.TabIndex = 25;
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Location = new System.Drawing.Point(697, 288);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLang.TabIndex = 26;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(803, 289);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFormat.TabIndex = 27;
            // 
            // comboBoxPer
            // 
            this.comboBoxPer.FormattingEnabled = true;
            this.comboBoxPer.Location = new System.Drawing.Point(909, 288);
            this.comboBoxPer.Name = "comboBoxPer";
            this.comboBoxPer.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPer.TabIndex = 28;
            // 
            // comboBoxStorL
            // 
            this.comboBoxStorL.FormattingEnabled = true;
            this.comboBoxStorL.Location = new System.Drawing.Point(1015, 288);
            this.comboBoxStorL.Name = "comboBoxStorL";
            this.comboBoxStorL.Size = new System.Drawing.Size(109, 21);
            this.comboBoxStorL.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "id (для изменения или удаления)";
            // 
            // btn_upd_all
            // 
            this.btn_upd_all.Location = new System.Drawing.Point(167, 400);
            this.btn_upd_all.Name = "btn_upd_all";
            this.btn_upd_all.Size = new System.Drawing.Size(100, 23);
            this.btn_upd_all.TabIndex = 32;
            this.btn_upd_all.Text = "Изменить все";
            this.btn_upd_all.UseVisualStyleBackColor = true;
            this.btn_upd_all.Click += new System.EventHandler(this.btn_upd_all_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(289, 400);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 33;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // comboBoxChangeID
            // 
            this.comboBoxChangeID.FormattingEnabled = true;
            this.comboBoxChangeID.Location = new System.Drawing.Point(28, 400);
            this.comboBoxChangeID.Name = "comboBoxChangeID";
            this.comboBoxChangeID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChangeID.TabIndex = 34;
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(61, 327);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(100, 43);
            this.btn_name.TabIndex = 35;
            this.btn_name.Text = "Изменить название";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // btn_author
            // 
            this.btn_author.Location = new System.Drawing.Point(183, 327);
            this.btn_author.Name = "btn_author";
            this.btn_author.Size = new System.Drawing.Size(75, 44);
            this.btn_author.TabIndex = 36;
            this.btn_author.Text = "Изменить автора";
            this.btn_author.UseVisualStyleBackColor = true;
            this.btn_author.Click += new System.EventHandler(this.btn_author_Click);
            // 
            // btn_date
            // 
            this.btn_date.Location = new System.Drawing.Point(289, 327);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(75, 51);
            this.btn_date.TabIndex = 37;
            this.btn_date.Text = "Изменить год издания";
            this.btn_date.UseVisualStyleBackColor = true;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // btn_genre
            // 
            this.btn_genre.Location = new System.Drawing.Point(390, 330);
            this.btn_genre.Name = "btn_genre";
            this.btn_genre.Size = new System.Drawing.Size(75, 45);
            this.btn_genre.TabIndex = 38;
            this.btn_genre.Text = "Изменить жанр";
            this.btn_genre.UseVisualStyleBackColor = true;
            this.btn_genre.Click += new System.EventHandler(this.btn_genre_Click);
            // 
            // btn_pubHouse
            // 
            this.btn_pubHouse.Location = new System.Drawing.Point(498, 327);
            this.btn_pubHouse.Name = "btn_pubHouse";
            this.btn_pubHouse.Size = new System.Drawing.Size(75, 51);
            this.btn_pubHouse.TabIndex = 39;
            this.btn_pubHouse.Text = "Изменить издательство";
            this.btn_pubHouse.UseVisualStyleBackColor = true;
            this.btn_pubHouse.Click += new System.EventHandler(this.btn_pubHouse_Click);
            // 
            // btn_pubLoc
            // 
            this.btn_pubLoc.Location = new System.Drawing.Point(603, 327);
            this.btn_pubLoc.Name = "btn_pubLoc";
            this.btn_pubLoc.Size = new System.Drawing.Size(75, 51);
            this.btn_pubLoc.TabIndex = 40;
            this.btn_pubLoc.Text = "Изменить место издания";
            this.btn_pubLoc.UseVisualStyleBackColor = true;
            this.btn_pubLoc.Click += new System.EventHandler(this.btn_pubLoc_Click);
            // 
            // btn_storLoc
            // 
            this.btn_storLoc.Location = new System.Drawing.Point(710, 335);
            this.btn_storLoc.Name = "btn_storLoc";
            this.btn_storLoc.Size = new System.Drawing.Size(75, 37);
            this.btn_storLoc.TabIndex = 41;
            this.btn_storLoc.Text = "Изменить язык";
            this.btn_storLoc.UseVisualStyleBackColor = true;
            this.btn_storLoc.Click += new System.EventHandler(this.btn_storLoc_Click);
            // 
            // btn_per
            // 
            this.btn_per.Location = new System.Drawing.Point(815, 324);
            this.btn_per.Name = "btn_per";
            this.btn_per.Size = new System.Drawing.Size(75, 63);
            this.btn_per.TabIndex = 42;
            this.btn_per.Text = "Изменить формат книги";
            this.btn_per.UseVisualStyleBackColor = true;
            this.btn_per.Click += new System.EventHandler(this.btn_per_Click);
            // 
            // btn_fromat
            // 
            this.btn_fromat.Location = new System.Drawing.Point(915, 325);
            this.btn_fromat.Name = "btn_fromat";
            this.btn_fromat.Size = new System.Drawing.Size(93, 56);
            this.btn_fromat.TabIndex = 43;
            this.btn_fromat.Text = "Изменить периодичность выхода";
            this.btn_fromat.UseVisualStyleBackColor = true;
            this.btn_fromat.Click += new System.EventHandler(this.btn_fromat_Click);
            // 
            // btn_lang
            // 
            this.btn_lang.Location = new System.Drawing.Point(1031, 329);
            this.btn_lang.Name = "btn_lang";
            this.btn_lang.Size = new System.Drawing.Size(75, 52);
            this.btn_lang.TabIndex = 44;
            this.btn_lang.Text = "Изменить место хранения";
            this.btn_lang.UseVisualStyleBackColor = true;
            this.btn_lang.Click += new System.EventHandler(this.btn_lang_Click);
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.Location = new System.Drawing.Point(262, 289);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(112, 20);
            this.dateTimeCreate.TabIndex = 45;
            // 
            // AdminFormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 450);
            this.Controls.Add(this.dateTimeCreate);
            this.Controls.Add(this.btn_lang);
            this.Controls.Add(this.btn_fromat);
            this.Controls.Add(this.btn_per);
            this.Controls.Add(this.btn_storLoc);
            this.Controls.Add(this.btn_pubLoc);
            this.Controls.Add(this.btn_pubHouse);
            this.Controls.Add(this.btn_genre);
            this.Controls.Add(this.btn_date);
            this.Controls.Add(this.btn_author);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.comboBoxChangeID);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_upd_all);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxStorL);
            this.Controls.Add(this.comboBoxPer);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.comboBoxLang);
            this.Controls.Add(this.comboBoxPubLoc);
            this.Controls.Add(this.comboBoxPubH);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewBook);
            this.Name = "AdminFormBook";
            this.Text = "БД книг Администратор";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxPubH;
        private System.Windows.Forms.ComboBox comboBoxPubLoc;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.ComboBox comboBoxPer;
        private System.Windows.Forms.ComboBox comboBoxStorL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_upd_all;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ComboBox comboBoxChangeID;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Button btn_author;
        private System.Windows.Forms.Button btn_date;
        private System.Windows.Forms.Button btn_genre;
        private System.Windows.Forms.Button btn_pubHouse;
        private System.Windows.Forms.Button btn_pubLoc;
        private System.Windows.Forms.Button btn_storLoc;
        private System.Windows.Forms.Button btn_per;
        private System.Windows.Forms.Button btn_fromat;
        private System.Windows.Forms.Button btn_lang;
        private System.Windows.Forms.DateTimePicker dateTimeCreate;
    }
}