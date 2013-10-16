
singleton TSShapeConstructor(Soldier_Death_Pack_AnimsDae)
{
   baseShape = "./Soldier_Death_Pack_Anims.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Death_Pack_AnimsDae::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "0");
   %this.renameSequence("ambient", "timeline");
   %this.addSequence("timeline", "Death_GutShot", "40", "90");
   %this.setSequenceCyclic("Death_GutShot", "0");
   %this.addSequence("timeline", "Death_HeadShot", "130", "180");
   %this.setSequenceCyclic("Death_HeadShot", "0");
   %this.addSequence("timeline", "Death_ChestShot", "210", "244");
   %this.setSequenceCyclic("Death_ChestShot", "0");
   %this.addSequence("timeline", "Death_Drop2Knees", "400", "490");
   %this.setSequenceCyclic("Death_Drop2Knees", "0");
   %this.addSequence("timeline", "Death_FlopBack", "530", "562");
   %this.setSequenceCyclic("Death_FlopBack", "0");
   %this.addSequence("timeline", "Death_Turtle", "610", "700");
   %this.setSequenceCyclic("Death_Turtle", "0");
   %this.addSequence("timeline", "Death_GroinShot", "730", "820");
   %this.setSequenceCyclic("Death_GroinShot", "0");
   %this.addSequence("timeline", "Death_BackShot", "860", "905");
   %this.setSequenceCyclic("Death_BackShot", "0");
   %this.addSequence("timeline", "Death_PopUp", "930", "1020");
   %this.setSequenceCyclic("Death_PopUp", "0");
   %this.addSequence("timeline", "Death_NeckShot", "290", "368");
   %this.setSequenceCyclic("Death_NeckShot", "0");
}
