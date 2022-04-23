using System;

namespace Labs_7
{
    public class Program
    {
        static void Main()
        {
            UserInfo obj = new UserInfo(Name: "Alexandr", ShortName: "Alex", Family: "Erohin");
            obj.WriteUserInfo();
            Console.ReadLine();
        }
    }
}