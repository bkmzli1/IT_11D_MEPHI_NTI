using System;

namespace Labs_7
{
    class UserInfo : IUserInfo,IName
    {
        string ShortName, Family, Name;

        public UserInfo(string Name, string Family, string ShortName)
        {
            this.Name = Name;
            this.Family = Family;
            this.ShortName = ShortName;
        }

        // Используем явную реализацию интерфейсов
        // для исключения неоднозначности
        void IName.WriteName()
        {
            Console.WriteLine("Короткое имя: " + ShortName);
        }

        void INameFamily.WriteFamily()
        {
            Console.WriteLine("Фамилия: " + Family);
        }

        void INameFamily.WriteName()
        {
            Console.WriteLine("Полное имя: " + Name);
        }

        void IUserInfo.WriteName() { }

        public void WriteUserInfo()
        {
            UserInfo obj = new UserInfo(Name, Family, ShortName);
            // Для использования закрытых методов необходимо
            // создать интерфейсную ссылку
            IName link1 = (IName)obj;
            link1.WriteName();
            INameFamily link2 = (INameFamily)obj;
            link2.WriteName();
            link2.WriteFamily();
            IUserInfo link3 = (IUserInfo)obj;
            link3.WriteName();
        }
    }
}