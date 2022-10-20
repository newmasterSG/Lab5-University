using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocumentWorker
{
    internal class ProDocumentWorker:DocumentWorker
    {
        public override string Path { get => base.Path; set => base.Path = value; }
        public virtual string Line
        {
            get;
            set;
        }
        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override async void EditDocument()
        {
            Console.WriteLine("Документ відредаговано");
            using(StreamWriter sr = new StreamWriter(Path,true))
            {
                await sr.WriteLineAsync(Line);
            }
            this.OpenDocument();
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
        }
    }
}
