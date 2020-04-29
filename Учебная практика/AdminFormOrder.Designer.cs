namespace Учебная_практика
{
    partial class AdminFormOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboReader = new System.Windows.Forms.ComboBox();
            this.comboBook = new System.Windows.Forms.ComboBox();
            this.dateTimeDrop = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reader = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_drop = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.dataGridDebtor = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDebtor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboReader
            // 
            this.comboReader.FormattingEnabled = true;
            this.comboReader.Location = new System.Drawing.Point(28, 214);
            this.comboReader.Name = "comboReader";
            this.comboReader.Size = new System.Drawing.Size(121, 21);
            this.comboReader.TabIndex = 1;
            // 
            // comboBook
            // 
            this.comboBook.FormattingEnabled = true;
            this.comboBook.Location = new System.Drawing.Point(155, 214);
            this.comboBook.Name = "comboBook";
            this.comboBook.Size = new System.Drawing.Size(121, 21);
            this.comboBook.TabIndex = 2;
            // 
            // dateTimeDrop
            // 
            this.dateTimeDrop.Location = new System.Drawing.Point(292, 215);
            this.dateTimeDrop.Name = "dateTimeDrop";
            this.dateTimeDrop.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDrop.TabIndex = 3;
            this.dateTimeDrop.Value = new System.DateTime(2020, 4, 20, 0, 0, 0, 0);
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Location = new System.Drawing.Point(292, 252);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(200, 20);
            this.dateTimeReturn.TabIndex = 4;
            this.dateTimeReturn.Value = new System.DateTime(2020, 4, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Читатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Книга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата выдачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата возврата";
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(209, 379);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID (для изменения/удаления)";
            // 
            // btn_reader
            // 
            this.btn_reader.Location = new System.Drawing.Point(55, 252);
            this.btn_reader.Name = "btn_reader";
            this.btn_reader.Size = new System.Drawing.Size(75, 39);
            this.btn_reader.TabIndex = 11;
            this.btn_reader.Text = "Изменить читателя";
            this.btn_reader.UseVisualStyleBackColor = true;
            this.btn_reader.Click += new System.EventHandler(this.btn_reader_Click);
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(177, 251);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(75, 39);
            this.btn_book.TabIndex = 12;
            this.btn_book.Text = "Изменить книгу";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_drop
            // 
            this.btn_drop.Location = new System.Drawing.Point(503, 212);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(133, 23);
            this.btn_drop.TabIndex = 13;
            this.btn_drop.Text = "Изменить дату выдачи";
            this.btn_drop.UseVisualStyleBackColor = true;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(498, 251);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(145, 23);
            this.btn_return.TabIndex = 14;
            this.btn_return.Text = "Изменить дату возврата";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(55, 377);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(375, 379);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(106, 23);
            this.btn_upd.TabIndex = 16;
            this.btn_upd.Text = "Изменить все";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(503, 379);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 17;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // dataGridDebtor
            // 
            this.dataGridDebtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDebtor.Location = new System.Drawing.Point(656, 85);
            this.dataGridDebtor.Name = "dataGridDebtor";
            this.dataGridDebtor.Size = new System.Drawing.Size(261, 150);
            this.dataGridDebtor.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Должники";
            // 
            // AdminFormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridDebtor);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_drop);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.btn_reader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeReturn);
            this.Controls.Add(this.dateTimeDrop);
            this.Controls.Add(this.comboBook);
            this.Controls.Add(this.comboReader);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminFormOrder";
            this.Text = "Заказ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDebtor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboReader;
        private System.Windows.Forms.ComboBox comboBook;
        private System.Windows.Forms.DateTimePicker dateTimeDrop;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reader;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_drop;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView dataGridDebtor;
        private System.Windows.Forms.Label label6;
    }
}