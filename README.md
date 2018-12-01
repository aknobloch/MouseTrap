# MouseTrap

### Purpose
Moves the Windows mouse cursor to the middle of the secondary screen. I was having an issue where remotely booting my computer via the Steam Link (with Xbox Controller) and launching a game that did not gracefully hide the mouse pointer resulted in the mouse pointer being shown in the middle of the screen, despite the fact that I was using a controller. There was third party solutions to hide the pointer but I don't trust random software, so instead I wrote a simple program to just move the mouse to the secondary desktop on login.

### Build and Setup
This is enabled by building the project via `dotnet build -r win10-x64` to build an EXE file, and then copying said directory with EXE to `C:/Program Files/MouseTrap/`. Finally, create a Task Schedule to run on system unlock with the following action: `"%SYSTEMDRIVE%/Program Files/MouseTrap/MouseTrap.exe"`. 
