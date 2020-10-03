using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaber_CustomLevelCleanup
{
    public class CustomLevel
    {
        public String SongHash { get; }
        public String Directory { get; }

        public String TrimmedDirectory
        {
            get
            {
                return Path.GetFileName(this.Directory);
            }
        }

        public bool IsFavorite { get; set; }

        public CustomLevel(String path, String hash)
        {
            IsFavorite = false;
            SongHash = hash;
            Directory = path;
        }

    }
}
