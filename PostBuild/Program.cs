using Microsoft.Win32;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        static string GetGameDir()
        {
            var paths = new List<string>()
            {
                (string)Registry.LocalMachine?.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam")?.GetValue("InstallPath")
            };
            if (paths[0] == null || !Directory.Exists(paths[0]))
                return string.Empty;

            string config = File.ReadAllText($"{paths[0]}\\config\\config.vdf");
            paths.AddRange(Regex.Matches(config, "\"BaseInstallFolder_[0-9]\"\\s+\"([^\"]+)\"")
                .Select(match => match.Groups[1].Value.Replace("\\\\", "\\")));

            string startVDF = File.ReadAllText($"{paths[0]}\\steamapps\\libraryfolders.vdf");
            paths.AddRange(Regex.Matches(startVDF, "\"path\"\\s+\"([^\"]+)\"")
                .Select(match => match.Groups[1].Value.Replace("\\\\", "\\")));

            foreach (string path in paths)
            {
                string assembliesPath = $"{path}\\steamapps\\common\\Plasma";
                if (Directory.Exists(assembliesPath))
                    return assembliesPath;
            }
            return string.Empty;
        }
        
        /*DirectoryInfo SelfDir = new DirectoryInfo(Environment.CurrentDirectory).Parent!.Parent!.Parent!;
        DirectoryInfo BaseDir = SelfDir.Parent!;
        var ProjectDirectories = BaseDir.GetDirectories()
            .Where(dir => 
            dir.Name != SelfDir.Name
            && !dir.Name.StartsWith(".")
            && dir.GetDirectories()
                .Where(subdir => subdir.Name.Equals("bin")).Any());*/

        string GameDir = GetGameDir();
        DirectoryInfo DataDir = new(Path.Combine(GameDir, "Plasma_Data", "Managed"));
        DirectoryInfo ModsDir = new(Path.Combine(GameDir, "Mods"));
        DirectoryInfo ModLoaderDir = new(Path.Combine(GameDir, "ModLoader"));
        IEnumerable<string> GameDLLs = DataDir.GetFiles().Select(f => f.Name);

        ModsDir.GetFiles().Where(f => GameDLLs.Contains(f.Name)).DeleteAll();
        ModLoaderDir.GetFiles().Where(f => GameDLLs.Contains(f.Name)).DeleteAll();
    }
}
internal static class Extensions
{
    public static void DeleteAll(this IEnumerable<FileInfo> files)
    {
        foreach (FileInfo file in files)
        {
            file.Delete();
        }
    }
}