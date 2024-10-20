<img src="https://img.shields.io/badge/LiFx%20Server%20-%3E%3Dv3.0.0-green" />

# Loot

[Download here](https://github.com/LiF-x/starterKits/releases/latest)

## Pre requisite

- This mod requires the LiFx Server Framework version 3.0.0 or newer

### Installation instructions

1. Download the latest package from the above link.
2. Stop your server
3. Remove older versions of the mod. To remove the mod delete the folder StarterKits from inside the Mods folder of your server.
4. Upload the zip file you downloaded in step 1. to the "mods" folder in your server via file manager or ftp.
5. Extract the zip file inside the mods folder.
6. Delete the mod zip file you uploaded (important!)
7. Start the server

### Configuration

1. Edit the starterkitsTable.cs file
2. Add one line per drop item following this template *dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (ContainerObjectID, ItemObjectID, Quality, Quantity)");* Where you replace the values according to your drop wishes.

#### Column explanation:
| Column | Description |
|-|-|
| ContainerObjectID | The ID of the container of which you want the loot to drigger on, when it is added to the world. |
| ItemObjectID | The ID of the loot you wish to put into the container |
| Quality | The quality of the object you want to spawn in to the container |
| Quantity | The quantity of objects of the object type you want to spawn in to the container |

Any storage container can be used to spawn loot inside, which could make it perfect for events such as hunger games, or simply as starter kits.
- To ensure items do not go into new containers, we recommend creating new storage devices to be used with these
