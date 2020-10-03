using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeatSaber_CustomLevelCleanup
{
    public class CustomLevelCleaner
    {
        public static void CleanupUnstarredLevels(String playerDataFile, String songHashFile, String customLevelsDirectory)
        {
            String playerData = File.ReadAllText(playerDataFile);

            //First, find a list of favorite level IDs.
            List <String> favorites = GetFavoriteLevelsFromPlayerDataFile(playerData);

            //Next, Get a list of custom level locations.
            
            //Next, match up those IDs to actual directories

            //Next, delete every custom level directory not on the "favorites" list.


        }

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
    }
}
