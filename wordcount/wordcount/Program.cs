using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace wordcount
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = args[0];
            StreamReader sr = new StreamReader(url, Encoding.Default);
            string line;
            line = sr.ReadToEnd();
            Console.WriteLine(line);
            Console.WriteLine("WordCount：" + wordcount.CountWords1(line));
        }
    }
    public static class wordcount
    {
        public static int CountWords1(string s)
        {
            MatchCollection collection = Regex.Matches(s, @"[\S]+");
            return collection.Count;
        }
        public static int CountWords2(string s)
        {
            int c = 0;
            for (int i=1;i<s.Length;i++)
            {
                if (char.IsWhiteSpace(s[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(s[i]) == true || char.IsPunctuation(s[i]))
                    {
                        c++;
                    }
                }
            }
            if(s.Length>2)
            {
                c++;
            }
            return c;
        }
    }
}
