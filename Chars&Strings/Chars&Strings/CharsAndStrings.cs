using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chars_Strings
{
    internal class CharsAndStrings
    {
        static void Main(string[] args)
        {
            string text = null;
            List<string> wordsList = null;
            List<string> mostLongWords = null;
            int lengthMostLongWords = 0;
            var wordsCount = new Dictionary<string, int>();
            List<string> wordsWithNumber = null;

            char[] letter = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', '&', '@', 'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'э', 'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю' };

            while (true)
            {
                Console.Clear();

                Console.WriteLine("(1)Ввести (заменить) текст;\n(2)Найти слова содержащие максимальное количество цифр;\n(3)Найти самое длинное слово и сколько раз оно повторяется;\n(4)Заменить цифры от 0 до 9 на слова;\n(5)Вывести на экран вопросительные и восклицательные предложения;\n(6)Вывести предложения без запятых;\n(7)Найти слова начинающиеся и заканчивающиеся на одну и ту же букву;\n(8)Поиск слов и фраз;\n(9)Вывести палиндромы;\n\nВыберите действие(введите номер):");

                if (text != null)
                {
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine(text);
                    Console.SetCursorPosition(0, 12);
                }

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        text = Console.ReadLine();
                        wordsCount.Clear();
                        if (wordsList != null)
                        {
                            mostLongWords = null;
                        }
                        if (mostLongWords != null)
                        {
                            mostLongWords = null;
                        }
                        if (lengthMostLongWords != 0)
                        {
                            lengthMostLongWords = 0;
                        }
                        if (wordsWithNumber != null)
                        {
                            mostLongWords = null;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        wordsWithNumber = GetByRegexPattern(text, @"\b\w*\d+\w*\b");
                        int numNum = 0;
                        foreach (string word in wordsWithNumber)
                        {
                            if (numNum < word.Trim(letter).Count())
                            {
                                numNum = word.Trim(letter).Count();
                            }
                        }
                        foreach (string word in wordsWithNumber)
                        {
                            if (numNum == word.Trim(letter).Count())
                            {
                                Console.WriteLine(word);
                            }
                        }
                        Console.WriteLine("\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        wordsList = GetWordsList(text);
                        lengthMostLongWords = GetLengthMostLongWords(wordsList);
                        mostLongWords = GetWordsSertainLength(wordsList, lengthMostLongWords);
                        wordsCount = GetWordsCount(text);
                        for (int i = 0; i < mostLongWords.Count; i++)
                        {
                            Console.WriteLine($"{mostLongWords[i]} - {wordsCount[mostLongWords[i]]} раз(а)\n");
                        }
                        Console.WriteLine("\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Выберите язык замены\n(1)-eng\n(2)-рус");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                text = text.Replace("0", "zero");
                                text = text.Replace("1", "one");
                                text = text.Replace("2", "two");
                                text = text.Replace("3", "three");
                                text = text.Replace("4", "four");
                                text = text.Replace("5", "five");
                                text = text.Replace("6", "six");
                                text = text.Replace("7", "seven");
                                text = text.Replace("8", "eight");
                                text = text.Replace("9", "nine");
                                break;
                            case 2:
                                text = text.Replace("0", "ноль");
                                text = text.Replace("1", "один");
                                text = text.Replace("2", "два");
                                text = text.Replace("3", "три");
                                text = text.Replace("4", "четыре");
                                text = text.Replace("5", "пять");
                                text = text.Replace("6", "шесть");
                                text = text.Replace("7", "семь");
                                text = text.Replace("8", "восемь");
                                text = text.Replace("9", "девять");
                                break;
                        }
                        wordsCount.Clear();
                        if (wordsList != null)
                        {
                            mostLongWords = null;
                        }
                        if (mostLongWords != null)
                        {
                            mostLongWords = null;
                        }
                        if (lengthMostLongWords != 0)
                        {
                            lengthMostLongWords = 0;
                        }
                        if (wordsWithNumber != null)
                        {
                            mostLongWords = null;
                        }
                        Console.WriteLine("\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        List<string> sentencesInterrogativeAndOrExclamatory = GetByRegexPattern(text, @"\S.*?[?!]");
                        PrintList(sentencesInterrogativeAndOrExclamatory);
                        sentencesInterrogativeAndOrExclamatory.Clear();
                        Console.WriteLine("\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        List<string> sentencesWithoutСommas = GetByRegexPattern(text, @"\S.*?[^\,\][\.\?!]");
                        PrintList(sentencesWithoutСommas);
                        sentencesWithoutСommas.Clear();
                        Console.WriteLine("\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        wordsList = GetWordsList(text);
                        foreach (string word in wordsList)
                        {
                            if (word[1] == word[word.Length - 1] && word.Length != 1)
                            {
                                Console.WriteLine(word);
                            }
                        }
                        Console.WriteLine("\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Write("Введите слово или фразу: ");
                        string searchInput = Console.ReadLine();
                        /*if (text.Contains(searchInput) != true)
                        {
                            Console.Clear();
                            Console.WriteLine("\nНет такого");
                            Console.WriteLine("\nНажмите любую клавишу для продолжения");
                            Console.ReadKey();
                            break;
                        }*/
                        Queue<string> pieces = new Queue<string>();
                        Console.SetCursorPosition(0, 15);
                        string restOfText = text.ToLower();
                        while (restOfText.Contains(searchInput))
                        {
                            int index = restOfText.IndexOf(searchInput);
                            pieces.Enqueue(restOfText.Substring(0, index));
                            restOfText = restOfText.Substring((index + searchInput.Length));
                        }
                        while (pieces.Count != 0)
                        {
                            Console.Write(pieces.Dequeue());
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(searchInput);
                            Console.ResetColor();
                        }
                        Console.SetCursorPosition(0, 14);
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        wordsList = GetWordsList(text);
                        foreach (string word in wordsList)
                        {
                            bool checkFail = false;
                            Stack<char> stack = new Stack<char>();
                            Queue<char> queue = new Queue<char>();
                            foreach (char c in word)
                            { 
                                stack.Push(c);
                                queue.Enqueue(c);
                            }
                            for (int i = 1; i*2 <= stack.Count; i++)
                            { 
                                char s = stack.Pop();
                                char q = queue.Dequeue();
                                if (q != s)
                                {
                                    checkFail = true;
                                    break;
                                }
                            }
                            if (checkFail)
                            {
                                break;
                            }
                            Console.WriteLine(word);
                        }
                        Console.WriteLine("\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;


                }


            }
        }
        public static Dictionary<string, int> GetWordsCount(string _text)
        {
            _text = _text.ToLower();
            var wordsCount = new Dictionary<string, int>();
            string[] words = _text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\'', '\"', '-', '_', '—' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                //words[i]=words[i].Trim('0','1','2','3','4','5','6','7','8','9');
                if (wordsCount.ContainsKey(words[i]) == false)
                {
                    wordsCount.Add(words[i], 0);
                }
                wordsCount[words[i]]++;
            }
            return wordsCount;
        }
        public static List<string> GetWordsList(string _text)
        {
            _text = _text.ToLower().Trim( '.', ',', '!', '?', ';', ':', '\'', '\"', '-', '_', '—' );
            var wordsList = new List<string>();
            string[] words = _text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\'', '\"', '-', '_', '—' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (wordsList.Contains(words[i]) == false)
                {
                    wordsList.Add(words[i]);
                }
            }
            return wordsList;
        }
        public static int GetLengthMostLongWords(List<string> wordsList)
        {
            int maxLength = 0;
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (wordsList[i].Length > maxLength)
                {
                    maxLength = wordsList[i].Length;
                }
            }
            return maxLength;
        }
        public static List<string> GetWordsSertainLength(List<string> wordsList, int length)
        {
            List<string> wordsSertainLength = new List<string>();
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (wordsList[i].Length == length)
                {
                    wordsSertainLength.Add(wordsList[i]);
                }
            }
            return wordsSertainLength;
        }
        public static List<string> GetByRegexPattern(string _text, string _pattern)
        {
            _text = _text.ToLower();

            List<string> wordsWithNumbers = Regex.Matches(_text, _pattern).Cast<Match>().Select(x => x.Value).ToList();

            return wordsWithNumbers;
        }
        public static void PrintList(List<string> _list)
        {
            /*for (int i = 0; i < _list.Count; i++)
            {
                Console.WriteLine($"{_list[i]}\n");
            }*/
            foreach (string word in _list)
            {
                Console.WriteLine(word);
            }
        }
    }
}
