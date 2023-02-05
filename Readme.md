﻿# Jewel
A PCSX2 trainer for Sly 2: Band of Thieves.

![Screenshot of the Jewel trainer](screenshot.png "Jewel Trainer")

## Features
* Displays a list of all loaded entities in the current map
* Click on an entity to view/change its position or scale
* Focus the camera on any entity with the click of a button
* Change the camera view size, render distance, FOV, etc.

## Build Instructions
Clone the repo into Visual Studio and make sure the build target is set as x64.
  
If you get an error about Memory.dll, run this command from the Package Manager Console:
```
Update-Package -reinstall
```

If that still doesn't work, please open a [new issue](https://github.com/TheOnlyZac/Jewel/issues/new).
