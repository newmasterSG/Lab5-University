using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class ClassRoom
    {
        List<Pupil> pupils1 = new List<Pupil>();
        public ClassRoom(List<Pupil> pupils)
        {
            pupils1 = pupils;
        }

        public void AddPupil(Pupil pupil)
        {
            pupils1.Add(pupil);
        }

        public void InfoAboutClassRoom()
        {
            foreach (Pupil p in pupils1)
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
