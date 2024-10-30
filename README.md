# Clipboard Copy Monitoring Utility
[![C#](https://custom-icon-badges.demolab.com/badge/C%23-%23239120.svg?logo=cshrp&logoColor=white)](#)

## About
Ever lose track of something you copied/pasted? Or end up copying something else and have to spend a lot of time hunting down the first text you copied? Maybe you have to copy/paste a bunch of alternating values repeatedly?

You would benefit from this Clipboard Monitoring Utility. This tool is a C# desktop application that monitors the clipboard over Windows API. The tool saves all copied text in a scrollable rich textbox with timestamps. You can easily go back and re-reference anything you copied in the past and not lose track.

## Security Warning for Password Use/Sensitive Text
Tracking text values that are copied to the clipboard includes passwords. This means the utility will openly display the text values of passwords if you copy them and the utility is running. If you have any external entities monitoring your screen, either remotely via technology, or physically within your presence, it's suggested to avoid copying sensitive text values while running this utility.
