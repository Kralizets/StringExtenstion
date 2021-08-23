using System;

namespace StringExtenstion
{
    class Program
    {
        static void Main(string[] args)
        {
            string notPalindrom = "abnmba";
            string isPalindorm = "abnba";

            Console.WriteLine("notPalindrom: " + notPalindrom.IsPalindrom());
            Console.WriteLine("isPalindorm: " + isPalindorm.IsPalindrom());

            Console.Read();
        }
    }

    public static class StringExtension
    {
        public static bool IsPalindrom(this string h)
        {
            if (string.IsNullOrWhiteSpace(h) || h.Length < 1)
                return false;

            for (int i = 0, j = (h.Length - 1); i < h.Length / 2; i++, j--)
            {
                if (h[i] != h[j])
                    return false;
            }

            return true;
        }
    }
}
