using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicative_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message;
            //int key;
            int[] keys = new int[12];
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

            Console.WriteLine("Type your string here: ");
            Message = Console.ReadLine();

            /**
            int keyskip = 1;
            for (int i = 1; i == 25; i = i + 2)
            {
                if (i != 13)
                {
                    keys[(i - keyskip)] = i;
                }
                keyskip++;
            }
            **/

            // Number                1 3 5 7 9 11 15 17 19 21 23 25
            //Multiplicative inverse 1 9 21 15 3 19 7 23 11 5 17 25

            keys[0] = 1; keys[1] = 3; keys[2] = 5; keys[3] = 7; keys[4] = 9; keys[5] = 11; keys[6] = 15; keys[7] = 17; keys[8] = 19; keys[9] = 21; keys[10] = 23; keys[11] = 25;

            for (int i = 0; i < 12; i++)
            {
                Console.Write(keys[i]);
                Console.Write(" ");
                Console.WriteLine(Encipher(Message, keys[i]));
            }

            //Console.WriteLine("Type your key: ");
            //key = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine(Encipher(Message, key));
            //string[] Decry = Decipher(Message);

            /**
            for (int i = 0; i < 26; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                Console.WriteLine(Decry[i]);
            }
            **/


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
                (((((c+1) - x) * k - 1) % 26) + x);
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

