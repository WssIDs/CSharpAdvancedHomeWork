using System;
using System.Linq;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый пункт задания");

            var persons = CharactersRepository.GetCharacters().Select(character => new { PersonDescription = character.ToString() });
            foreach (var person in persons)
            {
                Console.WriteLine(person.PersonDescription);
            }

            Console.WriteLine("Второй пункт задания");

            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var characterstories = characters.GroupJoin(
                stories, 
                character => character.StoryId,
                story => story.Id,
                (character, characterStories) => new
                {
                    character,
                    characterStories
                })
                .SelectMany(groupJoinResult => groupJoinResult.characterStories.DefaultIfEmpty(),
                    (groupJoinResult, story) => new CharacterStory
                    {
                        FirstName = groupJoinResult.character.FirstName,
                        LastName = groupJoinResult.character.LastName,
                        StoryName = story == null ? "Not Story" : story.Name,
                        StoryDescription = story == null ? "Not Description" : story.Description
                    });

            foreach (var characterstory in characterstories)
            {
                Console.WriteLine($"{ characterstory.FirstName} { characterstory.LastName} - { characterstory.StoryName} { characterstory.StoryDescription}");
            }

            Console.WriteLine("Третий пункт задания");
        }
    }
}
