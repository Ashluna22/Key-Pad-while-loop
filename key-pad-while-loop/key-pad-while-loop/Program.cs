using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace key_pad_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            string correctCode = "13579";

            while (continueProgram)
            {
                Console.WriteLine("Hello, Please enter key code: ");
                string code = Console.ReadLine();

                if (code == correctCode)
                {
                    continueProgram = false;
                    Console.WriteLine("Hello welcome home!");
                }
            }
        }
    }
}
