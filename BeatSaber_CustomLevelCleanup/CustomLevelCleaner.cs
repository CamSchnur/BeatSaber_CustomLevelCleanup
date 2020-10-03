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
            String songHashData = File.ReadAllText(songHashFile);

            //First, find a list of custom level IDs.
            List <String> favorites = BeatSaberDataParser.GetFavoriteLevelsFromPlayerDataFile(playerData);

            //Next, Get a list of custom level locations mapped to custom level IDs.
            List<CustomLevel> customLevels = BeatSaberDataParser.GetCustomLevelsFromSongHashFile(songHashData);

            //Next, update the custom levels to indicate whether each is included in the "Favorites" list.
            foreach(CustomLevel c in customLevels)
            {
                foreach(String s in favorites)
                {
                    if(s.StartsWith("custom_level_"))
                    {
                        if(s == "custom_level_" + c.SongHash)
                        {
                            //this song appears in the favorites list.
                            c.IsFavorite = true;
                            break;
                        }                        
                    }
                }
                if(c.Directory.Contains("CustomWIPLevels"))
                {
                    //this is a custom in-progress level (presumably the user created it).  don't delete this one either.
                    c.IsFavorite = true;
                }
            }


            //Confirm the full selection with the user before taking any action
            ConfirmationDialog d = new ConfirmationDialog(customLevels);

            if(d.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }    


            
            
            //Once the user has confirmed, perform the deletes.
            
            


        }

        
    }
}
