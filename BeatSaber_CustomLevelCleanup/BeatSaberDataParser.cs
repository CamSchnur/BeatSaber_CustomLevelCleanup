using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaber_CustomLevelCleanup
{
    public class BeatSaberDataParser
    {
        public static List<String> GetFavoriteLevelsFromPlayerDataFile(String playerData)
        {
            //Need to parse PlayerData file. Start by finding the "Favorites" section.
            int favoritesStart = playerData.IndexOf("favoritesLevelIds");
            int nextSectionStart = playerData.IndexOf("guestPlayers");
            String favLevelsSection = playerData.Substring(favoritesStart, nextSectionStart - favoritesStart);

            //Now that we have the favorites section, trim it down to just the comma-separated list of levels
            int listStart = favLevelsSection.IndexOf('[') + 1;
            int listEnd = favLevelsSection.IndexOf(']');

            //split out the level IDs and remove the trailing and leading quotes, and return.
            String commaSeparatedLevelIds = favLevelsSection.Substring(listStart, listEnd - listStart);
            List<String> favoriteLevels = commaSeparatedLevelIds.Split(',').ToList<String>();

            return favoriteLevels.Select(s => s.Trim('"')).ToList<String>();
        }

        public static List<CustomLevel> GetCustomLevelsFromSongHashFile(String songHashData)
        {
            List<CustomLevel> levels = new List<CustomLevel>();
            //Our input file is of the format:
            //{"c:\\somepath":{"directoryHash":1234,"songHash":"123ABC"},
            //"c:\\somepath2":{"directoryHash":12345,"songHash":"123ABCD"}}

            //Start by trimming the leading and trailing brackets, then split into strings representing each level.
            //Also trim the *second* trailing bracket (for the last item in the list), as the trailing brackets for each other item will be removed as part of the Split.
            String commaSeparatedLevels = songHashData.Substring(1, songHashData.Length - 3);
            List<String> levelsToParse = commaSeparatedLevels.Split(new String[] { "}," }, StringSplitOptions.None).ToList<String>();

            //Next, we will parse each level string into a CustomLevel object.
            foreach (String s in levelsToParse)
            {
                //Format is:
                //"C:\\somepath":{"directoryHash":1234,"songHash":"123ABC"
                //(notice: trailing bracket has been removed by our splitting process.

                int pathEnd = s.IndexOf(":{");
                String songHashLocator = "\"songHash\":";
                int hashStart = s.IndexOf(songHashLocator) + songHashLocator.Length;
                String path = s.Substring(0, pathEnd).Trim('"');
                String hash = s.Substring(hashStart, s.Length - hashStart).Trim('"');
                levels.Add(new CustomLevel(path, hash));
            }
            return levels;

        }
    }
}
