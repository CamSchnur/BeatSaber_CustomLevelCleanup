# BeatSaber_CustomLevelCleanup

This is a Windows utililty to help keep your Custom Levels list clean for the game Beat Saber.

## Background

I download and play custom levels for the game, and star the ones that I like using the in-game menu, but generally want to delete the others.  There is not an easy way to delete those custom levels in-game, or to know outside of the game what levels you have starred.

This app uses the BeatSaber 'playerdata.dat' and 'songhashdata.dat' files to find which levels in your custom levels folder you have *not* starred, and then deletes them.

## More Details
* The app will not delete any of the "built-in" custom levels from the designers of the game
* The app will not delete any custom levels in the user's WIP custom levels folder
* After confirming that the files are OK to be deleted, they will be sent to the recycle bin, in case you need to retrieve them

Note that the app will simply delete the custom level folder, it will not delete associated information out of the game's .dat files.  If you run the app twice in a row, you will still see the custom levels to delete showing up in your list.  Next time you run the game, however, it will clean up the .dat files.  You can then run this app again later and see an empty list under "levels to delete". 

## Releases

If you would like the compiled version for Windows, check out the Releases tab.  There, just download BeatSaber_CustomLevelCleanup.exe and the associated .config file, and run them.
