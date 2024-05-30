using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine($"{arg} -> {VerifyPalindrome(arg)}");
            }
        }
        public static bool VerifyPalindrome(string text)
        {
            bool Palindrome(string text)
            {
                string _invertText = "";
                int _lenText = text.Length;

                for (int i = _lenText; i > 0; i--)
                {
                    _invertText += text[i-1];
                }

                return text == _invertText;
            }

            if (text == null)
            {
                throw new ArgumentNullException();
            }
            else if (text.Length < 2)
            {
                return true;
            }
            else 
                return Palindrome(text);
        }
    }
}
