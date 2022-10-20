using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DocumentWorker
{
    internal class ExpertDocumentWorker:ProDocumentWorker
    {
        public override string Path { get => base.Path; set => base.Path = value; }
        public override string Line { get => base.Line; set => base.Line = value; }

        public virtual string Extension { get; set; }

        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            base.EditDocument();
        }

        public override void SaveDocument()
        {
            string currentExtension = System.IO.Path.GetExtension(Path);
            Console.WriteLine($"past file extension is {currentExtension}");
            string newExtension = System.IO.Path.ChangeExtension(Path, Extension);
            Console.WriteLine("Документ збережений в новому форматі");
            Console.WriteLine($"Current file extension is {newExtension}");
        }
    }
}
