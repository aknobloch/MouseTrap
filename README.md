# MouseTrap

### Purpose
Moves the Windows mouse cursor to the middle of the secondary screen. I kept having an issue where remotely booting my computer via the Steam Link (with Xbox Controller) and then launching a game from it that did not gracefully handle the mouse pointer, resulting in the mouse pointer being glued to the middle of the screen despite the fact that I was using a controller, instead of hidden. There was third party solutions to hide the mouse but I don't trust random software, so instead I wrote a simple program to just move the mouse to the secondary desktop on login.

### Build and Setup
This is enabled by building the project via `dotnet build -r win10-x64` to build an EXE file, and then copying said directory with EXE to `C:/Program Files/MouseTrap/`. Finally, create a TaskSchedule to run on system unlock with the following action: `"%SYSTEMDRIVE%/Program Files/MouseTrap/MouseTrap.exe"`. 
