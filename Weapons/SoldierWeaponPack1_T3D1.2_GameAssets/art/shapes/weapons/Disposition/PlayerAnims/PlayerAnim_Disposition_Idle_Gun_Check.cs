singleton TSShapeConstructor(PlayerAnim_Disposition_Idle_Gun_CheckDAE)
{
   baseShape = "./PlayerAnim_Disposition_Idle_Gun_Check.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Idle_Gun_CheckDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Idle_Gun_Check", "550", "640");
}
