using System.Text;

namespace NotepadPlus
{
    internal static class Extra
    {
        internal static T OpenForm<T>() where T : Form , new()
        {
            T form = new();
            form.Show();
            return form;
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
                FileInfo fi = new(str);
                if (fi.Name.Contains(".npl"))
                {
                    _langs.Add( fi.Name.Replace(".npl",string.Empty), Lang.GetFromFile( str ) );
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
