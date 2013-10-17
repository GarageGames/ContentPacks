singleton TSShapeConstructor(PlayerAnim_Ender_Swim_IdleDAE)
{
   baseShape = "./PlayerAnim_Ender_Swim_Idle.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Swim_IdleDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Idle", "1270", "1329");
}
