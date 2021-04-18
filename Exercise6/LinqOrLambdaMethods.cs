using System.Linq;
namespace Exercise_6
{
    /// <summary>
    /// A static class to run different queries based on LINQ query or dot notation formats
    /// </summary>
    public static class LinqOrLambdaMethods
    {
        /// <summary>
        /// Linq query to get a string (e.g., a,b,c) composed of the first character of every word in an array of strings
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LinqFirstCharacter(string[] words)
        {
            var chars = (from word in words
                         where word.Any()
                         select word.Substring(0, 1)).Aggregate((c1, c2) => c1 + "," + c2);


            return chars;
        }
        /// <summary>
        /// Linq dot notation to get a string (e.g., a,b,c) composed of the first character of every word in an array of strings
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LambdaFirstCharacter(string[] words)
        {
            var chars = words.Select(s => s.Substring(0, 1)).ToList().Aggregate((c1, c2) => c1 + "," + c2);

            return chars;
        }
        /// <summary>
        /// Linq query to find out the longest word in an array of strings
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LinqLongestWord(string[] words)
        {
            var longestString = (from w in words select w.Length).Max();
            var strLongest = (from w in words
                              where w.Length == longestString
                              select w).Aggregate((w1, w2) => w1 + "," + w2);

            return strLongest;
        }
        /// <summary>
        /// Linq dot notation to find out the longest word in an array of strings
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LambdaLongestWord(string[] words)
        {
            int longestString = words.Select(w => w.Length).Max();
            var strLongest = words.Where(w => w.Length == longestString).ToList().Aggregate((w1, w2) => w1 + "," + w2);

            return strLongest;
        }
        /// <summary>
        /// Linq query to find out the shortest word in an array of strings
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LinqShortestWord(string[] words)
        {
            var shortestString = (from w in words select w.Length).Min();
            var strshortest = (from w in words
                               where w.Length == shortestString
                               select w).Aggregate((w1, w2) => w1 + "," + w2);

            return strshortest;
        }
        /// <summary>
        /// Linq dot notation to find out the shortest word in an array of strings
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LambdaShortestWord(string[] words)
        {
            int shortestString = words.Select(w => w.Length).Min();
            var strShortest = words.Where(w => w.Length == shortestString).ToList().Aggregate((w1, w2) => w1 + "," + w2);

            return strShortest;
        }
        /// <summary>
        /// Linq query to count the words in an array of strings
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LinqWordsCount(string[] words)
        {
            int wordsCount = (from word in words select word).Count();

            return wordsCount.ToString();
        }
        /// <summary>
        /// Linq dot notation to count the words in an array of strings
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LambdaWordsCount(string[] words)
        {
            return words.Select(w => w).Count().ToString();
            //return words.Length;
        }
    }
}
