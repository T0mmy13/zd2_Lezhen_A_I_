using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PhoneBook phoneb = new PhoneBook();

        private void button1_Click(object sender, EventArgs e)
        {
            if (phoneb.AddContact(TextAddCont, TextAddNumber))
            {
                PhoneBookLoader.Save(phoneb);
            }            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void выводВсехКонтактовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelAdd.Visible = false;
            PanelReset.Visible = false;
            ListContacts.Visible = true;
            DelButton.Visible = false;
        }

        private void поискПоИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelAdd.Visible = false;
            PanelReset.Visible = false;
            ListContacts.Visible = false;
            DelButton.Visible = false;
        }

        private void добавлениеКонтактаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListContacts.Visible = false;
            PanelReset.Visible = false;
            PanelAdd.Visible = true;
            DelButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PhoneBookLoader.Load(phoneb);
            PhoneBookLoader.Load(phoneb,ListContacts);            
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void редактированиеКонтактаToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            ListContacts.Visible = true;
            PanelReset.Visible = true;
            PanelAdd.Visible = false;
            DelButton.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            int i = ListContacts.SelectedIndex;
            if (TextResetNumber.Text[0]=='('&&TextResetNumber.Text[1]=='9'&&TextResetNumber.Text.Length==14)
            {
                phoneb.list[i].name = TextResetName.Text;
                MessageBox.Show("Изменено");
                phoneb.list[i].phone = $"({TextResetNumber.Text[1]}{TextResetNumber.Text[2]}{TextResetNumber.Text[3]}){TextResetNumber.Text[5]}{TextResetNumber.Text[6]}{TextResetNumber.Text[7]}-{TextResetNumber.Text[9]}{TextResetNumber.Text[10]}-{TextResetNumber.Text[12]}{TextResetNumber.Text[13]}";
                PhoneBookLoader.Save(phoneb);
                ListContacts.Items.Clear();
                PhoneBookLoader.Load(phoneb, ListContacts);
            }
            if (TextResetNumber.Text[0] == '9' && TextResetNumber.Text.Length == 10)
            {
                phoneb.list[i].name = TextResetName.Text;
                MessageBox.Show("Изменено");
                phoneb.list[i].phone = $"({TextResetNumber.Text[0]}{TextResetNumber.Text[1]}{TextResetNumber.Text[2]}){TextResetNumber.Text[3]}{TextResetNumber.Text[4]}{TextResetNumber.Text[5]}-{TextResetNumber.Text[6]}{TextResetNumber.Text[7]}-{TextResetNumber.Text[8]}{TextResetNumber.Text[9]}";
                PhoneBookLoader.Save(phoneb);
                ListContacts.Items.Clear();
                PhoneBookLoader.Load(phoneb, ListContacts);
            }                            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ListContacts.Items[ListContacts.SelectedIndex].ToString();

            string[] mas = text.Split();

            TextResetName.Text = mas[0]+" "+mas[1];
            TextResetNumber.Text = mas[2];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int d = ListContacts.SelectedIndex;
            DelButton.Visible = true;
            PanelAdd.Visible = false;
            PanelReset.Visible = false;
            ListContacts.Visible = true;
            if (d == -1)
            {
                MessageBox.Show("Выберите контакт");
            }
            else
            {
                phoneb.list.RemoveAt(d);
                ListContacts.Items.Clear();
                PhoneBookLoader.Load(phoneb,ListContacts);
            }
        }

        private void удалениеКонтактаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListContacts.Visible=true;
            DelButton.Visible = true;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            ListContacts.Visible = true;
        }

        private void toolStripTextBox1_Paint(object sender, PaintEventArgs e)
        {
            ListContacts.Items.Clear();
            string Text = toolStripTextBox1.Text.ToString();
            StreamReader sr = new StreamReader("ContactsCSV.txt");
            var contacts = sr.ReadToEnd()
                .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Split(' '))
                .Where(parts => parts.Length >= 3 && parts[0].Contains(Text))
                .Select(parts =>
                    {
                        var name = $"{parts[0]} {parts[1]}";
                        var number = string.Join(" ", parts.Skip(2));
                        return $"{name} {number}";
                    });

            foreach (var contact in contacts)
            {
                ListContacts.Items.Add(contact);
            }
            sr.Close();
        }
    }
}
