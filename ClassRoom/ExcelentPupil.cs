using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class ExcelentPupil:Pupil
    {

        public override void Read()
        {
            Console.WriteLine("I can read a whole page in 5 seconds");
        }

        public override void Study()
        {
            Console.WriteLine("I am excelent pupil");
            Console.WriteLine("I'm always learning to rank A");
        }

        public override void Relax()
        {
            Console.WriteLine("What is rest?");
        }

        public override void Write()
        {
            Console.WriteLine("I can write one hundred and forty words in one minute");
        }
    }
}
