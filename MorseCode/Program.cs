using System;
using System.Threading;
using System.Text.RegularExpressions;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(TextToMorse("SOS1"));
        }

        public static void Morse(string morse)
        {
            foreach (char chars in morse.ToCharArray())
            {
                if (chars != '/' && chars != '.' && chars != '-' && chars != ' ')
                {
                    throw new Exception("Values can only be '-', '.', '/', or ' ' ");
                }
            }


            foreach (char chars in morse.ToCharArray())
            {
                if (chars == '/')
                {
                    Thread.Sleep(700);
                }
                else if (chars == '.')
                {
                    Console.Beep(800, 100);
                    Thread.Sleep(100);
                }
                else if (chars == '-')
                {
                    Console.Beep(800, 300);
                    Thread.Sleep(100);
                }
                else if (chars == ' ')
                {
                    Thread.Sleep(300);
                }
            }
        }

        public static string TextToMorse(string text)
        {
            string morse = string.Empty;

            foreach (char chars in text.ToLower().ToCharArray())
            {
                if (!char.IsLetterOrDigit(chars))
                {
                    throw new Exception("Can only be letter or number");
                }
            }

            foreach (char chars in text.ToLower().ToCharArray())
            {
                switch (chars)
                {
                    case 'a':
                        morse += ".-";
                        break;
                    case 'b':
                        morse += "-...";
                        break;
                    case 'c':
                        morse += "-.-.";
                        break;
                    case 'd':
                        morse += "--.";
                        break;
                    case 'e':
                        morse += ".";
                        break;
                    case 'f':
                        morse += "..-.";
                        break;
                    case 'g':
                        morse += "--.";
                        break;
                    case 'h':
                        morse += "....";
                        break;
                    case 'i':
                        morse += "..";
                        break;
                    case 'j':
                        morse += ".---";
                        break;
                    case 'k':
                        morse += "-.-";
                        break;
                    case 'l':
                        morse += ".-..";
                        break;
                    case 'm':
                        morse += "--";
                        break;
                    case 'n':
                        morse += "-.";
                        break;
                    case 'o':
                        morse += "---";
                        break;
                    case 'p':
                        morse += ".--.";
                        break;
                    case 'q':
                        morse += "--.-";
                        break;
                    case 'r':
                        morse += "";
                        break;
                    case 's':
                        morse += "...";
                        break;
                    case 't':
                        morse += "-";
                        break;
                    case 'u':
                        morse += "..-";
                        break;
                    case 'v':
                        morse += "...-";
                        break;
                    case 'w':
                        morse += ".--";
                        break;
                    case 'x':
                        morse += "-..-";
                        break;
                    case 'y':
                        morse += "-.--";
                        break;
                    case 'z':
                        morse += "--..";
                        break;
                    case '1':
                        morse += ".----";
                        break;
                    case '2':
                        morse += "..---";
                        break;
                    case '3':
                        morse += "...--";
                        break;
                    case '4':
                        morse += "....-";
                        break;
                    case '5':
                        morse += ".....";
                        break;
                    case '6':
                        morse += "-....";
                        break;
                    case '7':
                        morse += "--...";
                        break;
                    case '8':
                        morse += "---..";
                        break;
                    case '9':
                        morse += "----.";
                        break;
                    case '0':
                        morse += "-----";
                        break;
                }
                morse += " ";
            }

            morse = Regex.Replace(morse,"  ", "/");

            return morse; 
        }

    }
}
