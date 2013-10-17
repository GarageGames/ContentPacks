singleton TSShapeConstructor(PlayerAnim_Disposition_Idle_Radio_CheckDAE)
{
   baseShape = "./PlayerAnim_Disposition_Idle_Radio_Check.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Idle_Radio_CheckDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Idle_Radio_Check", "670", "780");
}
