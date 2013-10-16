singleton TSShapeConstructor(PlayerAnim_Lurker_Death3DAE)
{
   baseShape = "./PlayerAnim_Lurker_Death3.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Death3DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death3", "1280", "1320");
}
