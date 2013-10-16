
singleton TSShapeConstructor(SoldierDAE)
{
   baseShape = "./soldier_rigged.dae";
   loadLights = "0";
   unit = "1.0";
   upAxis = "DEFAULT";
   lodType = "TrailingNumber";
   matNamePrefix = "";
   ignoreNodeScale = "0";
   adjustCenter = "0";
   adjustFloor = "0";
   forceUpdateMaterials = "0";
};

function SoldierDAE::onLoad(%this)
{
   %this.addSequence("ambient", "root", "0", "60");
   %this.addSequence("ambient", "run", "1510", "1530");
   %this.addSequence("ambient", "back", "1610", "1630");
   %this.addSequence("ambient", "side", "1560", "1580");
   %this.addSequence("ambient", "crouch_root", "330", "390");
   %this.addSequence("ambient", "crouch_forward", "1660", "1690");
   %this.addSequence("ambient", "crouch_backward", "1720", "1750");
   %this.addSequence("ambient", "crouch_side", "1780", "1810");
   %this.addSequence("ambient", "swim_root", "2150", "2210");
   %this.addSequence("ambient", "swim_forward", "2240", "2300");
   %this.addSequence("ambient", "swim_backward", "2330", "2390");
   %this.addSequence("ambient", "swim_left", "2420", "2480");
   %this.addSequence("ambient", "swim_right", "2510", "2570");
   %this.addSequence("ambient", "death1", "1230", "1270");
   %this.setSequenceCyclic("death1", "0");
   %this.addSequence("ambient", "death2", "1300", "1340");
   %this.setSequenceCyclic("death2", "0");
   %this.addSequence("ambient", "death3", "1370", "1410");
   %this.setSequenceCyclic("death3", "0");
   %this.addSequence("ambient", "jump", "1040", "1050");
   %this.setSequenceCyclic("jump", "0");
   %this.addSequence("ambient", "land", "1950", "1960");
   %this.setSequenceCyclic("land", "0");
   %this.addSequence("ambient", "fall", "1890", "1905");
   %this.setSequenceCyclic("fall", "0");
   %this.addSequence("ambient", "sitting", "1840", "1840");
   %this.addSequence("ambient", "look", "1990", "2000");
   %this.setSequenceCyclic("look", "0");
   %this.setSequenceBlend("look", "1", "root", "0");
   %this.removeNode("Soldier_LOD300");
   %this.removeNode("Soldier_LOD200");
   %this.removeNode("Soldier_LOD100");
   %this.removeNode("Soldier_LOD2");
   %this.removeNode("Dazzles_Back_LOD300");
   %this.removeNode("Dazzles_Back_LOD200");
   %this.removeNode("EnvironmentAmbientLight");
   %this.removeNode("NullDetail1");
   %this.setNodeTransform("cam", "0 0 1.90056 1 0 0 0", "1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_GutShot", "Death4", "0", "-1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_HeadShot", "Death5", "0", "-1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_ChestShot", "Death6", "0", "-1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_Drop2Knees", "Death7", "0", "-1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_FlopBack", "Death8", "0", "-1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_Turtle", "Death9", "0", "-1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_GroinShot", "Death10", "0", "-1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_BackShot", "Death11", "0", "-1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_PopUp", "Death12", "0", "-1");
   %this.addSequence("./Anims/Soldier_Death_Pack_Anims.dae Death_NeckShot", "Death13", "0", "-1");
}
