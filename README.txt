Nintenlord's UPS patcher, NUPS

0===============0
 Version history
0===============0

V 1.0:
-First public release.

V 1.1:
-Added the ability to get details about the patch.
-Made an icon for the exe.

V 1.2
-Fixed the glitch that cut the end of the file if it's larger
 than the changed file patch was originally created with.
-Made it possible to use Read-only file as the original file
 when creating a patch

V 1.3
-Fixed a glitch on patching when sizes don't match (can't think 
 of good way to describe it).

V 1.4
-Improved performance for large patches (thanks to rehdi93 on Github)
-Improved printing format with large number of patch data to print

0=====0
 Usage
0=====0

-Patching:
Start the program and click the "Apply an UPS patch to a file" button.
Click the upper "Browse..." button and select the file you want
to patch. Then press the lower "Browse..." button and select the UPS file
you wish to apply. Click "Run". If a box pops up saying that the patching 
was aborted, it means you have selected either wrong file or wrong UPS patch.
Select correct files and try again.

-Creating a patch:
Start the program and click the "Create a new UPS patch" button.
Choose the original, unmodified file with the upper "Browse..." button and
the new, modified file with the second "Browse...". Finally, select the 
place where the new UPS patch will be saved using the lowest "Browse..."
button. Finally, click the "Run" button.

0===========0
 Source code
0===========0

Source code can be found on Github: https://github.com/TimoVesalainen/Nintenlord-UPS-patcher

0=======0
 Credits
0=======0

-byuu: Creating UPS format and the original patcher.
-rehdi93: Bringing poor performance for large patch data getting 
 to my attention and suggesting the fix.
-People: From expressing their opinion about tsukuyomi. It compelled
 me to make this patcher.
-Nintenlord: From making this utility and README. 

0==========0
 Disclaimer
0==========0

The user is responsible by all damage caused by this patcher. The creator 
of this patcher or patching format are not responsible for it.