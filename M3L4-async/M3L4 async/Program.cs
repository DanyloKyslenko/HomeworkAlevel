using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var result = await ConcatenateFilesAsync();
        Console.WriteLine(result);
    }

    static async Task<string> ReadFileAsync(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            return await reader.ReadToEndAsync();
        }
    }

    static async Task<string> ConcatenateFilesAsync()
    {
        var filePath1 = "Hello.txt";
        var filePath2 = "World.txt";

        var task1 = ReadFileAsync(filePath1);
        var task2 = ReadFileAsync(filePath2);

        await Task.WhenAll(task1, task2);

        return task1.Result + " " + task2.Result;
    }
}