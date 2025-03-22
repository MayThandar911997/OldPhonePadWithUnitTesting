using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool enterHit = false;
            while(true)
            {
                DateTime latestPressedTime = DateTime.Now;
                string input = "";
                Console.WriteLine("Start typing using old phone keypad... (Press 'Enter' to finish)");
                while (true)
                {
                    
                    var inputKey = Console.ReadKey();
                    if(inputKey.Key == ConsoleKey.Enter)
                    {
                        enterHit = true;
                        break;
                    }
                    if (inputKey.KeyChar == '#')
                    {
                        break;
                    }
                    DateTime currentPressedTime = DateTime.Now;
                    if (inputKey.KeyChar != '*')
                    {
                        if ((currentPressedTime - latestPressedTime).TotalSeconds > 1)
                        {
                            input += " ";
                        }

                    }
                    latestPressedTime = currentPressedTime;
                    input += inputKey.KeyChar;
                }
                if(!enterHit )
                {
                    Console.WriteLine("\nInput value -> " + input + "#");
                    OldPhoneApp app = new OldPhoneApp();
                    string output = app.OldPhonePad(input);
                    Console.WriteLine("Output value -> " + output.ToString() + "\n");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
