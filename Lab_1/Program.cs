using System;

//lab1
/*
 *
1. Измените приложение, созданное в ходе выполнения данной лабораторной работы таким образом, чтобы программа выводила на экран следующую информа-цию (каждый студент должен использовать персональную информацию о себе):
–  Название и номер лабораторной работы;
–  ФИО студента;
–  Группа студента и шифр специальности;
–  Дата рождения студента;
–  Населенный пункт постоянного места жительства студента;
–  Любимый предмет в школе;
–  Краткое описание увлечений, хобби, интересов.
2. Создайте второй проект. Объявите требуемые переменные, присвойте им начальные значения (определите самостоятельно, значения какого типа могут при-нимать переменные), выведите на экран с использованием форматной строки зна-чения переменных и результат вычисления выражения в соответствие с вариан
с=gh + b * q * 3 - x + y / w;
 * 
 */
namespace Lab_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("№1");
            Students students = new Students();
            Console.WriteLine("Вывод – Название и номер лабораторной работы:" + students.NumberLabs);

            Console.WriteLine("Вывод – ФИО студента:" + students.Fio);
            Console.WriteLine("Вывод – Группа студента и шифр специальности:" + students.SpecialtyСode);
            Console.WriteLine("Вывод – Дата рождения студента:" + students.Birth);
            Console.WriteLine("Вывод – Населенный пункт постоянного места жительства студента:" +
                              students.PlaceOfResidence);
            Console.WriteLine("Вывод – Любимый предмет в школе:" + students.FavoriteSubjectAtSchool);
            Console.WriteLine("Вывод – Краткое описание увлечений, хобби, интересов:" + students.Hobby);
            Console.WriteLine("№2");
            Console.WriteLine(expressionС(readLine("gh"), readLine("b"), readLine("q"), readLine("x"), readLine("y"),
                readLine("w")));
        }

        private static double readLine(String s)
        {
            Console.Write("Введите {0}:", s);
            return Convert.ToDouble(Console.ReadLine());
        }

        private static double expressionС(double gh, double b, double q, double x, double y, double w)
        {
            return gh + (b * q * 3) - x + (y / w);
        }
    }

    class Students
    {
        private int numberLabs = 1;
        private String nameLabs = "КОНСОЛЬНОЕ ПРИЛОЖЕНИЕ C#";
        private String FIO = "Егорушкин Илья Андреевич";
        private String specialtyСode = "ИТ-11Д, 09,03,01";
        private DateTime birth = new DateTime(2001, 6, 5);
        private String placeOfResidence = "624134, обл. Свердловская, г. Новоуральск, ул. Чурина, д. 12/2";
        private String favoriteSubjectAtSchool = "Физика, Математика";
        private String hobby = "Оригамми";

        public int NumberLabs
        {
            get => numberLabs;
            set => numberLabs = value;
        }

        public string NameLabs
        {
            get => nameLabs;
            set => nameLabs = value;
        }

        public string Fio
        {
            get => FIO;
            set => FIO = value;
        }

        public string SpecialtyСode
        {
            get => specialtyСode;
            set => specialtyСode = value;
        }

        public DateTime Birth
        {
            get => birth;
            set => birth = value;
        }

        public string PlaceOfResidence
        {
            get => placeOfResidence;
            set => placeOfResidence = value;
        }

        public string FavoriteSubjectAtSchool
        {
            get => favoriteSubjectAtSchool;
            set => favoriteSubjectAtSchool = value;
        }

        public string Hobby
        {
            get => hobby;
            set => hobby = value;
        }
    }
}

