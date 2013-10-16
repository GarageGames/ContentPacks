singleton TSShapeConstructor(PlayerAnim_Lurker_Celebrate_01DAE)
{
   baseShape = "./PlayerAnim_Lurker_Celebrate_01.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Celebrate_01DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Celebrate_01", "2020", "2090");
}
