namespace Учебная_практика
{
    partial class AdminForm
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
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_reader = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_etc = new System.Windows.Forms.Button();
            this.btn_ChPass = new System.Windows.Forms.Button();
            this.textFPass = new System.Windows.Forms.TextBox();
            this.textSPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(53, 12);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(75, 23);
            this.btn_book.TabIndex = 0;
            this.btn_book.Text = "Книги";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_reader
            // 
            this.btn_reader.Location = new System.Drawing.Point(53, 54);
            this.btn_reader.Name = "btn_reader";
            this.btn_reader.Size = new System.Drawing.Size(75, 23);
            this.btn_reader.TabIndex = 1;
            this.btn_reader.Text = "Читатели";
            this.btn_reader.UseVisualStyleBackColor = true;
            this.btn_reader.Click += new System.EventHandler(this.btn_reader_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(53, 95);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "Заказы";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_etc
            // 
            this.btn_etc.Location = new System.Drawing.Point(13, 134);
            this.btn_etc.Name = "btn_etc";
            this.btn_etc.Size = new System.Drawing.Size(158, 23);
            this.btn_etc.TabIndex = 3;
            this.btn_etc.Text = "Доп. информация о книгах";
            this.btn_etc.UseVisualStyleBackColor = true;
            this.btn_etc.Click += new System.EventHandler(this.btn_etc_Click);
            // 
            // btn_ChPass
            // 
            this.btn_ChPass.Location = new System.Drawing.Point(219, 134);
            this.btn_ChPass.Name = "btn_ChPass";
            this.btn_ChPass.Size = new System.Drawing.Size(118, 23);
            this.btn_ChPass.TabIndex = 4;
            this.btn_ChPass.Text = "Сменить пароль";
            this.btn_ChPass.UseVisualStyleBackColor = true;
            this.btn_ChPass.Click += new System.EventHandler(this.btn_ChPass_Click);
            // 
            // textFPass
            // 
            this.textFPass.Location = new System.Drawing.Point(219, 44);
            this.textFPass.Name = "textFPass";
            this.textFPass.Size = new System.Drawing.Size(100, 20);
            this.textFPass.TabIndex = 5;
            this.textFPass.UseSystemPasswordChar = true;
            // 
            // textSPass
            // 
            this.textSPass.Location = new System.Drawing.Point(219, 95);
            this.textSPass.Name = "textSPass";
            this.textSPass.Size = new System.Drawing.Size(100, 20);
            this.textSPass.TabIndex = 6;
            this.textSPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Новый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Повторите новый пароль";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 172);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSPass);
            this.Controls.Add(this.textFPass);
            this.Controls.Add(this.btn_ChPass);
            this.Controls.Add(this.btn_etc);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_reader);
            this.Controls.Add(this.btn_book);
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_reader;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_etc;
        private System.Windows.Forms.Button btn_ChPass;
        private System.Windows.Forms.TextBox textFPass;
        private System.Windows.Forms.TextBox textSPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}