namespace Учебная_практика
{
    partial class UserProfileForm
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
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.btn_makeOrder = new System.Windows.Forms.Button();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.btn_filter = new System.Windows.Forms.Button();
            this.textBoxFid = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxFAuthor = new System.Windows.Forms.TextBox();
            this.dateTimeCreate = new System.Windows.Forms.DateTimePicker();
            this.textBoxFGenre = new System.Windows.Forms.TextBox();
            this.textBoxFPubH = new System.Windows.Forms.TextBox();
            this.textBoxFPubL = new System.Windows.Forms.TextBox();
            this.textBoxFLang = new System.Windows.Forms.TextBox();
            this.textBoxFFormat = new System.Windows.Forms.TextBox();
            this.textBoxFStorL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chID = new System.Windows.Forms.CheckBox();
            this.chName = new System.Windows.Forms.CheckBox();
            this.chAuthor = new System.Windows.Forms.CheckBox();
            this.chCreate = new System.Windows.Forms.CheckBox();
            this.chGenre = new System.Windows.Forms.CheckBox();
            this.chPubH = new System.Windows.Forms.CheckBox();
            this.chPubLoc = new System.Windows.Forms.CheckBox();
            this.chLang = new System.Windows.Forms.CheckBox();
            this.chFromat = new System.Windows.Forms.CheckBox();
            this.chStorageLoc = new System.Windows.Forms.CheckBox();
            this.chPer = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxFPer = new System.Windows.Forms.TextBox();
            this.dateTimeDrop = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textFPass = new System.Windows.Forms.TextBox();
            this.textSPass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_ChPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(12, 23);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.Size = new System.Drawing.Size(352, 150);
            this.dataGridOrders.TabIndex = 0;
            // 
            // btn_makeOrder
            // 
            this.btn_makeOrder.Location = new System.Drawing.Point(380, 12);
            this.btn_makeOrder.Name = "btn_makeOrder";
            this.btn_makeOrder.Size = new System.Drawing.Size(117, 23);
            this.btn_makeOrder.TabIndex = 1;
            this.btn_makeOrder.Text = "Заказать книгу";
            this.btn_makeOrder.UseVisualStyleBackColor = true;
            this.btn_makeOrder.Click += new System.EventHandler(this.btn_makeOrder_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(380, 70);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "id книги";
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(12, 257);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.Size = new System.Drawing.Size(1258, 219);
            this.dataGridBooks.TabIndex = 4;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(1195, 134);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 5;
            this.btn_filter.Text = "Фильтр";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // textBoxFid
            // 
            this.textBoxFid.Location = new System.Drawing.Point(12, 193);
            this.textBoxFid.Name = "textBoxFid";
            this.textBoxFid.Size = new System.Drawing.Size(100, 20);
            this.textBoxFid.TabIndex = 6;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(118, 193);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFName.TabIndex = 7;
            // 
            // textBoxFAuthor
            // 
            this.textBoxFAuthor.Location = new System.Drawing.Point(224, 193);
            this.textBoxFAuthor.Name = "textBoxFAuthor";
            this.textBoxFAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxFAuthor.TabIndex = 8;
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.Location = new System.Drawing.Point(330, 193);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(121, 20);
            this.dateTimeCreate.TabIndex = 9;
            // 
            // textBoxFGenre
            // 
            this.textBoxFGenre.Location = new System.Drawing.Point(457, 193);
            this.textBoxFGenre.Name = "textBoxFGenre";
            this.textBoxFGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxFGenre.TabIndex = 10;
            // 
            // textBoxFPubH
            // 
            this.textBoxFPubH.Location = new System.Drawing.Point(563, 193);
            this.textBoxFPubH.Name = "textBoxFPubH";
            this.textBoxFPubH.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPubH.TabIndex = 11;
            // 
            // textBoxFPubL
            // 
            this.textBoxFPubL.Location = new System.Drawing.Point(669, 193);
            this.textBoxFPubL.Name = "textBoxFPubL";
            this.textBoxFPubL.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPubL.TabIndex = 12;
            // 
            // textBoxFLang
            // 
            this.textBoxFLang.Location = new System.Drawing.Point(775, 193);
            this.textBoxFLang.Name = "textBoxFLang";
            this.textBoxFLang.Size = new System.Drawing.Size(100, 20);
            this.textBoxFLang.TabIndex = 13;
            // 
            // textBoxFFormat
            // 
            this.textBoxFFormat.Location = new System.Drawing.Point(881, 193);
            this.textBoxFFormat.Name = "textBoxFFormat";
            this.textBoxFFormat.Size = new System.Drawing.Size(100, 20);
            this.textBoxFFormat.TabIndex = 14;
            // 
            // textBoxFStorL
            // 
            this.textBoxFStorL.Location = new System.Drawing.Point(1095, 193);
            this.textBoxFStorL.Name = "textBoxFStorL";
            this.textBoxFStorL.Size = new System.Drawing.Size(100, 20);
            this.textBoxFStorL.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Автор";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дата издания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Жанр";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Издательство";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(675, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Место издания";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(782, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Язык";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(890, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Формат книги";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1095, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Место хранения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "БД библиотеки";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ваши заказы";
            // 
            // chID
            // 
            this.chID.AutoSize = true;
            this.chID.Location = new System.Drawing.Point(57, 219);
            this.chID.Name = "chID";
            this.chID.Size = new System.Drawing.Size(15, 14);
            this.chID.TabIndex = 28;
            this.chID.UseVisualStyleBackColor = true;
            // 
            // chName
            // 
            this.chName.AutoSize = true;
            this.chName.Location = new System.Drawing.Point(163, 218);
            this.chName.Name = "chName";
            this.chName.Size = new System.Drawing.Size(15, 14);
            this.chName.TabIndex = 29;
            this.chName.UseVisualStyleBackColor = true;
            // 
            // chAuthor
            // 
            this.chAuthor.AutoSize = true;
            this.chAuthor.Location = new System.Drawing.Point(263, 218);
            this.chAuthor.Name = "chAuthor";
            this.chAuthor.Size = new System.Drawing.Size(15, 14);
            this.chAuthor.TabIndex = 30;
            this.chAuthor.UseVisualStyleBackColor = true;
            // 
            // chCreate
            // 
            this.chCreate.AutoSize = true;
            this.chCreate.Location = new System.Drawing.Point(380, 219);
            this.chCreate.Name = "chCreate";
            this.chCreate.Size = new System.Drawing.Size(15, 14);
            this.chCreate.TabIndex = 31;
            this.chCreate.UseVisualStyleBackColor = true;
            // 
            // chGenre
            // 
            this.chGenre.AutoSize = true;
            this.chGenre.Location = new System.Drawing.Point(498, 218);
            this.chGenre.Name = "chGenre";
            this.chGenre.Size = new System.Drawing.Size(15, 14);
            this.chGenre.TabIndex = 32;
            this.chGenre.UseVisualStyleBackColor = true;
            // 
            // chPubH
            // 
            this.chPubH.AutoSize = true;
            this.chPubH.Location = new System.Drawing.Point(605, 218);
            this.chPubH.Name = "chPubH";
            this.chPubH.Size = new System.Drawing.Size(15, 14);
            this.chPubH.TabIndex = 33;
            this.chPubH.UseVisualStyleBackColor = true;
            // 
            // chPubLoc
            // 
            this.chPubLoc.AutoSize = true;
            this.chPubLoc.Location = new System.Drawing.Point(709, 218);
            this.chPubLoc.Name = "chPubLoc";
            this.chPubLoc.Size = new System.Drawing.Size(15, 14);
            this.chPubLoc.TabIndex = 34;
            this.chPubLoc.UseVisualStyleBackColor = true;
            // 
            // chLang
            // 
            this.chLang.AutoSize = true;
            this.chLang.Location = new System.Drawing.Point(815, 218);
            this.chLang.Name = "chLang";
            this.chLang.Size = new System.Drawing.Size(15, 14);
            this.chLang.TabIndex = 35;
            this.chLang.UseVisualStyleBackColor = true;
            // 
            // chFromat
            // 
            this.chFromat.AutoSize = true;
            this.chFromat.Location = new System.Drawing.Point(922, 219);
            this.chFromat.Name = "chFromat";
            this.chFromat.Size = new System.Drawing.Size(15, 14);
            this.chFromat.TabIndex = 36;
            this.chFromat.UseVisualStyleBackColor = true;
            // 
            // chStorageLoc
            // 
            this.chStorageLoc.AutoSize = true;
            this.chStorageLoc.Location = new System.Drawing.Point(1140, 218);
            this.chStorageLoc.Name = "chStorageLoc";
            this.chStorageLoc.Size = new System.Drawing.Size(15, 14);
            this.chStorageLoc.TabIndex = 37;
            this.chStorageLoc.UseVisualStyleBackColor = true;
            // 
            // chPer
            // 
            this.chPer.AutoSize = true;
            this.chPer.Location = new System.Drawing.Point(1026, 218);
            this.chPer.Name = "chPer";
            this.chPer.Size = new System.Drawing.Size(15, 14);
            this.chPer.TabIndex = 38;
            this.chPer.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(984, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Периодичность";
            // 
            // textBoxFPer
            // 
            this.textBoxFPer.Location = new System.Drawing.Point(987, 193);
            this.textBoxFPer.Name = "textBoxFPer";
            this.textBoxFPer.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPer.TabIndex = 40;
            // 
            // dateTimeDrop
            // 
            this.dateTimeDrop.Location = new System.Drawing.Point(524, 71);
            this.dateTimeDrop.Name = "dateTimeDrop";
            this.dateTimeDrop.Size = new System.Drawing.Size(139, 20);
            this.dateTimeDrop.TabIndex = 41;
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Location = new System.Drawing.Point(669, 71);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(125, 20);
            this.dateTimeReturn.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(538, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Дата доставки";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(686, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Дата возврата";
            // 
            // textFPass
            // 
            this.textFPass.Location = new System.Drawing.Point(956, 36);
            this.textFPass.Name = "textFPass";
            this.textFPass.Size = new System.Drawing.Size(100, 20);
            this.textFPass.TabIndex = 45;
            this.textFPass.UseSystemPasswordChar = true;
            // 
            // textSPass
            // 
            this.textSPass.Location = new System.Drawing.Point(956, 88);
            this.textSPass.Name = "textSPass";
            this.textSPass.Size = new System.Drawing.Size(100, 20);
            this.textSPass.TabIndex = 46;
            this.textSPass.UseSystemPasswordChar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(953, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Новый пароль";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(952, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "Повторите новый пароль";
            // 
            // btn_ChPass
            // 
            this.btn_ChPass.Location = new System.Drawing.Point(948, 114);
            this.btn_ChPass.Name = "btn_ChPass";
            this.btn_ChPass.Size = new System.Drawing.Size(121, 23);
            this.btn_ChPass.TabIndex = 49;
            this.btn_ChPass.Text = "Поменять пароль";
            this.btn_ChPass.UseVisualStyleBackColor = true;
            this.btn_ChPass.Click += new System.EventHandler(this.btn_ChPass_Click);
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 485);
            this.Controls.Add(this.btn_ChPass);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textSPass);
            this.Controls.Add(this.textFPass);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimeReturn);
            this.Controls.Add(this.dateTimeDrop);
            this.Controls.Add(this.textBoxFPer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chPer);
            this.Controls.Add(this.chStorageLoc);
            this.Controls.Add(this.chFromat);
            this.Controls.Add(this.chLang);
            this.Controls.Add(this.chPubLoc);
            this.Controls.Add(this.chPubH);
            this.Controls.Add(this.chGenre);
            this.Controls.Add(this.chCreate);
            this.Controls.Add(this.chAuthor);
            this.Controls.Add(this.chName);
            this.Controls.Add(this.chID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFStorL);
            this.Controls.Add(this.textBoxFFormat);
            this.Controls.Add(this.textBoxFLang);
            this.Controls.Add(this.textBoxFPubL);
            this.Controls.Add(this.textBoxFPubH);
            this.Controls.Add(this.textBoxFGenre);
            this.Controls.Add(this.dateTimeCreate);
            this.Controls.Add(this.textBoxFAuthor);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxFid);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.dataGridBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.btn_makeOrder);
            this.Controls.Add(this.dataGridOrders);
            this.Name = "UserProfileForm";
            this.Text = "Профиль";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Button btn_makeOrder;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox textBoxFid;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxFAuthor;
        private System.Windows.Forms.DateTimePicker dateTimeCreate;
        private System.Windows.Forms.TextBox textBoxFGenre;
        private System.Windows.Forms.TextBox textBoxFPubH;
        private System.Windows.Forms.TextBox textBoxFPubL;
        private System.Windows.Forms.TextBox textBoxFLang;
        private System.Windows.Forms.TextBox textBoxFFormat;
        private System.Windows.Forms.TextBox textBoxFStorL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chID;
        private System.Windows.Forms.CheckBox chName;
        private System.Windows.Forms.CheckBox chAuthor;
        private System.Windows.Forms.CheckBox chCreate;
        private System.Windows.Forms.CheckBox chGenre;
        private System.Windows.Forms.CheckBox chPubH;
        private System.Windows.Forms.CheckBox chPubLoc;
        private System.Windows.Forms.CheckBox chLang;
        private System.Windows.Forms.CheckBox chFromat;
        private System.Windows.Forms.CheckBox chStorageLoc;
        private System.Windows.Forms.CheckBox chPer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxFPer;
        private System.Windows.Forms.DateTimePicker dateTimeDrop;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textFPass;
        private System.Windows.Forms.TextBox textSPass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_ChPass;
    }
}