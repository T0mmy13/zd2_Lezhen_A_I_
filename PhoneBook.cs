using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    class PhoneBook
    {

        public List<Contact> list;
        public PhoneBook()
        {
            list = new List<Contact>();
        }
        public bool AddContact(TextBox txt1, TextBox txt2)
        {   
            char[] mas = txt2.Text.ToCharArray();

            if (txt1.Text == "" || txt2.Text == "" || txt1.Text == " " || txt2.Text == " ")
            {
                MessageBox.Show("Пустые поля");
                return false;
            }
            else if (mas.Length >= 2)
            {
                if (mas[0] != '9')
                {
                    MessageBox.Show("Начинаться должно с 9");
                    return false;
                }
                else if (mas.Length != 10)
                {
                    MessageBox.Show($"Короткий номер введите еще {10 - mas.Length} ");
                    return false;
                }
                else
                {
                    string number= $"({txt2.Text[0]}{txt2.Text[1]}{txt2.Text[2]}){txt2.Text[3]}{txt2.Text[4]}{txt2.Text[5]}-{txt2.Text[6]}{txt2.Text[7]}-{txt2.Text[8]}{txt2.Text[9]}";
                    bool proverka = true;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].phone.Contains(number))
                        {
                        proverka = false;     
                        }
                    }
                    if (proverka)
                    {
                        Contact cont = new Contact();
                        cont.name = txt1.Text;
                        cont.phone = number;
                        list.Add(cont);
                        MessageBox.Show("Контакт добавлен");
                    }
                    else
                    {
                        MessageBox.Show("Такой номер уже есть");
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите номер");
                return false;
            }
            return true;
        }
    }
}
