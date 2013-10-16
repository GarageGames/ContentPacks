singleton TSShapeConstructor(PlayerAnim_Lurker_LookDAE)
{
   baseShape = "./PlayerAnim_Lurker_Look.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Look", "950", "960");
}
