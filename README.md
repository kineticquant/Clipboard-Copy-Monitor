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
![Screenshot_of_Utility](https://private-user-images.githubusercontent.com/51172274/381687474-e8304c29-041f-4a35-96c9-e004b0ea0f59.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MzAzMTM2NTMsIm5iZiI6MTczMDMxMzM1MywicGF0aCI6Ii81MTE3MjI3NC8zODE2ODc0NzQtZTgzMDRjMjktMDQxZi00YTM1LTk2YzktZTAwNGIwZWEwZjU5LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNDEwMzAlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjQxMDMwVDE4MzU1M1omWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTI3MWIzYzNhODExYzU2ZjgwNjE3N2M2M2MxODUzMzgzZWQ1MDA4ZmZkMzkwZmIzOTI1ZDY2OGVlMDA0N2Y5MjYmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.3vnKzuUoq3neuV3KNoW21VBKbUhb_QOzqSnFKgR-uhE)

## Security Warning for Password Use/Sensitive Text
Tracking text values that are copied to the clipboard includes passwords. This means the utility will openly display the text values of passwords if you copy them and the utility is running. If you have any external entities monitoring your screen, either remotely via technology, or physically within your presence, it's suggested to avoid copying sensitive text values while running this utility.
