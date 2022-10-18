/*irectoryInfo[] files=*/
using System.IO;
Console.WriteLine(@"D:\");
ShowAllFoldersUnder(@"D:\Lineage2\", 0);
static void ShowAllFoldersUnder(string path, int indent)
{
    try
    {
        foreach (string folder in Directory.GetDirectories(path))
        {
            Console.WriteLine("{0}{1}", new string(' ', indent), Path.GetFileName(folder));
            string[] allfiles = Directory.GetFiles(folder);
            foreach (string filename in allfiles)
            {
                Console.WriteLine("{0}{1}", new string(' ', indent), filename);
            }
            ShowAllFoldersUnder(folder, indent + 2);
        }
    }
    catch (UnauthorizedAccessException) { }
}
