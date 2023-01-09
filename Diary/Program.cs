using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class notepad
{
    public void CreateFile(string filename)
    {
        File.Create(filename).Close();
    }
    public void WriteToFile(string filename,string text)
    {
        File.AppendAllText(filename, text);
    }

    public void ReadFile(string filename)
    {
        string contents = File.ReadAllText(filename);
        Console.WriteLine(contents);
    }

    public static void Main(string[] args)
    {
        notepad notepad = new notepad();

        Console.WriteLine("Instructions:");
        Console.WriteLine("type {[save]} to save file");
        Console.WriteLine("type {[exit]} to quit file\n");

        Console.Write("Filename\n> ");
        string FileName = $"{Console.ReadLine().ToString()}.txt";

        Console.Write("Path\n> ");
        string Path = Console.ReadLine().ToString();

        string FilePathName = $"{Path}\\{FileName}";
        Console.WriteLine(FilePathName);
        var a1 = true;
        if (a1)
        {
            notepad.CreateFile(FilePathName);
            Console.Clear();

            string Line;
            string TextFile = "";

            while (1 == 1)
            {
                Console.Write($"> ");
                Line = Console.ReadLine().ToString();

                if (Line == "{[save]}")
                {
                    notepad.WriteToFile(FilePathName, TextFile);
                    goto Tfile2;
                }

                else if (Line == "{[exit]}")
                {
                    break;
                }
                goto Textfile1;

                Textfile1:
                    if (TextFile == "")
                    {
                        TextFile = TextFile + Line;
                    }
                    else
                    {
                        TextFile = TextFile + "\n" + Line;
                    }
                Tfile2:
                    continue;
            }
        }
    }
}