using System;

namespace Witchpot.Editor.StableDiffusion
{
    public static class EditorPaths
    {
        public const string WITCHPOT_ROOT = "Assets/Plugins/Witchpot/";
        public const string WEBUI_SCRIPT_PATH = "Assets/Plugins/Witchpot/Packages/StableDiffusion/Editor/Tools/run.py";

        public const string WEBUI_PATH = "/witchpot/StableDiffusion.WebUI@1.2.0";
        //public static string ROOT_PATH => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+WEBUI_PATH;
        public static string ROOT_PATH => Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + WEBUI_PATH;
        public static string WEBUI_SCRIPT_BAT_PATH => ROOT_PATH + "/run.bat";
        public static string PYTHON_EXE_PATH => ROOT_PATH + "/system/python/python.exe";
    }
}
