# MyClipboard: A Clipboard Copy/Paste Monitoring Utility
[![C#](https://custom-icon-badges.demolab.com/badge/C%23-%23239120.svg?logo=cshrp&logoColor=white)](#)

## About
Ever lose track of something you copied/pasted? Or end up copying something else and have to spend a lot of time hunting down the first text you copied? Maybe you have to copy/paste a bunch of alternating values repeatedly?

You would benefit from this MyClipboard Copy/Paste Monitoring Utility! This tool is a C# desktop application that monitors the clipboard over Windows API. The tool saves all copied text in a scrollable rich textbox with timestamps. You can easily go back and re-reference anything you copied in the past and not lose track.

## V2 Update
This utility has been modified with the following enhancements:
- A rolling log.txt file that automatically creates/saves in C:/MyClipboard. This log will continuously save whatever text is copied in perpetuity, ensuring older data is saved in the case a machine is rebooted.
- An image tracker tab which keeps track of the most recent image copied to the clipboard.
- Performance and speed enhancements. These enhancements now require .NET Runtime 6.0 or later.
- An autosave feature and autosave tracker in the interface which denotes whether the autosave functionality is working accurately.

_The V1 code remains available in the .v1 directory for reference._


## The Utility
``![Screenshot_of_Utility](https://gist.github.com/user-attachments/assets/e8304c29-041f-4a35-96c9-e004b0ea0f59)``

## Security Warning for Password Use/Sensitive Text
Tracking text values that are copied to the clipboard includes passwords. This means the utility will openly display the text values of passwords if you copy them and the utility is running. If you have any external entities monitoring your screen, either remotely via technology, or physically within your presence, it's suggested to avoid copying sensitive text values while running this utility.
