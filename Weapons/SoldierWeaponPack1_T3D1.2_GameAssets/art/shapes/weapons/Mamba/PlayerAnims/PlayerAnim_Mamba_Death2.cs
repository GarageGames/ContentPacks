singleton TSShapeConstructor(PlayerAnim_Mamba_Death2DAE)
{
   baseShape = "./PlayerAnim_Mamba_Death2.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Death2DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death2", "1210", "1255");
}
