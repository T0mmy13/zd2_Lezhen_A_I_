using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    static class PhoneBookLoader
    {
        public static void Load(PhoneBook phoneBook,ListBox list1)
        {
            for (int i = 0; i < phoneBook.list.Count; i++)
            {
                list1.Items.Add($"{phoneBook.list[i].name} {phoneBook.list[i].phone}");
            }
        }
        public static void Load(PhoneBook phoneBook)
        {
            StreamReader sw = File.OpenText("ContactsCSV.txt");
            while (!sw.EndOfStream)
            {
                Contact cont = new Contact();
                string[] mas = sw.ReadLine().Split();
                cont.name = $"{mas[0]} {mas[1]}";
                cont.phone = $"{mas[2]}";
                phoneBook.list.Add(cont);
            }         
        }
        public  static void Save(PhoneBook phoneBook) 
        {
            StreamWriter sw = File.CreateText("Contacts.txt");
            for (int i = 0; i < phoneBook.list.Count; i++)
            {
                sw.WriteLine($"{phoneBook.list[i].name} {phoneBook.list[i].phone}");
            }
            sw.Close(); 
        }
    }
}
