singleton TSShapeConstructor(PlayerAnim_Mamba__Idle_Radio_CheckDAE)
{
   baseShape = "./PlayerAnim_Mamba__Idle_Radio_Check.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba__Idle_Radio_CheckDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "_Idle_Radio_Check", "740", "850");
}
