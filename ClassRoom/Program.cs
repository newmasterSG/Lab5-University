using System;

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
            ClassRoom classRoom = new ClassRoom(excelentPupil,badPupil2,badPupil2,goodPupil);

        }
    }
}
