singleton TSShapeConstructor(PlayerAnim_Ender_Death2DAE)
{
   baseShape = "./PlayerAnim_Ender_Death2.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Death2DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death2", "1160", "1200");
}
