using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message;
            /**
            Console.WriteLine("Do you wish to Encipher (E) or Decipher (D) ? ");
            if (Console.ReadLine() == "E")
            {
                Console.WriteLine("Type your string here: ");
                Message = Console.ReadLine();
                Console.WriteLine("Type your key here: ");
                int Key = Convert.ToInt16(Console.ReadLine());
                string Encry = Encipher(Message, Key);
                Console.WriteLine(Encry);
            } **/

            // If Reader chooses to decrypt
            //if (Console.ReadLine() == "D")
            
                Console.WriteLine("Type your encrypted string here: ");
                Message = Console.ReadLine();
                string[] Decry = Decipher(Message);
            
                for (int i = 0; i < 26; i++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    Console.WriteLine(Decry[i]);
                }
            

            //Pause
            Console.ReadLine();

        }

        public static char Cipher(int k, char c)
        {
            if (!char.IsLetter(c))
            {
                return c; // VERY IMPORTANT ! ! ! Letters of the Latin Alphabet only can be ciphered, special chars are not effected
            }

            char x = char.IsUpper(c) ? 'A' : 'a';
            return (char) 
                ((((c + k) - x) % 26) + x);
        }

        public static string Encipher(string message, int k)
        {
            string o = string.Empty; //Output

            foreach (char c in message)
            {
                o = o + Cipher(k, c); //Each char in the string gets ciphered individually
            }
            return o;
        }

        public static string[] Decipher(string message)
        {
            string[] o = new string[26];  //Outut

            for (int i = 0; i < 26; i++)
            {
                o[i] = Encipher(message, i);
            }
            return o;
        }
        
    }
}
