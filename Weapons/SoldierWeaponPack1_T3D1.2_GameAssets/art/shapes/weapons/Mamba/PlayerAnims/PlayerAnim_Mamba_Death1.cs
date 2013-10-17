singleton TSShapeConstructor(PlayerAnim_Mamba_Death1DAE)
{
   baseShape = "./PlayerAnim_Mamba_Death1.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Death1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death1", "1140", "1180");
}
