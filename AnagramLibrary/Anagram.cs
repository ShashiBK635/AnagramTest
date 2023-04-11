using System.Text.RegularExpressions;

namespace AnagramLibrary
{
    public static class Anagram
    {
        public static bool isAnagram(string phrase1, string phrase2)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            phrase1 = rgx.Replace(phrase1, "").Replace(" ", "").ToLower();
            phrase2 = rgx.Replace(phrase2, "").Replace(" ", "").ToLower();
            //Console.WriteLine(phrase1);
            //Console.WriteLine(phrase2);

            foreach (var ch in phrase1)
            {
                var ind = phrase2.IndexOf(ch);
                if (ind > -1)
                {
                    phrase2 = phrase2.Remove(ind, 1);
                    //Console.WriteLine(phrase2);
                }
                else
                {
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(phrase2))
            {
                return false;
            }

            return true;
        }
    }
}