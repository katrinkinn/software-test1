using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatterApp
{
    public class StringFormatter
    {
        public StringFormatter() { }

        bool IsWordChar(char c)
        {
            return Char.IsLetterOrDigit(c) || c == '_';
        }
        string ReplaceWord(string s, string oldword, string newword)
        {
            int startIndex = 0;
            while (true)
            {
                int position = s.IndexOf(oldword, startIndex);
                if (position == -1)
                {
                    return s;
                }
                int indexAfter = position + oldword.Length;
                if ((position == 0 || !IsWordChar(s[position - 1])) && (indexAfter == s.Length || !IsWordChar(s[indexAfter])))
                {
                    s = s.Substring(0, position) + newword + s.Substring(indexAfter);
                    startIndex = position + newword.Length;
                }
                else
                {
                    startIndex = position + oldword.Length;
                }
            }

        }
        public string SafeString(string s)
        {
            if (s == "")
            {
                return s;
            }
            if (s == null)
            {
                throw (new NullReferenceException());
            }
            if (s.Contains(@"'"))
            {
                s = s.Replace(@"'", "\"");
            }
            if (s.Contains("select"))
            {
                s = ReplaceWord(s, "select", "SELECT");
            }
            if (s.Contains("insert"))
            {
                s = ReplaceWord(s, "insert", "INSERT");
            }
            if (s.Contains("update"))
            {
                s = ReplaceWord(s, "update", "UPDATE");
            }
            if (s.Contains("delete"))
            {
                s = ReplaceWord(s, "delete", "DELETE");
            }
            return s;
        }
    }
}
