using System;
using HomeWork8.Context;
using Microsoft.EntityFrameworkCore;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new StoryDbContext();
            var characters = context.Characters
                .Include(character => character.Story.Authors);

            foreach (var character in characters)
            {
                Console.WriteLine($"Персонаж {character.FirstName} {character.LastName} | История {character.Story.Name}");
                Console.WriteLine("Авторы:");
                foreach (var author in character.Story.Authors)
                {
                    Console.WriteLine($"Автор {author.FirstName} {author.LastName}");
                }
                Console.WriteLine("________________________________");
            }
        }
    }
}
