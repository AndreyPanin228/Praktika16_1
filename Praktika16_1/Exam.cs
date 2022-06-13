using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika16_1
{
    public class Exam
    {
        public static bool ExamFirst(string slovo)
        {
            if (slovo != string.Empty)
            {
                for (int i = 0; i < slovo.Length; i++)
                {
                    if (char.IsDigit(slovo[i]))
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        public static string First(string slovo)
        {
            StreamReader sr = new StreamReader("test.txt");
            string[] mass = sr.ReadToEnd().Split(' ', '.', ',');
            int count = (from i in mass where i.ToLower() == slovo select i).Count();
            sr.Close();
            string str = $"Ваше слово {slovo} встретилось в файле {count} раз";
            return str;

        }
    }
}
