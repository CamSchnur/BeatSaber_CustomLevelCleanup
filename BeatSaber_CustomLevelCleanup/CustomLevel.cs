using System;
using System.Collections.Generic;
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

        public CustomLevel(String hash, String path)
        {
            SongHash = hash;
            Directory = path;
        }
    }
}
