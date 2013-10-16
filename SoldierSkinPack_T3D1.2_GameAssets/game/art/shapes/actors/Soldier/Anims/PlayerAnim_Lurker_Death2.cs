singleton TSShapeConstructor(PlayerAnim_Lurker_Death2DAE)
{
   baseShape = "./PlayerAnim_Lurker_Death2.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Death2DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death2", "1210", "1255");
}
