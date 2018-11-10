using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neely_Enigma_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //
        // Caesar Cipher - - - - - - - - - - - - -
        //

        private void CaesarButton_Click(object sender, EventArgs e)
        {
            Output.Text = null; // CLEAR THE OUTPUT BEFORE WRITING TO IT

            //ErrorCheck(); //COMMON ERROR CHECK

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

            //Console.WriteLine("Type your encrypted string here: ");
            Message = Input.Text;

            if (HCheck.Checked)
            {
                string[] Decry = CaesarDecipher(Message);

                for (int i = 0; i < 26; i++)
                {
                    //Console.Write(i);
                    //Console.Write(" ");
                    //Console.WriteLine(Decry[i]);
                    Output.Text += i;
                    Output.Text += " ";
                    Output.Text += Decry[i];
                    Output.Text += Environment.NewLine;
                }
            }

            if (ECheck.Checked)
            {
                string[] Decry = CaesarDecipher(Message);

                int i = Mod(Convert.ToInt32(CaesarText.Text),26);

                Output.Text += i;
                Output.Text += " ";
                Output.Text += Decry[i];
                //Output.Text += Environment.NewLine;
            }

            if (DCheck.Checked)
            {
                string[] Decry = CaesarDecipher(Message);
                
                int invC = (26 - Mod(Convert.ToInt32(CaesarText.Text),26));

                Output.Text += invC;
                Output.Text += " ";
                Output.Text += Decry[invC];
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
            string[] o = new string[26];  //Output

            for (int i = 0; i < 26; i++)
            {
                o[i] = CaesarEncipher(message, i);
            }
            return o;
        }

        //
        // Multiplicative Cipher - - - - - - - - -
        //

        private void MultiplicativeButton_Click(object sender, EventArgs e)
        {
            Output.Text = null; // CLEAR THE OUTPUT BEFORE WRITING TO IT

            //ErrorCheck(); //COMMON ERROR CHECK

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

            //Console.WriteLine("Type your string here: ");
            Message = Input.Text;

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

            // Number                1 3 5   7 9 11 15 17 19 21 23 25
            //Multiplicative inverse 1 9 21 15 3 19 7  23 11  5 17 25

            keys[0] = 1; keys[1] = 3; keys[2] = 5; keys[3] = 7; keys[4] = 9; keys[5] = 11; keys[6] = 15; keys[7] = 17; keys[8] = 19; keys[9] = 21; keys[10] = 23; keys[11] = 25;

            if (HCheck.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    //Console.Write(keys[i]);
                    //Console.Write(" ");
                    //Console.WriteLine(MEncipher(Message, keys[i]));
                    Output.Text += keys[i];
                    Output.Text += " ";
                    Output.Text += MEncipher(Message, keys[i]);
                    Output.Text += Environment.NewLine;
                }
            }

            if (ECheck.Checked)
            {
                string[] Decry = MDecipher(Message);

                int i = Mod(Convert.ToInt32(SlopeText.Text),26);

                if (Gcd(i, 26) != 1) Output.Text += "ERROR ERROR ERROR KEY IS NOT COPRIME ERROR ERROR ERROR";

                Output.Text += i;
                Output.Text += " ";
                Output.Text += Decry[i];
                //Output.Text += Environment.NewLine;
            }


            if (DCheck.Checked)
            {
                //int invC = (26 - Convert.ToInt32(CaesarText.Text));
                int invM = Mod(Convert.ToInt32(SlopeText.Text),26);
                if (Gcd(invM, 26) != 1) Output.Text += "ERROR ERROR ERROR KEY IS NOT COPRIME ERROR ERROR ERROR";
                if (DCheck.Checked)
                {
                    
                    
                    switch (invM)
                    {
                        case 1:
                            invM = 1;
                            break;
                        case 3:
                            invM = 9;
                            break;
                        case 5:
                            invM = 21;
                            break;
                        case 7:
                            invM = 15;
                            break;
                        case 9:
                            invM = 3;
                            break;
                        case 11:
                            invM = 19;
                            break;
                        case 15:
                            invM = 7;
                            break;
                        case 17:
                            invM = 23;
                            break;
                        case 19:
                            invM = 11;
                            break;
                        case 21:
                            invM = 5;
                            break;
                        case 23:
                            invM = 17;
                            break;
                        case 25:
                            invM = 25;
                            break;
                        default:
                            Output.Text += "ERROR ERROR ERROR KEY IS NOT COPRIME ERROR ERROR ERROR";
                            break;
                    }
                    //for (int i = 0; i < 12; i++)
                    //{
                    //for (int j = 1; j < 26; j++)
                    {
                        //Console.Write(keys[i]);
                        //Console.Write(" ");
                        //Console.Write(j);
                        //Console.Write(" ");
                        //Console.WriteLine(AEncipher(Message, keys[i], j));
                        Output.Text += invM;
                        Output.Text += " ";
                        //Output.Text += invC;
                        //Output.Text += " ";
                        Output.Text += MEncipher(Message, invM);
                        //Output.Text += Environment.NewLine;
                        //}
                        //}
                    }
                }
            }

            //Console.WriteLine("Type your key: ");
            //key = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine(Encipher(Message, key));
            //string[] Decry = Decipher(Message);

            ///**
            //for (int i = 0; i < 26; i++)
            //{
            //    Console.Write(i);
            //    Console.Write(" ");
            //    Console.WriteLine(Decry[i]);
            //}
            //**/
        }

        public static char MCipher(int k, char c)
        {
            if (!char.IsLetter(c))
            {
                return c; // VERY IMPORTANT ! ! ! Letters of the Latin Alphabet only can be ciphered, special chars are not effected
            }

            char x = char.IsUpper(c) ? 'A' : 'a';
            return (char)
                (((((c + 1) - x) * k - 1) % 26) + x);
        }

        public static string MEncipher(string message, int k)
        {
            string o = string.Empty; //Output

            foreach (char c in message)
            {
                o = o + MCipher(k, c); //Each char in the string gets ciphered individually
            }
            return o;
        }

        public static string[] MDecipher(string message)
        {
            string[] o = new string[26];  //Outut

            for (int i = 0; i < 26; i++)
            {
                o[i] = MEncipher(message, i);
            }
            return o;
        }

        //
        // Affine Cipher - - - - - - - - - - - - -
        //

        private void AffineButton_Click(object sender, EventArgs e)
        {
            Output.Text = null; // CLEAR THE OUTPUT BEFORE WRITING TO IT

            //ErrorCheck(); //COMMON ERROR CHECK

            string Message;
            //int key;
            int[] keys = new int[12];

            //Console.WriteLine("Type your string here: ");
            Message = Input.Text;

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

            if (HCheck.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 1; j < 26; j++)
                    {
                        //Console.Write(keys[i]);
                        //Console.Write(" ");
                        //Console.Write(j);
                        //Console.Write(" ");
                        //Console.WriteLine(AEncipher(Message, keys[i], j));
                        Output.Text += keys[i];
                        Output.Text += " ";
                        Output.Text += j;
                        Output.Text += " ";
                        Output.Text += AEncipher(Message, keys[i], j);
                        Output.Text += Environment.NewLine;
                    }
                }
            }

            if (DCheck.Checked)
            {
                
                int invC = Mod((26 - Convert.ToInt32(CaesarText.Text)), 26);
                int invM = Mod(Convert.ToInt32(SlopeText.Text), 26);
                if (Gcd(invM, 26) != 1) Output.Text += "ERROR ERROR ERROR KEY IS NOT COPRIME ERROR ERROR ERROR";
                switch (invM)
                {
                    case 1:
                        invM = 1;
                        break;
                    case 3:
                        invM = 9;
                        break;
                    case 5:
                        invM = 21;
                        break;
                    case 7:
                        invM = 15;
                        break;
                    case 9:
                        invM = 3;
                        break;
                    case 11:
                        invM = 19;
                        break;
                    case 15:
                        invM = 7;
                        break;
                    case 17:
                        invM = 23;
                        break;
                    case 19:
                        invM = 11;
                        break;
                    case 21:
                        invM = 5;
                        break;
                    case 23:
                        invM = 17;
                        break;
                    case 25:
                        invM = 25;
                        break;
                    default:
                        Output.Text += "ERROR ERROR ERROR KEY IS NOT COPRIME ERROR ERROR ERROR";
                        break;
                }
                //for (int i = 0; i < 12; i++)
                //{
                //for (int j = 1; j < 26; j++)
                {
                    //Console.Write(keys[i]);
                    //Console.Write(" ");
                    //Console.Write(j);
                    //Console.Write(" ");
                    //Console.WriteLine(AEncipher(Message, keys[i], j));
                    Output.Text += invM;
                    Output.Text += " ";
                    Output.Text += invC;
                    Output.Text += " ";
                    Output.Text += AEncipher(Message, invM, invC);
                    //Output.Text += Environment.NewLine;
                    //}
                    //}
                }
            }

            if (ECheck.Checked)
            {
                int i = Convert.ToInt32(SlopeText.Text);
                int j = Convert.ToInt32(CaesarText.Text);

                if (Gcd(i, 26) != 1) Output.Text += "ERROR ERROR ERROR KEY IS NOT COPRIME ERROR ERROR ERROR";

                Output.Text += i;
                Output.Text += " ";
                Output.Text += j;
                Output.Text += " ";
                Output.Text += AEncipher(Message, i, j);
                //Output.Text += Environment.NewLine;
            }
        }

        public static char ACipher(int mk, int ak, char c)
        {
            if (!char.IsLetter(c))
            {
                return c; // VERY IMPORTANT ! ! ! Letters of the Latin Alphabet only can be ciphered, special chars are not effected
            }

            char x = char.IsUpper(c) ? 'A' : 'a';
            return (char)
                ((((((c) - x) * mk) + ak) % 26) + x);
        }

        public static string AEncipher(string message, int mk, int ak)
        {
            string o = string.Empty; //Output

            foreach (char c in message)
            {
                o = o + ACipher(mk, ak, c); //Each char in the string gets ciphered individually
            }
            return o;
        }

        //
        // Codeword Cipher - - - - - - - - - - - -
        //

        private void CodeButton_Click(object sender, EventArgs e)
        {
            Output.Text = null; // CLEAR THE OUTPUT BEFORE WRITING TO IT

            ErrorCheck(); //COMMON ERROR CHECK

            int key = Convert.ToInt16(Convert.ToChar(CodeKey.Text));
            key -= 'a';

            if (ECheck.Checked == true)
            {
                //Console.WriteLine("Please type your codeword here (only lowercase letters plz): ");
                string code = CodewordText.Text;

                string message = Input.Text;

                //Console.WriteLine("Please type your code letter here (still lowercase): ");
                //int key = Convert.ToInt16(Convert.ToChar(CodeKey.Text));
                //key -= 'a';


                List<char> alpha = new List<char>(26);

                char[] set = new char[26];

                char[] abet = new char[26];

                for (int i = 0; i < 26; i++)
                {
                    int ch = 'a' + i;
                    abet[i] = (char)ch;
                }



                //for (int i = 0; i < code.Length; i++)
                //{
                //    char ch = code[i];
                //    if (alpha.Contains(ch) == true)
                //    {
                //        code = string.Empty;
                //        for (int j = i++; j < (code.Length - i); j++)
                //        {
                //            code += code[j];
                //        }
                //    }
                //    else alpha.Add(ch);

                //}

                GetDistinctChars(alpha, code);

                //for (int key = 0; key < 26; key++)
                //{

                for (int i = 0; i < alpha.Count; i++)
                {
                    set[i + key] = alpha[i];
                }

                int recount = 0;

                for (int i = 0; i < set.Length; i++)
                {
                    if (!alpha.Contains((char)('a' + i)))
                    {

                        set[(i + key + alpha.Count - recount) % 26] = (char)('a' + i);
                    }
                    else recount++;

                }

                Output.Text += (char)(key + 'a');
                Output.Text += " ";
                Output.Text += CodeCipher(message, abet, set);
                Output.Text += Environment.NewLine;
                //}

                //Console.WriteLine("Enter message: ");
                //string message = Console.ReadLine();

                //Console.WriteLine(Cipher(message, abet, set));
                //end = true;
            }


            if (HCheck.Checked == true)
            {
                //Console.WriteLine("Please type your codeword here (only lowercase letters plz): ");
                string code = CodewordText.Text;

                List<char> alpha = new List<char>(26);

                GetDistinctChars(alpha, code);

                //Console.WriteLine("Enter message: ");
                string message = Input.Text;

                for (int i = 0; i < 26; i++)
                {
                    char x = (char)('a' + i);
                    Output.Text += x;
                    Output.Text += " ";
                    Output.Text += CodeDecipher(message, alpha, key);
                    Output.Text += Environment.NewLine;
                    //Console.Write(x);
                    //Console.Write(" ");
                    //Console.WriteLine(CodeDecipher(message, alpha)[i]);
                }
            }


            if (HCheck.Checked == true)
            {
                //Console.WriteLine("Please type your codeword here (only lowercase letters plz): ");
                string code = CodewordText.Text;

                List<char> alpha = new List<char>(26);

                GetDistinctChars(alpha, code);

                //Console.WriteLine("Enter message: ");
                string message = Input.Text;

                for (int i = 0; i < 26; i++)
                {
                    char x = (char)('a' + i);
                    Output.Text += x;
                    Output.Text += " ";
                    Output.Text += CodeHack(message, alpha)[i];
                    Output.Text += Environment.NewLine;
                    //Console.Write(x);
                    //Console.Write(" ");
                    //Console.WriteLine(CodeDecipher(message, alpha)[i]);
                }
            }
        }

        public static string CodeCipher(string message, char[] abet, char[] set)
        {
            string output = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    for (int j = 0; j < abet.Length; j++)
                    {
                        if (message[i] == abet[j])
                        {
                            output += set[j];
                        }
                    }
                }
            }
            return output;
        }

        public static string[] CodeHack(string message, List<char> alpha)
        {
            string[] o = new string[26];
            for (int key = 0; key < 26; key++)
            {


                char[] set = new char[26];

                char[] abet = new char[26];

                //GetDistinctChars(alpha, code);

                for (int i = 0; i < 26; i++)
                {
                    int ch = 'a' + i;
                    abet[i] = (char)ch;
                }

                for (int i = 0; i < alpha.Count; i++)
                {
                    set[(i + key) % 26] = alpha[i];
                }

                int recount = 0;

                for (int i = 0; i < set.Length; i++)
                {
                    if (!alpha.Contains((char)('a' + i)))
                    {

                        set[(i + key + alpha.Count - recount) % 26] = (char)('a' + i);
                    }
                    else recount++;

                }
                string output = string.Empty;
                for (int i = 0; i < message.Length; i++)
                {
                    if (char.IsLetter(message[i]))
                    {
                        for (int j = 0; j < set.Length; j++)
                        {
                            if (message[i] == set[j])
                            {
                                output += abet[j];
                            }
                        }
                    }
                }
                o[key] += output;
            }
            return o;
        }

        public static string CodeDecipher(string message, List<char> alpha, int key)
        {
            string o = string.Empty;
            //for (int key = 0; key < 26; key++)
            //{


                char[] set = new char[26];

                char[] abet = new char[26];

                //GetDistinctChars(alpha, code);

                for (int i = 0; i < 26; i++)
                {
                    int ch = 'a' + i;
                    abet[i] = (char)ch;
                }

                for (int i = 0; i < alpha.Count; i++)
                {
                    set[(i + key) % 26] = alpha[i];
                }

                int recount = 0;

                for (int i = 0; i < set.Length; i++)
                {
                    if (!alpha.Contains((char)('a' + i)))
                    {

                        set[(i + key + alpha.Count - recount) % 26] = (char)('a' + i);
                    }
                    else recount++;

                }
                string output = string.Empty;
                for (int i = 0; i < message.Length; i++)
                {
                    if (char.IsLetter(message[i]))
                    {
                        for (int j = 0; j < set.Length; j++)
                        {
                            if (message[i] == set[j])
                            {
                                output += abet[j];
                            }
                        }
                    }
                }
                o += output;
            //}
            return o;
        }

        public static void GetDistinctChars(List<char> letters, string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if (!letters.Contains(message[i]))
                {
                    letters.Add(message[i]);
                }
            }
        }

        //
        // Vigenere Cipher - - - - - - - - - - - - -
        //

        private void VigButton_Click(object sender, EventArgs e)
        {
            Output.Text = null; // CLEAR THE OUTPUT BEFORE WRITING TO IT

            ErrorCheck(); //COMMON ERROR CHECK

            char[,] vig = new char[26, 26];

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    char c = Convert.ToChar('a' + ((i + j) % 26)); // Building the tabula recta
                    vig[j, i] = c;
                }
            }

            //Console.WriteLine("What is your message???");
            string message = Input.Text;

            //Console.WriteLine("What is your codeword?");
            string code = CodewordText.Text;
            code = Codify(code, message);

            //string choice;
            //bool end = false;
            //while (!end)
            //{
                //Console.WriteLine("Encipher (E) or Decipher (D)???");
                //choice = Console.ReadLine();

            if (ECheck.Checked)
            {

                string output = VigCipher(vig, message, code);

                Output.Text += output;

                //Console.WriteLine(output);
                //end = true;
            }


            if (HCheck.Checked)
            {
                string output = VigHack(vig, message, code);

                Output.Text += output;

                //Console.WriteLine(output);
                //end = true;
            }

            if (DCheck.Checked)
            {
                int key = (char)(Convert.ToChar(CodeKey.Text) - 'a');
                string output = VigDecipher(vig, message, code, key);

                Output.Text += output;

                //Console.WriteLine(output);
                //end = true;
            }

            //if (choice != "E" && choice != "D")
            //{
            //    Console.WriteLine("Invalid Response, Please Try Again...");
            //    end = false;
            //}
        }

            //Console.ReadLine(); // Pause
        //}

        public static string VigCipher(char[,] vig, string message, string code)
        {
            string output = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                output += vig[(message[i] - 'a'), (code[i] - 'a')];
            }
            return output;
        }

        public static string VigHack(char[,] vig, string message, string code)
        {
            string output = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (vig[j, (code[i] - 'a')] == message[i])
                    {
                        output += vig[j, 0];
                    }
                }
            }

            return output;
        }

        public static string VigDecipher(char[,] vig, string message, string code, int key)
        {
            string output = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {

                    if (vig[key, (code[i] - 'a')] == message[i])
                    {
                        output += vig[key, 0];
                    }
                
            }

            return output;
        }

        public static string Codify(string code, string message)
        {
            string output = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                output += code[(i % code.Length)];
            }

            return output;
        }

        //
        // Playfair Cipher - - - - - - - - - - ( A huge amount of code involved here)
        //

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Output.Text = null; // CLEAR THE OUTPUT BEFORE WRITING TO IT

            ErrorCheck(); //COMMON ERROR CHECK

            PlayfairClass Play = new PlayfairClass();

            //Console.WriteLine("Please give your playfair square");


            for (int i = 0; i < 5; i++)
            {
                int j = 0;
                string row  = String.Concat(PlayfairText.Text[(i * 5)], PlayfairText.Text[1 + (i * 5)], PlayfairText.Text[2 + (i * 5)], PlayfairText.Text[3 + (i * 5)], PlayfairText.Text[4 + (i * 5)]);


                for (j = 0; j < 5; j++)
                {
                    char c = row[j];
                    Play.Square[j, i].ch = c;
                    Play.Square[j, i].row = j;
                    Play.Square[j, i].col = i;
                }
            }

            //Console.WriteLine("What is your special character???");
            Play.Special = 'x';


            if (ECheck.Checked)
            {
                //Console.WriteLine("What is your message???");
                string output = Play.SquareEncipher(Play, GetRidofJs(Input.Text));


                //Console.WriteLine(output);

                Output.Text += output;
            }

            if (DCheck.Checked || HCheck.Checked)
            {
                //Console.WriteLine("What is your message???");
                string output = Play.SquareDecryptor(Play, GetRidofJs(Input.Text));


                //Console.WriteLine(output);

                Output.Text += output;
            }

        }

        public static string GetRidofJs(string message)
        {
            string output = string.Empty;

            for (int i = 0; i < message.Length; i++) // All Js will be seen as an I from now on because ease
            {
                if (message[i] == 'j')
                {
                    output += 'i';
                }
                else output += message[i];
            }

            return output;
        }

        public static string NoDouble(string message, char special)
        {
            string output = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                if (i == message.Length - 1)
                {
                    output += message[i];
                    break;
                }
                if (message[i] == message[i + 1])
                {
                    output += message[i];
                    output += special;
                }
                else output += message[i];
            }

            return output;
        }

        //
        // 2x2 Matrix Cipher - - - - - - - - - 
        //

        private void Mat2Button_Click(object sender, EventArgs e)
        {
            bool detbroke = true;

            Output.Text = null; // CLEAR THE OUTPUT BEFORE WRITING TO IT

            ErrorCheck(); //COMMON ERROR CHECK

            //Console.WriteLine("Enter Matrix Items Below: ");
            int[,] Matrix = new int[2, 2]; // Make the key matrix

            //for (int a = 0; a < 2; a++) // Each row
            //{
            //    for (int b = 0; b < 2; b++) // Each column
            //    {
            //        Console.Write($"({a},{b}): ");
            //        Matrix[a, b] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            Matrix[0, 0] = (int)Mat100.Value;
            Matrix[0, 1] = (int)Mat101.Value;
            Matrix[1, 0] = (int)Mat110.Value;
            Matrix[1, 1] = (int)Mat111.Value;

            //Console.WriteLine("What is your message boi? (Lowercase)");
            string message = Input.Text; // Get message

            //Console.WriteLine("Encrypt (E) or Decrypt (D)");
            //string choice = Console.ReadLine();

            int det = (Matrix[0, 0] * Matrix[1, 1]) - (Matrix[0, 1] * Matrix[1, 0]);

            int indet = det;
            if (det == 0)
            {
                detbroke = true;
                Output.Text += "ERROR ERROR ERROR DETERMINANT IS ZERO ERROR ERROR ERROR";
            }

            if (DCheck.Checked || HCheck.Checked)
            {
                det = (Matrix[0, 0] * Matrix[1, 1]) - (Matrix[0, 1] * Matrix[1, 0]);

                indet = det;
                if (det == 0)
                {
                    detbroke = true;
                    Output.Text += "ERROR ERROR ERROR DETERMINANT IS ZERO ERROR ERROR ERROR";
                }
                if (indet < 0) indet = det + 26; // Inverse stuff
                switch (indet)
                {
                    case 1:
                        indet = 1;
                        break;
                    case 3:
                        indet = 9;
                        break;
                    case 5:
                        indet = 21;
                        break;
                    case 7:
                        indet = 15;
                        break;
                    case 9:
                        indet = 3;
                        break;
                    case 11:
                        indet = 19;
                        break;
                    case 15:
                        indet = 7;
                        break;
                    case 17:
                        indet = 23;
                        break;
                    case 19:
                        indet = 11;
                        break;
                    case 21:
                        indet = 5;
                        break;
                    case 23:
                        indet = 17;
                        break;
                    case 25:
                        indet = 25;
                        break;
                }

                int[,] AdMat = new int[2, 2];
                AdMat[0, 0] = Matrix[1, 1] % 26; AdMat[0, 0] = (AdMat[0, 0] * indet) % 26;
                AdMat[1, 0] = -Matrix[1, 0] + 26; AdMat[1, 0] = (AdMat[1, 0] * indet) % 26;
                AdMat[0, 1] = -Matrix[0, 1] + 26; AdMat[0, 1] = (AdMat[0, 1] * indet) % 26;
                AdMat[1, 1] = Matrix[0, 0] % 26; AdMat[1, 1] = (AdMat[1, 1] * indet) % 26;

                Matrix = AdMat;
            }

            //if (!detbroke)
            //{
                string output = Mat2Encrypt(message, Matrix);

                //Console.WriteLine(output);
                Output.Text += output;
            //}
        }

        public static string Mat2Encrypt(string message, int[,] Matrix)
        {
            
            if (message.Length % 2 != 0) message += 'x'; //Make it even by adding a little 'x' at the end

            int[][] MessMat = new int[message.Length / 2][]; // List of pairs

            for (int i = 0; i < message.Length; i += 2) // Splits the message in twos
            {
                int[] Mat = new int[2]; // Makes an array
                Mat[0] = message[i] - 'a';                         // CURRENTLY IN NEELY MODE, WILL NOT WORK ON ACTUAL HILL CIPHERS
                Mat[1] = message[i + 1] - 'a'; // Fills that array // CURRENTLY IN NEELY MODE, WILL NOT WORK ON ACTUAL HILL CIPHERS
                MessMat[i / 2] = Mat; // Puts it into a List
            }

            int[][] EncryMat = new int[message.Length / 2][]; // New List of pairs

            for (int i = 0; i < MessMat.Length; i++) // Multiplication
            {
                int[] Mat = new int[2];
                Mat[0] = ((Matrix[0, 0] * MessMat[i][0]) + (Matrix[1, 0] * MessMat[i][1])) % 26;
                Mat[1] = ((Matrix[0, 1] * MessMat[i][0]) + (Matrix[1, 1] * MessMat[i][1])) % 26;
                EncryMat[i] = Mat;
            }

            string output = string.Empty;

            for (int i = 0; i < EncryMat.Length; i++) // Print
            {
                char output1 = Convert.ToChar('a'); output1 += Convert.ToChar(EncryMat[i][0]);// output1 -= Convert.ToChar(1); // CURRENTLY IN NEELY MODE, WILL NOT WORK ON ACTUAL HILL CIPHERS
                char output2 = Convert.ToChar('a'); output2 += Convert.ToChar(EncryMat[i][1]);// output2 -= Convert.ToChar(1); // CURRENTLY IN NEELY MODE, WILL NOT WORK ON ACTUAL HILL CIPHERS
                output += output1;
                output += output2;
            }

            return output;
        }

        //
        // 3x3 Matrix Cipher - - - - - - - - - -
        //

        private void Mat3Button_Click(object sender, EventArgs e)
        {
            bool detbroke = false;

            Output.Text = null; // CLEAR THE OUTPUT BEFORE WRITING TO IT

            ErrorCheck(); //COMMON ERROR CHECK

            //Console.WriteLine("Enter Matrix Items Below: ");
            int[,] Matrix = new int[3, 3]; // Make the key matrix

            //for (int a = 0; a < 3; a++) // Each row
            //{
            //    for (int b = 0; b < 3; b++) // Each column
            //    {
            //        Console.Write($"({a},{b}): ");
            //        Matrix[a, b] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            Matrix[0, 0] = (int)Mat200.Value;
            Matrix[0, 1] = (int)Mat201.Value;
            Matrix[0, 2] = (int)Mat202.Value;
            Matrix[1, 0] = (int)Mat210.Value;
            Matrix[1, 1] = (int)Mat211.Value;
            Matrix[1, 2] = (int)Mat212.Value;
            Matrix[2, 0] = (int)Mat220.Value;
            Matrix[2, 1] = (int)Mat221.Value;
            Matrix[2, 2] = (int)Mat222.Value;

            //Console.WriteLine("What is your message boi? (Lowercase)");
            string message = Input.Text; // Get message

            //Console.WriteLine("Encrypt (E) or Decrypt (D)");
            //string choice = Console.ReadLine();

            int a = Matrix[0, 0];
            int b = Matrix[1, 0];
            int c = Matrix[2, 0];
            int d = Matrix[0, 1];
            int E = Matrix[1, 1];
            int f = Matrix[2, 1];
            int g = Matrix[0, 2];
            int h = Matrix[1, 2];
            int i = Matrix[2, 2];

            int det = Mod((a * (E * i - f * h) - b * (d * i - f * g) + c * (d * h - E * g)), 26);
            if (det == 0)
            {
                detbroke = true;
                Output.Text += "ERROR ERROR ERROR DETERMINANT IS ZERO ERROR ERROR ERROR";
            }

            if (DCheck.Checked || HCheck.Checked)
            {

                det = Mod((a * (E * i - f * h) - b * (d * i - f * g) + c * (d * h - E * g)), 26);
                if (det == 0)
                {
                    detbroke = true;
                    Output.Text += "ERROR ERROR ERROR DETERMINANT IS ZERO ERROR ERROR ERROR";
                }
                //int det = (Matrix[0, 0] * ((Matrix[1, 1] * Matrix[2, 2]) - (Matrix[2, 1] * Matrix[1, 2])))
                //        - (Matrix[1, 0] * ((Matrix[0, 1] * Matrix[2, 2]) - (Matrix[2, 1] * Matrix[0, 2])))
                //        + (Matrix[2, 0] * ((Matrix[0, 1] * Matrix[1, 2]) - (Matrix[1, 1] * Matrix[0, 2])));
                int indet = det;
                //if (indet < 0) indet = det + 26; // Inverse stuff
                switch (indet)
                {
                    case 1:
                        indet = 1;
                        break;
                    case 3:
                        indet = 9;
                        break;
                    case 5:
                        indet = 21;
                        break;
                    case 7:
                        indet = 15;
                        break;
                    case 9:
                        indet = 3;
                        break;
                    case 11:
                        indet = 19;
                        break;
                    case 15:
                        indet = 7;
                        break;
                    case 17:
                        indet = 23;
                        break;
                    case 19:
                        indet = 11;
                        break;
                    case 21:
                        indet = 5;
                        break;
                    case 23:
                        indet = 17;
                        break;
                    case 25:
                        indet = 25;
                        break;
                    default:
                        detbroke = true;
                        Output.Text += "ERROR ERROR ERROR DETERMINANT IS NOT COPRIME TO 26 ERROR ERROR ERROR";
                        break;
                }  
            



                int[,] AdMat = new int[3, 3];
                AdMat[0, 0] = Mod(Determinant(E, f, h, i), 26);
                AdMat[0, 1] = Mod(-Determinant(d, f, g, i), 26);
                AdMat[0, 2] = Mod(Determinant(d, E, g, h), 26);
                AdMat[1, 0] = Mod(-Determinant(b, c, h, i), 26);
                AdMat[1, 1] = Mod(Determinant(a, c, g, i), 26);
                AdMat[1, 2] = Mod(-Determinant(a, b, g, h), 26);
                AdMat[2, 0] = Mod(Determinant(b, c, E, f), 26);
                AdMat[2, 1] = Mod(-Determinant(a, c, d, f), 26);
                AdMat[2, 2] = Mod(Determinant(a, b, d, E), 26);

                //Swap(AdMat[0, 1], AdMat[1, 0]);
                //Swap(AdMat[2, 0], AdMat[0, 2]);
                //Swap(AdMat[1, 2], AdMat[2, 1]);

                AdMat[0, 0] = Mod(AdMat[0, 0] * indet, 26);
                AdMat[0, 1] = Mod(AdMat[0, 1] * indet, 26);
                AdMat[0, 2] = Mod(AdMat[0, 2] * indet, 26);
                AdMat[1, 0] = Mod(AdMat[1, 0] * indet, 26);
                AdMat[1, 1] = Mod(AdMat[1, 1] * indet, 26);
                AdMat[1, 2] = Mod(AdMat[1, 2] * indet, 26);
                AdMat[2, 0] = Mod(AdMat[2, 0] * indet, 26);
                AdMat[2, 1] = Mod(AdMat[2, 1] * indet, 26);
                AdMat[2, 2] = Mod(AdMat[2, 2] * indet, 26);

                Matrix = AdMat;
            }

            //if (!detbroke)
            //{ 
                string output = Mat3Encrypt(message, Matrix);

                //Console.WriteLine(output);

                Output.Text += output;
            //}
        }

        public static string Mat3Encrypt(string message, int[,] Matrix)
        {
            if (message.Length % 3 != 0) message += 'x'; //Make it even by adding a little 'x' at the end
            if (message.Length % 3 != 0) message += 'x'; //Make it even by adding a little 'x' at the end

            int[][] MessMat = new int[message.Length / 3][]; // List of pairs

            for (int i = 0; i < message.Length; i += 3) // Splits the message in twos
            {
                int[] Mat = new int[3]; // Makes an array
                Mat[0] = message[i] - 'a';                         // CURRENTLY IN NEELY MODE, WILL NOT WORK ON ACTUAL HILL CIPHERS
                Mat[1] = message[i + 1] - 'a'; // Fills that array // CURRENTLY IN NEELY MODE, WILL NOT WORK ON ACTUAL HILL CIPHERS
                Mat[2] = message[i + 2] - 'a';
                MessMat[i / 3] = Mat; // Puts it into a List
            }

            int[][] EncryMat = new int[message.Length / 3][]; // New List of pairs

            for (int i = 0; i < MessMat.Length; i++) // Multiplication
            {
                int[] Mat = new int[3];
                Mat[0] = ((Matrix[0, 0] * MessMat[i][0]) + (Matrix[1, 0] * MessMat[i][1]) + (Matrix[2, 0] * MessMat[i][2])) % 26;
                Mat[1] = ((Matrix[0, 1] * MessMat[i][0]) + (Matrix[1, 1] * MessMat[i][1]) + (Matrix[2, 1] * MessMat[i][2])) % 26;
                Mat[2] = ((Matrix[0, 2] * MessMat[i][0]) + (Matrix[1, 2] * MessMat[i][1]) + (Matrix[2, 2] * MessMat[i][2])) % 26;
                EncryMat[i] = Mat;
            }

            string output = string.Empty;

            for (int i = 0; i < EncryMat.Length; i++) // Print
            {
                char output1 = Convert.ToChar('a'); output1 += Convert.ToChar(EncryMat[i][0]);// output1 -= Convert.ToChar(1); // CURRENTLY IN NEELY MODE, WILL NOT WORK ON ACTUAL HILL CIPHERS
                char output2 = Convert.ToChar('a'); output2 += Convert.ToChar(EncryMat[i][1]);// output2 -= Convert.ToChar(1); // CURRENTLY IN NEELY MODE, WILL NOT WORK ON ACTUAL HILL CIPHERS
                char output3 = Convert.ToChar('a'); output3 += Convert.ToChar(EncryMat[i][2]);// output2 -= Convert.ToChar(1); // CURRENTLY IN NEELY MODE, WILL NOT WORK ON ACTUAL HILL CIPHERS
                output += output1;
                output += output2;
                output += output3;
            }

            return output;
        }

        public static int Determinant(int a, int b, int c, int d)
        {
            int output = (a * d) - (b * c);
            return output;
        }

        public static void Swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static int Mod(int input, int mod)
        {
            input %= mod;
            while (input < 0)
            {
                input += 26;
            }
            return input;
        }

        //
        // If anything is wrong with the user input, the program will scream at you as it should
        //

        private void ErrorCheck()
        {
            Input.Text = Input.Text.ToLower();
            if (ECheck.Checked == false && DCheck.Checked == false && HCheck.Checked == false)
            {
                Output.Text += "ERROR ERROR ERROR PLEASE CHECK A CHECKMARK ERROR ERROR ERROR";
                Output.Text += Environment.NewLine;
            }
            if (Input == null)
            {
                Output.Text = "ERROR ERROR ERROR PLEASE MAKE AN INPUT ERROR ERROR ERROR";
            }
            for (int i = 0; i < Input.Text.Length; i++)
            {
                bool broken = false;
                if (!char.IsLetter(Input.Text[i])) { Output.Text = "ERROR ERROR ERROR ONLY LATIN LETTERS ERROR ERROR ERROR"; broken = true; }
                if (broken) break;
            }
        }

        //
        // This is to make sure only one checkbox is checked at a time...
        //

        private void ECheck_CheckedChanged(object sender, EventArgs e)
        {
            DCheck.Checked = false;
            HCheck.Checked = false;
        }

        private void DCheck_CheckedChanged(object sender, EventArgs e)
        {
            ECheck.Checked = false;
            HCheck.Checked = false;
        }

        private void HCheck_CheckedChanged(object sender, EventArgs e)
        {
            ECheck.Checked = false;
            DCheck.Checked = false;
        }

        public static int Gcd(int a, int b)
        {

            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }
    }

    //
    //
    // These class files are specialized for the Playfair Cipher (starting at line 591)
    //
    //

    public class Block
    {
        public char ch = 'a';
        public int row = 0;
        public int col = 0;
        public int dep = 0;

        public Block()
        {
            ch = 'a';
            row = 0;
            col = 0;
            dep = 0;
        }
    }

    public class PlayfairClass
    {
        public Block[,] Square = new Block[5, 5];
        public Block[,,] Cube = new Block[5, 5, 5];
        public char Special;

        public PlayfairClass()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Block b = new Block();
                    Square[j, i] = b;
                }
            }
        }

        public static Block BlockifySquare(PlayfairClass play, char c)
        {
            Block b = new Block();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (c == play.Square[j, i].ch)
                    {
                        b.ch = c;
                        b.row = j;
                        b.col = i;
                        return b;
                    }
                }
            }

            return b;
        }

        public static Block BlockifyCube(PlayfairClass play, char c)
        {
            Block b = new Block();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (c == play.Cube[j, i, k].ch)
                        {
                            b.ch = c;
                            b.row = j;
                            b.col = i;
                            b.dep = k;
                            return b;
                        }
                    }
                }
            }

            return b;
        }

        public static string SquareCipher(PlayfairClass play, Block c1, Block c2)
        {
            string output = string.Empty;

            if (c1.ch == c2.ch)
            {
                //output += SquareCipher(play, c1, BlockifySquare(play, play.Special));
                output += c1.ch; output += c2.ch;
                return output;
            }
            if (c1.row == c2.row)
            {
                c1.col = (c1.col + 1) % 5;
                c2.col = (c2.col + 1) % 5;
                output += play.Square[c1.row, c1.col].ch; output += play.Square[c2.row, c2.col].ch;
                return output;

            }
            if (c1.col == c2.col)
            {
                c1.row = (c1.row + 1) % 5;
                c2.row = (c2.row + 1) % 5;
                output += play.Square[c1.row, c1.col].ch; output += play.Square[c2.row, c2.col].ch;
                return output;
            }
            if (c1.col != c2.col && c1.row != c2.row)
            {
                output += play.Square[c2.row, c1.col].ch;
                output += play.Square[c1.row, c2.col].ch;
                return output;
            }
            //if (c2.ch == play.Special)
            //{
            //    output += c1.ch + c2.ch;
            //    return output;
            //}

            return output;
        }

        public string SquareEncipher(PlayfairClass play, string message)
        {
            string output = string.Empty;

            if (message.Length % 2 != 0)
            {
                message += play.Special;
            }

            for (int i = 0; i < message.Length; i += 2)
            {
                if (i < message.Length)
                {
                    output += SquareCipher(play, BlockifySquare(play, message[i]), BlockifySquare(play, message[i + 1]));
                    //if (message[i] == message[i + 1]) i--;
                }
            }

            if (message.Length % 2 != 0)
            {
                message += play.Special;
            }

            return output;
        }

        public string SquareDecryptor(PlayfairClass play, string message)
        {
            string output = string.Empty;

            if (message.Length % 2 != 0)
            {
                message += play.Special;
            }

            for (int i = 0; i < message.Length; i += 2)
            {
                if (i < message.Length)
                {
                    output += SquareDecipher(play, BlockifySquare(play, message[i]), BlockifySquare(play, message[i + 1]));
                    //if (message[i] == message[i + 1]) i--;
                }

            }

            if (message.Length % 2 != 0)
            {
                message += play.Special;
            }

            return output;
        }

        public static string SquareDecipher(PlayfairClass play, Block c1, Block c2)
        {
            string output = string.Empty;

            if (c1.ch == c2.ch)
            {
                //c1.row = (c1.row - 1) % 5; if (c1.row < 0) c1.row = 4;
                //c2.row = (c2.row - 1) % 5; if (c2.row < 0) c2.row = 4;
                //output += play.Square[c1.row, c1.col].ch; output += play.Square[c2.row, c2.col].ch;
                //output += SquareDecipher(play, c1, BlockifySquare(play, play.Special));
                output += c1.ch; output += c2.ch;
                return output;
            }
            if (c1.row == c2.row)
            {
                c1.col = (c1.col - 1) % 5; if (c1.col < 0) c1.col = 4;
                c2.col = (c2.col - 1) % 5; if (c2.col < 0) c2.col = 4;
                output += play.Square[c1.row, c1.col].ch; output += play.Square[c2.row, c2.col].ch;
                return output;

            }
            if (c1.col == c2.col)
            {
                c1.row = (c1.row - 1) % 5; if (c1.row < 0) c1.row = 4;
                c2.row = (c2.row - 1) % 5; if (c2.row < 0) c2.row = 4;
                output += play.Square[c1.row, c1.col].ch; output += play.Square[c2.row, c2.col].ch;
                return output;
            }
            if (c1.col != c2.col && c1.row != c2.row)
            {
                output += play.Square[c2.row, c1.col].ch;
                output += play.Square[c1.row, c2.col].ch;
                return output;
            }
            //if (c2.ch == play.Special)
            //{
            //    output += c1.ch + c2.ch;
            //    return output;
            //}

            return output;
        }

        public static string SquareDecipher2(PlayfairClass play, Block c1, Block c2)
        {
            string output = string.Empty;

            if (c1.ch == c2.ch)
            {
                c1.row = (c1.row - 1) % 5; if (c1.row < 0) c1.row = 5;
                c2.row = (c2.row - 1) % 5; if (c2.row < 0) c2.row = 5;
                //output += SquareCipher(play, c1, BlockifySquare(play, play.Special));
                //output += c1.ch; output += play.Special;
                return output;
            }
            if (c1.row == c2.row)
            {
                c1.row = (c1.row - 1) % 5; if (c1.row < 0) c1.row = 5;
                c2.row = (c2.row - 1) % 5; if (c2.row < 0) c2.row = 5;
                output += play.Square[c1.row, c1.col].ch; output += play.Square[c2.row, c2.col].ch;
                return output;

            }
            if (c1.col == c2.col)
            {
                c1.col = (c1.col - 1) % 5; if (c1.col < 0) c1.col = 5;
                c2.col = (c2.col - 1) % 5; if (c2.col < 0) c2.col = 5;
                output += play.Square[c1.row, c1.col].ch; output += play.Square[c2.row, c2.col].ch;
                return output;
            }
            if (c1.col != c2.col && c1.row != c2.row)
            {
                output += play.Square[c2.row, c1.col].ch;
                output += play.Square[c1.row, c2.col].ch;
                return output;
            }
            if (c2.ch == play.Special)
            {
                output += c1.ch + c2.ch;
                return output;
            }

            return output;
        }



        public static string CubeCipher(PlayfairClass play, Block c1, Block c2)
        {
            string output = string.Empty;

            if (c1.ch == c2.ch)
            {
                output += CubeCipher(play, c1, BlockifyCube(play, play.Special));
                //output += c1.ch; output += play.Special;
                return output;
            }
            if (c1.row == c2.row)
            {
                c1.col = (c1.col + 1) % 5;
                c2.col = (c2.col + 1) % 5;
                output += play.Cube[c1.row, c1.col, c1.dep].ch; output += play.Cube[c2.row, c2.col, c2.dep].ch;
                return output;

            }
            if (c1.col == c2.col)
            {
                c1.row = (c1.row + 1) % 5;
                c2.row = (c2.row + 1) % 5;
                output += play.Cube[c1.row, c1.col, c1.dep].ch; output += play.Cube[c2.row, c2.col, c2.dep].ch;
                return output;
            }
            if (c1.dep == c2.dep)
            {
                c1.dep = (c1.dep + 1) % 5;
                c2.dep = (c2.dep + 1) % 5;
                output += play.Cube[c1.row, c1.col, c1.dep].ch; output += play.Cube[c2.row, c2.col, c2.dep].ch;
                return output;
            }
            if (c1.col != c2.col && c1.row != c2.row)
            {
                output += play.Cube[c2.row, c1.col, c2.dep].ch;
                output += play.Cube[c1.row, c2.col, c1.dep].ch;
                return output;
            }
            if (c2.ch == play.Special)
            {
                output += c1.ch + c2.ch;
                return output;
            }

            return output;
        }

        public static string CubeEncipher(PlayfairClass play, string message)
        {
            string output = string.Empty;

            if (message.Length % 2 != 0)
            {
                message += play.Special;
            }

            for (int i = 0; i < message.Length + 2; i += 2)
            {
                if (i + 2 < message.Length)
                {
                    output += CubeCipher(play, BlockifyCube(play, message[i]), BlockifyCube(play, message[i + 1]));
                    if (message[i] == message[i + 1]) i--;
                }
            }

            if (message.Length % 2 != 0)
            {
                message += play.Special;
            }

            return output;
        }

        public static string CubeDecipher(PlayfairClass play, Block c1, Block c2)
        {
            return null;
        }


    }
}
