using System;
using System.IO;

namespace DocumentWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @$"C:{Path.DirectorySeparatorChar}\Users{Path.DirectorySeparatorChar}quick{Path.DirectorySeparatorChar}Desktop{Path.DirectorySeparatorChar}Текстовый документ.txt";
            string line = "My name Yehor";
            string extension = ".doc";
            int password = Convert.ToInt32(Console.ReadLine());
            int result = password % 3;
            switch(result)
            {
                case 0:
                    {
                        DocumentWorker worker = new DocumentWorker();
                        worker.Path = path;
                        worker.OpenDocument();
                        worker.SaveDocument();
                        worker.EditDocument();
                        break;
                    }
                    case 1:
                    {
                        ProDocumentWorker proworker = new ProDocumentWorker();
                        proworker.Path = path;
                        proworker.Line = line;
                        proworker.OpenDocument();
                        proworker.EditDocument();
                        proworker.SaveDocument();
                        break;
                    }
                case 2:
                    {
                        ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                        expertDocumentWorker.Path = path;
                        expertDocumentWorker.Line = line;
                        expertDocumentWorker.Extension = extension;
                        expertDocumentWorker.OpenDocument();
                        expertDocumentWorker.EditDocument();
                        expertDocumentWorker.SaveDocument();
                        if(File.Exists(path))
                        {
                            Console.WriteLine("if you wanna you can delete file");
                            string askingAboutDelet = Console.ReadLine();
                            if(askingAboutDelet.ToLower() == "yes")
                            {
                                File.Delete(path);
                            }
                            else
                            {
                                Console.WriteLine($"File is not deleted");
                            }
                        }
                        break;
                    }
                default:
                    {
                        DocumentWorker worker = new DocumentWorker();
                        worker.Path = path;
                        worker.OpenDocument();
                        worker.SaveDocument();
                        worker.EditDocument();
                        break;
                    }
            }
        }
    }
}
