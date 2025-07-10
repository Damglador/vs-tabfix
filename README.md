# Tab Fix

Based on the [official mod template](https://github.com/anegostudios/vsmodtemplate) and decompile of [tabfixer/tab_fix/Tab key focus disable](https://mods.vintagestory.at/tabfixer) from [Alex H/papierschnitt](https://mods.vintagestory.at/show/user/bd284f6fb06c41feac31)

The old mod shipped with it's own libraries that are already provided with the game and was getting borked after every update, especially after glibc 2.41. Couldn't live without that mod, so here I am.

## Usage
- Get a copy of this template by either using the "Use this Template" on github or cloning it or downloading a .zip file.
- Open the Project with your preferred IDE
- Run the template


The template uses the Cake build system to produce a mod ready to release for you.
You can create a release with one of the following methods:
- In Visual Studio and Rider Select to run the CakeBuilder Project.
- In Visual Studio Code click on "Terminal" > "Run Task" > "package"
- run the build.ps1 or build.sh

This will then produce the `tabfix_x.x.x.zip` inside the `Release` folder in the project root folder.