using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class ClassRoom
    {


        public ClassRoom(Pupil pupil1,Pupil pupil2,Pupil pupil3, Pupil pupil4)
        {
            pupil1.Study();
            pupil1.Write();
            pupil1.Relax();
            pupil1.Read();
            pupil2.Study();
            pupil2.Write();
            pupil2.Relax();
            pupil2.Read();
            pupil3.Study();
            pupil3.Write();
            pupil3.Relax();
            pupil3.Read();
            pupil4.Study();
            pupil4.Write();
            pupil4.Relax();
            pupil4.Read();
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupil1.Study();
            pupil1.Write();
            pupil1.Relax();
            pupil1.Read();
            pupil2.Study();
            pupil2.Write();
            pupil2.Relax();
            pupil2.Read();
            pupil3.Study();
            pupil3.Write();
            pupil3.Relax();
            pupil3.Read();
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupil1.Study();
            pupil1.Write();
            pupil1.Relax();
            pupil1.Read();
            pupil2.Study();
            pupil2.Write();
            pupil2.Relax();
            pupil2.Read();
        }
    }
}
