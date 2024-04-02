namespace DesignPatterns.Factory;

using System.IO;
public class FileReadOperation : IFileOperation
{
    public void Execute(string filePath)
    {
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);
    }
}