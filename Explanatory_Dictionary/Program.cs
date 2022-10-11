using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explanatory_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            bool isWork = true;
            dictionary.Add("курс", "Весь объём какого-либо обучения, лечебных процедур и т. п.");
            dictionary.Add("программист", "Специалист по программированию, составлению программ для ЭВМ.");
            dictionary.Add("компьютер", "Электронно-вычислительная машина (ЭВМ).");
            dictionary.Add("браузер", "Программа для поиска и просмотра на экране компьютера информации из компьютерной сети.");
            dictionary.Add("процессор", "Центральная часть компьютера, выполняющая заданные программой преобразования информации и осуществляющая управление всем вычислительным процессом.");
           
            while (isWork)
            {
                Console.WriteLine("Добро пожаловать в толковый словарь из пяти слов: ");

                foreach (var word in dictionary)
                {
                    Console.WriteLine(word.Key);
                }

                GetUserInput(dictionary,out isWork);
                Console.ReadKey();
                Console.Clear();  
            }            
        }

        static void GetUserInput(Dictionary<string, string> dictionary,out bool iswork)
        {
            iswork = true;
            Console.WriteLine("Введите значение слова, значение которого хотите узнать. Введите 'exit' для завершения работы программы");
            string userInput = Console.ReadLine();

            if (dictionary.ContainsKey(userInput))
            {
                Console.WriteLine($"Слово - '{userInput}' имеет значение: {dictionary[userInput]}");
            }
            else if (userInput == "exit")
            {
                iswork = false;
            }
            else
            {
                Console.WriteLine("Такого слова в словаре нет");
            }
        }
    }
}
