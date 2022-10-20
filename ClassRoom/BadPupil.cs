using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("I don't like to read");
        }

        public override void Relax()
        {
           Console.WriteLine("I like hanging out somewhere");
        }

        public override void Study()
        {
            Console.WriteLine("I am bad pupil");
            Console.WriteLine("I hate studying");
        }

        public override void Write()
        {
           Console.WriteLine("Bad at grammar");
        }
    }
}
