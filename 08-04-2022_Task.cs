using System;
using System.Collections.Generic;
using System.Text;

namespace _08_04_2022_LearningProcess
{
    // Write a program to find how many goats and ducks are there, if in total there are 80 legs and 52 eyes.
    class _08_04_2022_Task
    {
        public static void Main()
        {
            int legs = 80;
            int eyes = 52;
            int TotalHead = eyes / 2;
            int g = legs / 2 - TotalHead; // or  d = eyes - legs/2
            int d = TotalHead - g;        // or  g = TotalHead-d   
            Console.Write("Goats = {0} Ducks = {1} " , g, d);            
        }
    }
}
