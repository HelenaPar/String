using System;
using System.Linq;
using System.Text;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
           // StringBuilder sb = new StringBuilder();
            string s1 = Console.ReadLine();
            string[] words = s1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] n = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            while (true)
            {
                Console.WriteLine("Меню: ");
            Console.WriteLine("1 - Найти слова, содержащие максимальное количество цифр");
            Console.WriteLine("2 - Самое длинное слово и сколько раз оно повторяется");
            Console.WriteLine("3 - Заменить цифры от 0 до 9 на \"ноль\" и тд.");
            Console.WriteLine("4 - Вывести сначала вопросительные, потом восклицательные");
            Console.WriteLine("5 - Вывести предложения, не содержащие запятых");
            Console.WriteLine("6 - Найти слова, которые заканчиваются и начинаются на одну и ту же букву");
            int r = Convert.ToInt32(Console.ReadLine());
            string g = "";
            int max = 0;
           
                switch (r)
                {
                    case 1:
                        foreach (string word in words)
                        {
                            int count1 = 0;
                            
                            for (int i = 0; i < word.Length; i++) {
                               
                                if (Char.IsDigit(word[i]))
                                {
                                    count1++;
                                }
                                if (count1 > max)
                                {
                                    max = count1;
                                    g = word;
                               
                            }
                                
                            }
                           
                        }
                        Console.WriteLine(g);
                        break;
                    case 2:
                        int max1 = 0;
                        string pl = " ";
                        int kol = 0;
                        foreach (string word in words)
                        {
                            for (int i = 0; i < word.Length; i++) 
                            {
                                if(word.Length > max1)
                                {
                                    max1 = word.Length;
                                    pl = word;
                                }
                            }
                        }
                        foreach (string word in words)
                        {
                            if (word == pl)
                            {
                                kol++;
                            }
                        }
                            Console.WriteLine("Слово: " + pl + " повторяется " + kol + " раз");
                                    break;
                    case 3:
                        string s2 = "";
                        s2 = s1.Replace("1", "один").Replace("2", "два").Replace("3", "три").Replace("4", "четыре").Replace("5", "пять").Replace("6", "шесть").Replace("7", "семь").Replace("8", "восемь").Replace("9", "девять").Replace("0", "ноль");                        
                        Console.WriteLine(s2);
                        break;
                    case 4:
                        string pred = "";
                        string[] word1 = s1.Split('.'); //StringSplitOptions.RemoveEmptyEntries);
                        string vos = "";
                        string vopr = "";
                        string ob = "";
                        foreach (string word in word1)
                        {
                            if (word.Contains('?'))
                            {
                                vopr = word.Trim(); 
                              // Console.Write(word.Trim());
                            }
                           
                        }
                        foreach (string word in word1)
                        {
                         if (word.Contains('!'))
                            {
                                vos = word.Trim();
                               // Console.Write(word.Trim());
                            }
                        }
                         Console.WriteLine(vopr + vos);
                        //    else if (word.Contains('.') == true)
                        //        {
                        //            Console.WriteLine(word.Trim());
                        //            ob = word;
                        //        }
                        //}
                        //Console.WriteLine(vopr + " " + vos + "" + ob);
                        break;
                    case 5:
                        string zap = "";
                        string[] word2 = s1.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in word2)
                        {
                                if(!word.Contains(','))
                                {
                                    Console.WriteLine(word.Trim());
                                }
                        }
                        break;
                    case 6:
                        int k = 0;
                        string ss1 = " ";
                        foreach (string word in words)
                        {
                            for (int i = 0; i < word.Length; i++)
                            {
                                   // ss1 = ss1 + word;
                               
                                  //  if (ss1[0] == ss1[ss1.Length - 1])
                                    if (word[0] == word[word.Length - 1])
                                    {
                                        ss1 = word; 
                                        k++;
                                        Console.WriteLine(ss1);
                                    }
                            }
                        }
                        if (k == 0)
                        {
                            Console.WriteLine("Нет слов, начинающихся и заканчивающихся на одну и ту же букву");
                        }
                        break;
                    default:
                        Console.WriteLine("Не верный номер! Введите число от 1 до 6 включительно!");
                        break;
                }
            }
        }
    }
}
