singleton TSShapeConstructor(PlayerAnim_Disposition_Swim_IdleDAE)
{
   baseShape = "./PlayerAnim_Disposition_Swim_Idle.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Swim_IdleDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Idle", "1210", "1269");
}
