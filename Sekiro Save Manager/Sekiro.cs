using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sekiro_Save_Manager
{
    internal class Sekiro
    {
        internal const string SaveFileExtension = ".sl2";
        internal const string SaveFileName = "S0000" + SaveFileExtension;

        /// <summary>
        ///     Gets the default base directory for storing profiles.
        /// </summary>
        internal static string GetDefaultBaseDirectory()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Sekiro");
        }

        /// <summary>
        ///     Gets a list of profile directories from the default base directory.
        /// </summary>
        internal static List<DirectoryInfo> GetProfileDirectories()
        {
            var paths = new List<DirectoryInfo>();

            foreach (var subDir in Directory.GetDirectories(GetDefaultBaseDirectory()))
            {
                var di = new DirectoryInfo(subDir);
                var isId = di.Name.All(c => c >= '0' && c <= '9');

                if (isId)
                {
                    paths.Add(di);
                }
            }

            return paths;
        }

        /// <summary>
        ///     Determines whether the provided path is a valid profile save directory.
        /// </summary>
        internal static bool IsProfilePathValid(string path)
        {
            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                var savePath = Path.Combine(path, SaveFileName);

                if (File.Exists(savePath))
                {
                    return true;
                }
            }

            return false;
        }
    }
}