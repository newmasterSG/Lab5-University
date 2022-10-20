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

        public override  void SaveDocument()
        {
            string currentExtension = System.IO.Path.GetExtension(Path);
            Console.WriteLine($"past file extension is {currentExtension}");
            string newPath = System.IO.Path.ChangeExtension(Path, Extension);
            using (StreamWriter sw = new StreamWriter(newPath))
            {
              sw.WriteLine(Line);
            }
            Console.WriteLine("Документ збережений в новому форматі");
            string newExtension = System.IO.Path.GetExtension(newPath);
            Console.WriteLine($"Current file extension is {newExtension}");
        }
    }
}

/*
 using (var salsa = new Salsa20.Salsa20())
            {
                using (var fstream_out = new FileStream(filePath, FileMode.Truncate, FileAccess.ReadWrite, FileShare.Write))
                {
                    salsa.Key = key;
                    salsa.IV = iv;
                    using (var cstream = new CryptoStream(fstream_out, salsa.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        var bytes = File.ReadAllBytes(filePath);
                        cstream.Write(bytes, 0, bytes.Lenght);
                    }
                }
            } 
 */

/*
 var bytes = File.ReadAllBytes(filePath);
using (var salsa = new Salsa20.Salsa20())
{
    using (var fstream_out = new FileStream(filePath, FileMode.Truncate, FileAccess.Write))
    {
        salsa.Key = key;
        salsa.IV = iv;
        using (var cstream = new CryptoStream(fstream_out, salsa.CreateEncryptor(), CryptoStreamMode.Write))
        {
            cstream.Write(bytes, 0, bytes.Lenght);
        }
    }
}
 */