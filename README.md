# Valheim-TimeOfDay
Shows the Time Of Day in the Valheim HUD.

Requires the BepInEx plugin and additional UnityEngine libraries.

## Setup
Copy to the Valheim/BepInEx/plugins folder.

# Creating Valheim Mods
This mod can be used as an example of how Valheim mods are created.

## Requirements

ValheimPlus, BepInEx, Visual Studio with .NET Framework 4

### Setup
Step 1: Download the latest release of [BepInEx_x64 zip](https://github.com/BepInEx/BepInEx/releases)

Step 2: Extract the contents of the zip into Valheim's root folder.

Step 3: Download the ValheimPlus mod, and extract only the Managed folder into the valheim_Data/Managed folder.

### New Mods
Step 1: Open Visual Studio and create a new Class Library (.NET Framework) using .NET Framework 4.

Step 2: Add References to assembly_valheim.dll, BepInEx.dll, UnityEngine.dll, and UnityEngine.CoreModule.dll.

Step 3: Rename Class1.cs to [ModName]Plugin, and extend BaseUnityPlugin. This makes the class into an injected MonoBehaviour.


To test your code, build the project. This will create a dll in [Project]/bin/Debug/. Copy this dll to Valheim/BepInEx/plugins and start the game.

#

See [BepInEx Plugin Development](https://bepinex.github.io/bepinex_docs/master/articles/dev_guide/plugin_tutorial/index.html) for more information.
