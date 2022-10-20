using System;
using System.Collections.Generic;

namespace ClassRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil();
            BadPupil badPupil1 = new BadPupil();
            BadPupil badPupil2 = new BadPupil();
            GoodPupil goodPupil = new GoodPupil();
            List<Pupil> pupils = new List<Pupil>();
            pupils.Add(goodPupil);
            pupils.Add(excelentPupil);
            pupils.Add(badPupil2);
            pupils.Add(badPupil1);
            ClassRoom classRoom = new ClassRoom(pupils);
            classRoom.InfoAboutClassRoom();
        }
    }
}
