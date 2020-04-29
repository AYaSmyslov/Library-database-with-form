namespace Учебная_практика
{
    partial class RegForm
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
            this.textSName = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextStreet = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textSPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textSName
            // 
            this.textSName.Location = new System.Drawing.Point(12, 33);
            this.textSName.Name = "textSName";
            this.textSName.Size = new System.Drawing.Size(122, 20);
            this.textSName.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(140, 33);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(122, 20);
            this.textName.TabIndex = 1;
            // 
            // textDName
            // 
            this.textDName.Location = new System.Drawing.Point(268, 33);
            this.textDName.Name = "textDName";
            this.textDName.Size = new System.Drawing.Size(122, 20);
            this.textDName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // richTextStreet
            // 
            this.richTextStreet.Location = new System.Drawing.Point(12, 101);
            this.richTextStreet.Name = "richTextStreet";
            this.richTextStreet.Size = new System.Drawing.Size(250, 96);
            this.richTextStreet.TabIndex = 6;
            this.richTextStreet.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Адрес";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(268, 101);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(122, 20);
            this.textPhone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Телефон";
            // 
            // textFPass
            // 
            this.textFPass.Location = new System.Drawing.Point(12, 223);
            this.textFPass.Name = "textFPass";
            this.textFPass.Size = new System.Drawing.Size(122, 20);
            this.textFPass.TabIndex = 10;
            this.textFPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Пароль";
            // 
            // textSPass
            // 
            this.textSPass.Location = new System.Drawing.Point(12, 275);
            this.textSPass.Name = "textSPass";
            this.textSPass.Size = new System.Drawing.Size(122, 20);
            this.textSPass.TabIndex = 12;
            this.textSPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Пароль еще раз";
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(208, 239);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(112, 33);
            this.btn_reg.TabIndex = 14;
            this.btn_reg.Text = "Создать профиль";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 313);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textFPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textSName);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_reg;
    }
}