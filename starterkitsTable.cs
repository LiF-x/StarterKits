// This file defines the starter kits table for Life is Feudal: Your Own

$StarterKits::KitCount = 23; // Total number of items in the starter kit
// New guild kit
// Format: ContainerObjectID ItemObjectID Quality Quantity
//dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (ContainerObjectID, ItemObjectID, Quality, Quantity)");

    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 1685, 40, 1)"); // Courier
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 1663, 40, 1)"); // Moose
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 1015, 100, 20)"); // Pizza
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 1061, 100, 10)"); // Gold Coin
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 342, 40, 100)"); // Bones
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 324, 40, 20)"); // Hardwood Billets
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 269, 40, 10)"); // Shaped Rocks
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 789, 40, 40)"); // Refreshing Preps
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 51, 60, 1)"); // Saw
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 46, 60, 1)"); // Hatchet
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 44, 60, 1)"); // Mallet
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 40, 60, 1)"); // Shovel
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 33, 60, 1)"); // Sickle
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2578, 48, 60, 1)"); // Pickaxe

// Joiner Kit 
// Format: ContainerObjectID ItemObjectID Quality Quantity
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2579, 1685, 40, 1)"); // Courier
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2579, 1015, 100, 20)"); // Pizza
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2579, 1061, 100, 5)"); // Gold Coin
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2579, 51, 60, 1)"); // Saw
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2579, 46, 60, 1)"); // Hatchet
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2579, 44, 60, 1)"); // Mallet
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2579, 40, 60, 1)"); // Shovel
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2579, 33, 60, 1)"); // Sickle
    dbi.Update("INSERT IGNORE INTO `" @ LiFxStarterkits::loottable() @ "` VALUES (2579, 48, 60, 1)"); // Pickaxe

