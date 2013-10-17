singleton TSShapeConstructor(PlayerAnim_Mamba__Idle_Gun_CheckDAE)
{
   baseShape = "./PlayerAnim_Mamba__Idle_Gun_Check.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba__Idle_Gun_CheckDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "_Idle_Gun_Check", "620", "710");
}
