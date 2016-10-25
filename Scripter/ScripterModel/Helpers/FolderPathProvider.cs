using System;
using System.IO;

namespace ScripterModel.Helpers
{
    public class FolderPathProvider
    {
        public const string FOLDER_NAME = @"Dell\Scripts";
        public const string SCRIPT_EXTENSION = "py";
        public string ProfilesPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), FOLDER_NAME);

        public string getScriptExtension()
        {
            return SCRIPT_EXTENSION;
        }
    }
}
