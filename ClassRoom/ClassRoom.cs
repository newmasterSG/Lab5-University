using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class ClassRoom
    {

        public ClassRoom(List<Pupil> pupils)
        {
            foreach (Pupil p in pupils)
            {
                if (p != null)
                {
                    p.Study();
                    p.Write();
                    p.Read();
                    p.Relax();
                }
            }
        }
    }
}
