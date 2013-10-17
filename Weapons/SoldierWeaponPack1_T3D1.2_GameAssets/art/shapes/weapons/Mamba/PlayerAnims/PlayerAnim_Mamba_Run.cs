singleton TSShapeConstructor(PlayerAnim_Mamba_RunDAE)
{
   baseShape = "./PlayerAnim_Mamba_Run.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "150", "169");
}
