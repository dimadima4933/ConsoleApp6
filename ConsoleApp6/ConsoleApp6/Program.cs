using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     public class Program
    {

        static void Main(string[] args)
        {
            

             var result = dictionary(@"C:\g\gg.txt");

             foreach (var key in result.Values)
             {
                 Console.WriteLine(key);
            }
         }
         public static Dictionary<string, int> dictionary(string path)
         {
             Dictionary<string, int> dictionary = new Dictionary<string, int>();
             string filename = path;
             string text = File.ReadAllText(filename, Encoding.Default);
             string[] words = Regex.Split(text, @"(\a\r)?\s+|\W+|\d+");
             List<char> check;
             foreach (string word in words)
             {
                 if (word != "" && word != " ")
                 {
                     check = new List<char>();
                     foreach (char curr in word)
                     {
                         if (((curr >= 65 && curr <= 90) || (curr >= 97 && curr <= 122)) || (curr >= 128 && curr <= 175))
                         {
                             check.Add(curr);
                         }
                     }
                     string add = new string(check.ToArray());

                     if (dictionary.Keys.Contains(add))
                     {
                         dictionary[add]++;
                     }
                     else
                     {
                         dictionary.Add(add, 1);
                     }
                 }
             }
             return dictionary;
         }
        /*    string file = File.ReadAllText("C:\\g\\gg.txt");
            string[] dbb = file.Split(' ');
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (string a in dbb)
            {
                if (words.ContainsKey(a))
                {
                    words[a]++;
                }
                else
                {
                    words.Add(a, 1);
                }
            }
            //words = words.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            //foreach (string item in words.Keys)
            //{
            // Console.WriteLine(item + " " + words[item] );
            //}
            var list = words.Keys.ToList();
            list.Sort(); 
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, words[key]);
            }
        }*/
    }
    }
    
    

