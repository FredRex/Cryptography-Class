using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher_Cracker_V2
{
    public partial class KlingKracker : Form
    {
        public KlingKracker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Caesar_Click(object sender, EventArgs e)
        {
            OutputText.Text = null;

            string[] Decry = CaesarDecipher(InputText.Text);

            for (int i = 0; i < 26; i++)
            {
                OutputText.Text += i + " " + Decry[i] + Environment.NewLine;
            }

        }

        private void Multiplicative_Click(object sender, EventArgs e)
        {
            OutputText.Text = null;

            int[] keys = new int[12];
            keys[0] = 1; keys[1] = 3; keys[2] = 5; keys[3] = 7;
            keys[4] = 9; keys[5] = 11; keys[6] = 15; keys[7] = 17;
            keys[8] = 19; keys[9] = 21; keys[10] = 23; keys[11] = 25;

            for (int i = 0; i < 12; i++)
            {
                OutputText.Text += i + " " + MultiEncipher(InputText.Text, keys[i]) + Environment.NewLine;
            }
        }

        private void Affine_Click(object sender, EventArgs e)
        {
            OutputText.Text = null;

            int[] keys = new int[12];
            keys[0] = 1; keys[1] = 3; keys[2] = 5; keys[3] = 7;
            keys[4] = 9; keys[5] = 11; keys[6] = 15; keys[7] = 17;
            keys[8] = 19; keys[9] = 21; keys[10] = 23; keys[11] = 25;

            for (int i = 1; i < 12; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    OutputText.Text += keys[i] + " " + j + " " + AffineEncipher(InputText.Text, i, j) + Environment.NewLine;
                }
            }
        }

        public static char CaesarCipher(int k, char c)
        {
            if (!char.IsLetter(c))
            {
                return c; // VERY IMPORTANT ! ! ! Letters of the Latin Alphabet only can be ciphered, special chars are not effected
            }

            char x = char.IsUpper(c) ? 'A' : 'a';
            return (char)
                ((((c + k) - x) % 26) + x);
        }

        public static string CaesarEncipher(string message, int k)
        {
            string o = string.Empty; //Output

            foreach (char c in message)
            {
                o = o + CaesarCipher(k, c); //Each char in the string gets ciphered individually
            }
            return o;
        }

        public static string[] CaesarDecipher(string message)
        {
            string[] o = new string[26];  //Outut

            for (int i = 0; i < 26; i++)
            {
                o[i] = CaesarEncipher(message, i);
            }
            return o;
        }

        public static char MultiCipher(int k, char c)
        {
            if (!char.IsLetter(c))
            {
                return c; // VERY IMPORTANT ! ! ! Letters of the Latin Alphabet only can be ciphered, special chars are not effected
            }

            char x = char.IsUpper(c) ? 'A' : 'a';
            return (char)
                (((((c + 1) - x) * k - 1) % 26) + x);
        }

        public static string MultiEncipher(string message, int k)
        {
            string o = string.Empty; //Output

            foreach (char c in message)
            {
                o = o + MultiCipher(k, c); //Each char in the string gets ciphered individually
            }
            return o;
        }

        public static char AffineCipher(int mk, int ak, char c)
        {
            if (!char.IsLetter(c))
            {
                return c; // VERY IMPORTANT ! ! ! Letters of the Latin Alphabet only can be ciphered, special chars are not effected
            }

            char x = char.IsUpper(c) ? 'A' : 'a';
            return (char)
                ((((((c + 1) - x) * mk - 1) + ak) % 26) + x);
        }

        public static string AffineEncipher(string message, int mk, int ak)
        {
            string o = string.Empty; //Output

            foreach (char c in message)
            {
                o = o + AffineCipher(mk, ak, c); //Each char in the string gets ciphered individually
            }
            return o;
        }
    }
}
