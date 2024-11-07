
namespace Phonebook
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextAddCont = new System.Windows.Forms.TextBox();
            this.TextAddNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddContact = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выводКонтактовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.добавлениеКонтактаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеКонтактаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеКонтактаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.ListContacts = new System.Windows.Forms.ListBox();
            this.PanelReset = new System.Windows.Forms.Panel();
            this.BtnResetContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextResetName = new System.Windows.Forms.TextBox();
            this.TextResetNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DelButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.PanelAdd.SuspendLayout();
            this.PanelReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Контакт";
            // 
            // TextAddCont
            // 
            this.TextAddCont.Location = new System.Drawing.Point(14, 33);
            this.TextAddCont.Name = "TextAddCont";
            this.TextAddCont.Size = new System.Drawing.Size(100, 20);
            this.TextAddCont.TabIndex = 1;
            // 
            // TextAddNumber
            // 
            this.TextAddNumber.Location = new System.Drawing.Point(14, 83);
            this.TextAddNumber.Name = "TextAddNumber";
            this.TextAddNumber.Size = new System.Drawing.Size(100, 20);
            this.TextAddNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер телефона";
            // 
            // BtnAddContact
            // 
            this.BtnAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddContact.Location = new System.Drawing.Point(14, 109);
            this.BtnAddContact.Name = "BtnAddContact";
            this.BtnAddContact.Size = new System.Drawing.Size(112, 51);
            this.BtnAddContact.TabIndex = 4;
            this.BtnAddContact.Text = "Добавить";
            this.BtnAddContact.UseVisualStyleBackColor = true;
            this.BtnAddContact.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводКонтактовToolStripMenuItem,
            this.поискПоИмениToolStripMenuItem,
            this.добавлениеКонтактаToolStripMenuItem,
            this.удалениеКонтактаToolStripMenuItem,
            this.редактированиеКонтактаToolStripMenuItem,
            this.выходИзПрограммыToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Меню";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // выводКонтактовToolStripMenuItem
            // 
            this.выводКонтактовToolStripMenuItem.Name = "выводКонтактовToolStripMenuItem";
            this.выводКонтактовToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.выводКонтактовToolStripMenuItem.Text = "Вывод контактов";
            this.выводКонтактовToolStripMenuItem.Click += new System.EventHandler(this.выводВсехКонтактовToolStripMenuItem_Click);
            // 
            // поискПоИмениToolStripMenuItem
            // 
            this.поискПоИмениToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.поискПоИмениToolStripMenuItem.Name = "поискПоИмениToolStripMenuItem";
            this.поискПоИмениToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.поискПоИмениToolStripMenuItem.Text = "Поиск по имени";
            this.поискПоИмениToolStripMenuItem.Click += new System.EventHandler(this.поискПоИмениToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            this.toolStripTextBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripTextBox1_Paint);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // добавлениеКонтактаToolStripMenuItem
            // 
            this.добавлениеКонтактаToolStripMenuItem.Name = "добавлениеКонтактаToolStripMenuItem";
            this.добавлениеКонтактаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.добавлениеКонтактаToolStripMenuItem.Text = "Добавление контакта";
            this.добавлениеКонтактаToolStripMenuItem.Click += new System.EventHandler(this.добавлениеКонтактаToolStripMenuItem_Click);
            // 
            // удалениеКонтактаToolStripMenuItem
            // 
            this.удалениеКонтактаToolStripMenuItem.Name = "удалениеКонтактаToolStripMenuItem";
            this.удалениеКонтактаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.удалениеКонтактаToolStripMenuItem.Text = "Удаление контакта";
            this.удалениеКонтактаToolStripMenuItem.Click += new System.EventHandler(this.удалениеКонтактаToolStripMenuItem_Click);
            // 
            // редактированиеКонтактаToolStripMenuItem
            // 
            this.редактированиеКонтактаToolStripMenuItem.Name = "редактированиеКонтактаToolStripMenuItem";
            this.редактированиеКонтактаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.редактированиеКонтактаToolStripMenuItem.Text = "Редактирование контакта";
            this.редактированиеКонтактаToolStripMenuItem.Click += new System.EventHandler(this.редактированиеКонтактаToolStripMenuItem_Click);
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.BtnAddContact);
            this.PanelAdd.Controls.Add(this.label2);
            this.PanelAdd.Controls.Add(this.TextAddNumber);
            this.PanelAdd.Controls.Add(this.label1);
            this.PanelAdd.Controls.Add(this.TextAddCont);
            this.PanelAdd.Location = new System.Drawing.Point(12, 28);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(175, 170);
            this.PanelAdd.TabIndex = 6;
            this.PanelAdd.Visible = false;
            // 
            // ListContacts
            // 
            this.ListContacts.FormattingEnabled = true;
            this.ListContacts.Location = new System.Drawing.Point(489, 0);
            this.ListContacts.Name = "ListContacts";
            this.ListContacts.Size = new System.Drawing.Size(311, 446);
            this.ListContacts.TabIndex = 7;
            this.ListContacts.Visible = false;
            this.ListContacts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PanelReset
            // 
            this.PanelReset.Controls.Add(this.BtnResetContact);
            this.PanelReset.Controls.Add(this.label3);
            this.PanelReset.Controls.Add(this.TextResetName);
            this.PanelReset.Controls.Add(this.TextResetNumber);
            this.PanelReset.Controls.Add(this.label4);
            this.PanelReset.Location = new System.Drawing.Point(193, 28);
            this.PanelReset.Name = "PanelReset";
            this.PanelReset.Size = new System.Drawing.Size(173, 170);
            this.PanelReset.TabIndex = 8;
            this.PanelReset.Visible = false;
            // 
            // BtnResetContact
            // 
            this.BtnResetContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnResetContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnResetContact.Location = new System.Drawing.Point(14, 109);
            this.BtnResetContact.Name = "BtnResetContact";
            this.BtnResetContact.Size = new System.Drawing.Size(112, 51);
            this.BtnResetContact.TabIndex = 9;
            this.BtnResetContact.Text = "Изменить";
            this.BtnResetContact.UseVisualStyleBackColor = true;
            this.BtnResetContact.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер телефона";
            // 
            // TextResetName
            // 
            this.TextResetName.Location = new System.Drawing.Point(14, 33);
            this.TextResetName.Name = "TextResetName";
            this.TextResetName.Size = new System.Drawing.Size(100, 20);
            this.TextResetName.TabIndex = 6;
            // 
            // TextResetNumber
            // 
            this.TextResetNumber.Location = new System.Drawing.Point(14, 83);
            this.TextResetNumber.Name = "TextResetNumber";
            this.TextResetNumber.Size = new System.Drawing.Size(100, 20);
            this.TextResetNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Контакт";
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(371, 27);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(112, 66);
            this.DelButton.TabIndex = 9;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Visible = false;
            this.DelButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.PanelReset);
            this.Controls.Add(this.ListContacts);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.PanelReset.ResumeLayout(false);
            this.PanelReset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextAddCont;
        private System.Windows.Forms.TextBox TextAddNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddContact;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выводКонтактовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеКонтактаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеКонтактаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеКонтактаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.ListBox ListContacts;
        private System.Windows.Forms.Panel PanelReset;
        private System.Windows.Forms.Button BtnResetContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextResetName;
        private System.Windows.Forms.TextBox TextResetNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

