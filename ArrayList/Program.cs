using System;

namespace ArrayList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new System.Collections.ArrayList();
            //добавление одиночных элементов
            string s = "Hello";
            list.Add(s);
            list.Add("hi");
            list.Add(50);
            list.Add(new object());
           
            //добавление групп элементов
            var anArray = new[] {"more", "or", "and"};
            list.AddRange(anArray);
            var anatheArrey = new[] {new object(), new System.Collections.ArrayList()};
            list.Add(anatheArrey);
        }
    }
}