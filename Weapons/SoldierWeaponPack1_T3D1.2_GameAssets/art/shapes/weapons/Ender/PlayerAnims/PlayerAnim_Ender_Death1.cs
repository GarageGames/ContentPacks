singleton TSShapeConstructor(PlayerAnim_Ender_Death1DAE)
{
   baseShape = "./PlayerAnim_Ender_Death1.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Death1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death1", "1090", "1130");
}
