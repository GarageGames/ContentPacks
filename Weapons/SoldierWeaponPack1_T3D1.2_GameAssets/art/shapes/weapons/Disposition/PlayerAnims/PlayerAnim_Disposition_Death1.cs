singleton TSShapeConstructor(PlayerAnim_Disposition_Death1DAE)
{
   baseShape = "./PlayerAnim_Disposition_Death1.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Death1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death1", "1030", "1070");
}
