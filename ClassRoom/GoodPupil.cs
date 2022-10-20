using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("I can read a whole page in 15 seconds");
        }

        public override void Relax()
        {
            Console.WriteLine("I like walking and listening to music");
        }

        public override void Study()
        {
            Console.WriteLine("I am good pupil");
            Console.WriteLine("I'm always learning to middle rank ");
        }

        public override void Write()
        {
            Console.WriteLine("i like to write");
        }
    }
}
