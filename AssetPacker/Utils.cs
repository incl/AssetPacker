using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace AssetPacker
{
    class Utils
    {
        static public Assembly GetAssemblyByName(string name)
        {
            return System.AppDomain.CurrentDomain.GetAssemblies().
                   SingleOrDefault(assembly => assembly.GetName().Name == name);
        }

        static public List<string> GetSubDirectories(string root, string re = null)
        {
            var list = new List<string>();
            if (string.IsNullOrEmpty(re))
                re = root;
            var dirs = System.IO.Directory.GetDirectories(re);
            foreach (var dir in dirs)
            {
                list.Add(dir);
                //list.AddRange(GetSubDirectories(root, dir));
            }
            return list;
        }
    }
}
