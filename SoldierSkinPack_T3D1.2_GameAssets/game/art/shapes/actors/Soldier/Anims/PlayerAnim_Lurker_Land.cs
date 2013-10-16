singleton TSShapeConstructor(PlayerAnim_Lurker_LandDAE)
{
   baseShape = "./PlayerAnim_Lurker_Land.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Land", "1100", "1110");
}
