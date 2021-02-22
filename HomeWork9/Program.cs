using System;
using System.IO;
using System.Linq;
using System.Reflection;
using HomeWork9.Classes;
using HomeWork9.Context;
using Microsoft.EntityFrameworkCore;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            var fi = new FileInfo(@"TestDir\test.txt");

            try
            {
                fi.Create();
            }
            catch (Exception ex)
            {
                if (!Directory.Exists("TestDir"))
                {
                    Directory.CreateDirectory("TestDir");
                }

                fi.Create();
            }

            var component = new CustomComponent();

            var type = component.GetType();

            var methodInfos = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(mi => mi.CustomAttributes.Any(ca => ca.AttributeType == typeof(CustomAttribute)));

            foreach (var methodInfo in methodInfos)
            {
                var attribute = methodInfo.CustomAttributes.FirstOrDefault(ca => ca.AttributeType == typeof(CustomAttribute));
                Console.WriteLine($"Метод {methodInfo.Name} {attribute.ConstructorArguments.FirstOrDefault().Value} {attribute.NamedArguments.FirstOrDefault().TypedValue.Value}");   
            }
        }
    }
}
