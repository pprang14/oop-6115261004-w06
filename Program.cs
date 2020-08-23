using System;

namespace oop_6115261004_w06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person("Chirapat", "", 26000, "Lecturer");
            Person per2 = new Person("wannakarn", "", 16000, "Staff");
            Person per3 = new Person("katiya", "", 15000, "Staff");
            Faculty f1 = new Faculty("Faculty of Educational");
            f1.setPerson(per1, 0);
            f1.setPerson(per2, 1);
            f1.setPerson(per3, 2);
            f1.printAll();

        }
    }
}
