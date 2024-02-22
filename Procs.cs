using System.Text;

namespace NotepadPlus.Procs
{
    public struct UUID
    {
        private readonly Guid[] _ids;
        public UUID()
        {
            _ids = new Guid[4];
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (Guid id in _ids) 
            { 
                sb.Append(id.ToString());
            }
            return sb.ToString();
        }
    }
    internal static class Extra
    {
        internal static T OpenForm<T>() where T : Form , new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is T rt)
                {
                    form.Focus();
                    return rt;
                }
            }
            T rtn = new();
            rtn.Show();
            return rtn;
        }
    }
    internal static class Logger
    {
        internal static StringBuilder _log = new();
        internal static void Log(string msg, LogLevel level = LogLevel.Info)
        {
            if (_log.Length > 0) 
            {
                _log.Append($"[{level.ToString()}/{Thread.CurrentThread}/{DateTime.Now}]:{msg}");
            }
        }
        internal enum LogLevel
        {
            Info,
            Warn,
            Error,
            Fatal
        }
    }
    internal static class Localizer
    {
        internal static Lang currentLang = new();
        internal static Dictionary<string, Lang> _langs = new();
        internal static void LoadAll(string dirPath)
        {
            foreach (string str in Directory.GetFiles(dirPath))
            {
                string fn = Path.GetFileName(str);
                if (fn.Contains(".npl"))
                {
                    _langs.TryAdd( fn.Replace(".npl",string.Empty), Lang.GetFromFile( str ) );
                }
            }
        }
        public static Lang GetLang( string langCode )
        {
            return _langs.TryGetValue( langCode, out Lang? value ) ? value : new Lang();
        }
    }
    internal class Lang
    {
        internal Dictionary<string, string> _strings = new();
        internal static Lang GetFromFile( string filePath )
        {
            Lang lang = new();
            try
            {
                if (File.Exists(filePath))
                {

                    string[] tmp = File.ReadAllLines(filePath);
                    foreach (string str in tmp)
                    {
                        string[] strs = str.Replace("[", string.Empty).Replace("]", string.Empty).Split(',');
                        if(strs.Length is not 2)
                        {
                            break;
                        }
                        lang._strings.Add(strs[0], strs[1]);
                    }
                }
                return lang;
            }
            catch (Exception)
            {
                return lang;
            }
        }
        internal void WriteToFile(string filePath)
        {
            StringBuilder sb = new();
            foreach (KeyValuePair<string,string> kvp in _strings)
            {
                sb.Append(kvp.ToString()+'\n');
            }
            File.WriteAllText(filePath + ".npl",sb.ToString());
        }
        public string GetString( string key )
        {
            return _strings.GetValueOrDefault(key) ?? key;
        }
    }
}
