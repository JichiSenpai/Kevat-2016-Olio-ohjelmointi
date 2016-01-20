using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus19
    {
        static void Main(string[] args)
        {
            string[] word;
            word = new string[5] {"p", "i", "s", "s", "a"};
            string[] solution;
            solution = new string[5] { "-", "-", "-", "-", "-"};

            bool looppi = true;

            while (looppi)
            {
                Console.Write("Anna kirjain > ");

                string uinput = Console.ReadLine();

                if (uinput == word[0])
                {
                    bool isUsed;
                    if (isUsed = false)
                    {
                        solution[0] = word[0];
                        isUsed = true;
                    }
                    if (isUsed = true)
                    {
                        Console.WriteLine("Anna jokin muu kirjain");
                    }
                }

                if (uinput == word[1])
                {
                    bool isUsed;
                    if (isUsed = false)
                    {
                        solution[1] = word[1];
                        isUsed = true;
                    }
                    if (isUsed = true)
                    {
                        Console.WriteLine("Anna jokin muu kirjain");
                    }
                }

                if (uinput == word[2])
                {
                    bool isUsed;
                    if (isUsed = false)
                    {
                        solution[2] = word[2];
                        isUsed = true;
                    }
                    if (isUsed = true)
                    {
                        Console.WriteLine("Anna jokin muu kirjain");
                    }
                }

                if (uinput == word[3])
                {
                    bool isUsed;
                    if (isUsed = false)
                    {
                        solution[3] = word[3];
                        isUsed = true;
                    }
                    if (isUsed = true)
                    {
                        Console.WriteLine("Anna jokin muu kirjain");
                    }
                }

                if (uinput == word[4])
                {
                    bool isUsed;
                    if (isUsed = false)
                    {
                        solution[4] = word[4];
                        isUsed = true;
                    }
                    if (isUsed = true)
                    {
                        Console.WriteLine("Anna jokin muu kirjain");
                    }
                }

                string solutionstring = new string(solution[]);
                Console.WriteLine(solutionstring);
                /*for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word[i]);
                }*/
            }
        }
    }
}
