using System;
using System.Linq;
using System.Reflection;
using HomeWork10._1.Classes;
using HomeWork10._2;
using HomeWork10._3.Utils;

namespace HomeWork10._0
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionExample.ReflectionPrivateMethods();

            ReflectionExample.ReflectionMembers();

            var classRoom = new ClassRoom
            {
                Number = 1,
                Name = "Классная комната",
                Owner = "Иванов Иван Иванович"
            };

            SerializeExample.Serialize(classRoom, "classroom.json");

            var loadedClassRoom = SerializeExample.Deserialize<ClassRoom>("classroom.json");

            loadedClassRoom.PrintData();

            var assembly = Assembly.GetAssembly(typeof(_1.Classes.ClassRoom));

            Console.WriteLine(assembly?.GetName());

            var type = assembly?.GetTypes().FirstOrDefault(type => type.Name == "ClassRoom");

            var assemblyClassRoom = (ClassRoom)Activator.CreateInstance(type!);

            assemblyClassRoom?.PrintData();
        }
    }
}
