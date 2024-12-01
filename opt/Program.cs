using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opt
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
            Dictionary<string, int> wordCounts = WordFrequency(text);

            foreach (var item in wordCounts)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

        static Dictionary<string, int> WordFrequency(string text)
        {


            string[] words = text.ToLower().Split(' '); //изначально приравниваем строку к нижнему регистру
            Dictionary<string, int> result = new Dictionary<string, int>();

            //лучше использовать foreach так код более читабельный и производительней   
            foreach (var item in words)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++; // убираем ненужную переменную
                }
                else
                {
                    result.Add(item, 1);
                }
            }

            return result;
        }
    }
}
