using System;
using System.Reflection;
using HomeWork10._1.Classes;

namespace HomeWork10._2
{
    public static class ReflectionExample
    {
        public static void ReflectionPrivateMethods()
        {
            var type = typeof(ClassRoom);

            var mi = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            Console.WriteLine("Приватные методы класса:");
            foreach (var methodInfo in mi)
            {
                Console.WriteLine($"Метод: {methodInfo.Name}");
            }
        }

        public static void ReflectionMembers()
        {
            var type = typeof(ClassRoom);
            var memberInfos = type.GetMembers(BindingFlags.CreateInstance | BindingFlags.Instance |
                                              BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

            Console.WriteLine("Члены класса:");
            foreach (var memberInfo in memberInfos)
            {
                Console.WriteLine($"{memberInfo.Name}");
            }
        }
    }
}
