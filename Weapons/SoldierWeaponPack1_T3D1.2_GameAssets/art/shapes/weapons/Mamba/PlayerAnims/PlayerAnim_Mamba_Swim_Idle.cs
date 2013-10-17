singleton TSShapeConstructor(PlayerAnim_Mamba_Swim_IdleDAE)
{
   baseShape = "./PlayerAnim_Mamba_Swim_Idle.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Swim_IdleDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Idle", "1400", "1459");
}
