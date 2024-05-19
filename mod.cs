/**
* <author>Christophe Roblin</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no></credits>
* <description>Loot functionality for Life is Feudal: Your Own, works on new containers</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxStarterkits))
{
    new ScriptObject(LiFxStarterkits) { };
}

package LiFxStarterkits
{
    function LiFxStarterkits::setup() {
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, dbInit, LiFxStarterkits);
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Dbchanges, LiFxStarterkits);
    }

    function LiFxStarterkits::loottable() {
        return "LiFxStarterKits";
    }

    function LiFxStarterkits::dbInit() {
        %tableName = LiFxStarterkits::loottable();
        dbi.Update("DROP TABLE IF EXISTS `" @ %tableName @ "`");

        %sqlTrigger = "CREATE TRIGGER `" @ %tableName @ "_trigger` AFTER INSERT ON `containers` " @
                      "FOR EACH ROW BEGIN " @
                      "INSERT INTO items SELECT NULL, new.ID, ItemObjectTypeID, Quality, Quantity, 100 AS Durability, 100 AS CreatedDurability, NULL FROM " @ %tableName @ " WHERE ContainerObjectTypeID = new.ObjectTypeID; END;";

        %sqlTable = "CREATE TABLE IF NOT EXISTS `" @ %tableName @ "` (\n";
        %sqlTable = %sqlTable @ "`ContainerObjectTypeID` INT(11) NOT NULL,\n";
        %sqlTable = %sqlTable @ "`ItemObjectTypeID` INT(11) NOT NULL,\n";
        %sqlTable = %sqlTable @ "`Quality` INT(11) NOT NULL,\n";
        %sqlTable = %sqlTable @ "`Quantity` INT(11) NOT NULL\n";
        %sqlTable = %sqlTable @ ")\n";
        %sqlTable = %sqlTable @ "COLLATE='utf8mb3_unicode_ci'\n";
        %sqlTable = %sqlTable @ "ENGINE=InnoDB;\n";

        dbi.Update("DROP TRIGGER IF EXISTS `" @ %tableName @ "_trigger`"); // Drop trigger to ensure we have the updated ones at all times
        dbi.Update(%sqlTrigger); // Insert trigger
        dbi.Update(%sqlTable); // Create the table if it does not exist

        echo("Loot table and trigger initialized successfully.");
    }

    function LiFxStarterkits::dbChanges() {
        dbi.Update("TRUNCATE TABLE `" @ LiFxStarterkits::loottable() @ "`");
        exec("./starterkitsTable.cs");
    }

    function LiFxStarterkits::version() {
        return "1.0.0";
    }
};

activatePackage(LiFxStarterkits);
