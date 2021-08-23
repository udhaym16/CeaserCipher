using System;

namespace CeaserCipher
{
    class Program
    {
        public static string simpleCipher(string encrypted, int k)
        {
            string result = ""; Console.WriteLine(encrypted);
            Console.WriteLine(k);
            if (k > 26)
            {
                k = k % 26;
            }
            for (int i = 0; i < encrypted.Length; i++)
            {
                if ((byte)encrypted[i] - k < 65)
                {
                    result = result + Convert.ToChar((byte)encrypted[i] + 26 - k);
                }
                else
                {
                    result = result + Convert.ToChar((byte)encrypted[i] - k);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            String encrypted = Console.ReadLine();
            Console.WriteLine("Enter Numbers To Jump: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Output: "+simpleCipher(encrypted,k));
        }
    }
}
